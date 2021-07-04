using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortCommunicate
{
    public partial class SerialPortCommunicate : Form
    {
        Thread RefreshCom_Thread;
        Thread DataReceived;

        private delegate void RefreshUI_Com();
        private delegate void RefreshUl_DataRec(Byte[] DataRec);
        private delegate void RefreshUl_listBoxMemory();
        private delegate void RefreshUl_PortDisconnect();

        ArrayList DeviceID = new ArrayList(), Description = new ArrayList();

        Dictionary<string, string> MemoryDatas = new Dictionary<string, string>();

        public SerialPortCommunicate()
        {
            InitializeComponent();
        }

        private void SerialPortCommunicate_Load(object sender, EventArgs e)
        {
            RefreshCom_Thread = new Thread(RefreshCom);
            RefreshCom_Thread.IsBackground = true;
            RefreshCom_Thread.Start();

            comBoxBR.SelectedIndex = 3;
            comBoxParity.SelectedIndex = 0;
            comBoxDataBits.SelectedIndex = 1;
            comBoxStopBits.SelectedIndex = 1;
        }

        //Open/Close Port
        private void btnPortOnOff_Click(object sender, EventArgs e)
        {
            switch (btnPortOnOff.Text)
            {
                case "Open Port":
                    if (comBoxPort.SelectedIndex == -1)
                        MessageBox.Show("You need to select one of com before you Open Port", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        ComPort.PortName = DeviceID[comBoxPort.SelectedIndex].ToString();
                        if (comBoxBR.SelectedItem == null)
                            ComPort.BaudRate = Convert.ToInt32(comBoxBR.Text);
                        else
                            ComPort.BaudRate = Convert.ToInt32(comBoxBR.SelectedItem);
                        switch (comBoxParity.SelectedIndex)
                        {
                            case 0:
                                ComPort.Parity = System.IO.Ports.Parity.None;
                                break;
                            case 1:
                                ComPort.Parity = System.IO.Ports.Parity.Odd;
                                break;
                            case 2:
                                ComPort.Parity = System.IO.Ports.Parity.Even;
                                break;
                            case 3:
                                ComPort.Parity = System.IO.Ports.Parity.Mark;
                                break;
                            case 4:
                                ComPort.Parity = System.IO.Ports.Parity.Space;
                                break;
                        }
                        if (comBoxDataBits.SelectedItem == null)
                            ComPort.DataBits = Convert.ToInt32(comBoxDataBits.Text);
                        else
                            ComPort.DataBits = Convert.ToInt32(comBoxDataBits.SelectedItem);
                        switch (comBoxStopBits.SelectedIndex)
                        {
                            case 0:
                                ComPort.StopBits = System.IO.Ports.StopBits.None;
                                break;
                            case 1:
                                ComPort.StopBits = System.IO.Ports.StopBits.One;
                                break;
                            case 2:
                                ComPort.StopBits = System.IO.Ports.StopBits.Two;
                                break;
                            case 3:
                                ComPort.StopBits = System.IO.Ports.StopBits.OnePointFive;
                                break;
                        }

                        if (chkClearOnOpen.Checked == true)
                            rchTxtBoxData.Clear();
                        try
                        {
                            ComPort.Open();
                            btnPortOnOff.Text = "Close Port";
                            timComRefresh.Enabled = false;
                            txtCommand.Enabled = true;
                            btnSend.Enabled = true;
                            btnMemory.Enabled = true;
                            groBoxComPortSet.Enabled = false;

                            DataReceived = new Thread(Received);
                            DataReceived.IsBackground = true;
                            DataReceived.Start();
                        }
                        catch (UnauthorizedAccessException)
                        {
                            MessageBox.Show("通訊埠可能已被其他程式開啟，請關閉該程式後再試一次。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "Close Port":
                    ComPort.Close();
                    btnPortOnOff.Text = "Open Port";
                    timComRefresh.Enabled = true;
                    txtCommand.Enabled = false;
                    btnSend.Enabled = false;
                    btnMemory.Enabled = false;
                    groBoxComPortSet.Enabled = true;

                    DataReceived.Abort();
                    break;
            }
        }
        
        //btn_Send
        private void btnSend_Click(object sender, EventArgs e)
        {
            int len = 0;
            string txt = txtCommand.Text;
            Byte[] dataSend;

            if (radHex.Checked == true)
            {
                txt = txt.Replace(" ", null);
                if (txt.Length % 2 == 0)
                {
                    len = txt.Length / 2;
                    dataSend = new Byte[len];
                    for(int i = 0; i < dataSend.Length; i++)
                    {
                        dataSend[i] = Convert.ToByte(Convert.ToInt32(txt.Substring(0, 2), 16));
                        rchTxtBoxData.Select(rchTxtBoxData.TextLength, 0);
                        rchTxtBoxData.SelectionColor = Color.Green;
                        rchTxtBoxData.AppendText(txt.Substring(0, 2) + " ");
                        txt = txt.Remove(0, 2);
                    }
                    ComPort.Write(dataSend, 0, dataSend.Length);
                    rchTxtBoxData.AppendText("\n");
                }
                else
                    MessageBox.Show("Text Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radTxt.Checked == true)
            {
                len = txt.Length;
                dataSend = new Byte[len];
                for (int i = 0; i < dataSend.Length; i++)
                {
                    dataSend[i] = Convert.ToByte(Convert.ToInt32(txt[i]));
                    rchTxtBoxData.Select(rchTxtBoxData.TextLength, 0);
                    rchTxtBoxData.SelectionColor = Color.Green;
                    rchTxtBoxData.AppendText(txt[i] + " ");
                }
                ComPort.Write(dataSend, 0, dataSend.Length);
                rchTxtBoxData.AppendText("\n");
            }
        }

        //btn_Memory
        private void btnMemory_Click(object sender, EventArgs e)
        {
            string MemoryText = txtCommand.Text;
            MemoryText = MemoryText.Replace(" ", null);
            for (int i = 2; i < MemoryText.Length; i += 3)
                MemoryText = MemoryText.Insert(i, " ");

            MemoryDatas.Add(MemoryText, MemoryText);
            listBoxMemory.Items.Add(MemoryText);
        }

        //btn_Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            rchTxtBoxData.Clear();
        }

        //DataReceived
        private void Received()
        {
            Byte[] DataRec = new Byte[1];
            RefreshUl_DataRec RefreshUl_DataRec = new RefreshUl_DataRec(DataRecRefresh);

            while (true)
            {
                try
                {
                    if (ComPort.BytesToRead > 0)
                    {
                        ComPort.Read(DataRec, 0, DataRec.Length);
                        Invoke(RefreshUl_DataRec, DataRec);
                    }
                }
                catch (InvalidOperationException)
                {
                    break;
                }
                catch(UnauthorizedAccessException)
                {
                    RefreshUl_PortDisconnect RefreshUl_PortDisconnect = new RefreshUl_PortDisconnect(PortDisconnect);
                    Invoke(RefreshUl_PortDisconnect);
                    break;
                }
            }
        }

        //Thread_RefreshCom
        private void RefreshCom()
        {
            RefreshUI_Com RefreshUI_Com = new RefreshUI_Com(ComRefresh);
            ArrayList DeviceID_Method = new ArrayList(), Description_Method = new ArrayList();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT Description,DeviceID FROM Win32_SerialPort");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                DeviceID_Method.Add(queryObj["DeviceID"].ToString());
                Description_Method.Add(queryObj["Description"].ToString());
            }
            if (DeviceID_Method.Count == DeviceID.Count)
            {
                for (int i = 0; i < DeviceID_Method.Count; i++)
                {
                    if (Description[i] != Description_Method[i])
                    {
                        DeviceID = DeviceID_Method;
                        Description = Description_Method;
                        Invoke(RefreshUI_Com);
                    }
                }
            }
            else if (DeviceID_Method.Count > DeviceID.Count || DeviceID_Method.Count < DeviceID.Count)
            {
                DeviceID = DeviceID_Method;
                Description = Description_Method;
                Invoke(RefreshUI_Com);
            }
        }

        //RefreshUI_ComRefresh
        private void ComRefresh()
        {
            comBoxPort.Items.Clear();
            foreach (string f in Description)
                comBoxPort.Items.Add(f);
        }

        //RefreshUl_DataRecRefresh
        private void DataRecRefresh(Byte[] DataRec)
        {
            if (radHex.Checked == true)
            {
                for (int i = 0; i < DataRec.Length; i++)
                {
                    rchTxtBoxData.Select(rchTxtBoxData.TextLength, 0);
                    rchTxtBoxData.SelectionColor = Color.Blue;
                    if (DataRec[i] >= 0x10)
                        rchTxtBoxData.AppendText(Convert.ToString(Convert.ToInt32(DataRec[i]), 16) + " ");
                    else
                        rchTxtBoxData.AppendText("0" + Convert.ToString(Convert.ToInt32(DataRec[i]), 16) + " ");
                }
            }
            else if (radTxt.Checked == true)
            {
                for (int i = 0; i < DataRec.Length; i++)
                {
                    rchTxtBoxData.Select(rchTxtBoxData.TextLength, 0);
                    rchTxtBoxData.SelectionColor = Color.Blue;
                    rchTxtBoxData.AppendText(Convert.ToChar(DataRec[i]).ToString());
                }
            }
        }

        //RefreshUI_PortDisconnect
        private void PortDisconnect()
        {
            EventArgs e = new EventArgs();
            btnPortOnOff_Click(btnPortOnOff, e);
        }

        //Timer_CheckCom
        private void timComRefresh_Tick(object sender, EventArgs e)
        {
            if (RefreshCom_Thread.IsAlive == false)
            {
                RefreshCom_Thread = new Thread(RefreshCom);
                RefreshCom_Thread.IsBackground = true;
                RefreshCom_Thread.Start();
            }
        }

        private void chkDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDTR.Checked == true)
                ComPort.DtrEnable = true;
            else
                ComPort.DtrEnable = false;
        }

        private void chkRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRTS.Checked == true)
                ComPort.RtsEnable = true;
            else
                ComPort.RtsEnable = false;
        }

        private void listBoxMemory_Click(object sender, EventArgs e)
        {
            if (listBoxMemory.SelectedIndex != -1)
            {
                txtCommand.Text = MemoryDatas[listBoxMemory.SelectedItem.ToString()];
                txtCommand.Focus();
            }
        }

        private void listBoxMemory_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxMemory.SelectedIndex == -1)
                return;
            Rectangle r = listBoxMemory.GetItemRectangle(listBoxMemory.SelectedIndex);
            txtEdit.Location = new Point(r.X + listBoxMemory.Location.X, r.Y + listBoxMemory.Location.Y + 15);
            txtEdit.Size = new Size(r.Width, r.Height);
            txtEdit.Visible = true;
            txtEdit.Text = MemoryDatas[(string)listBoxMemory.SelectedItem];
            txtEdit.Focus();
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                listBoxMemory.Focus();
            }
        }

        private void txtEdit_Leave(object sender, EventArgs e)
        {
            MemoryDatas[(string)listBoxMemory.SelectedItem] = txtEdit.Text;
            txtEdit.Visible = false;
            listBoxMemory.Focus();
        }

        private void txtCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
                btnSend_Click(sender, e);
        }

        private void rchTxtBoxData_TextChanged(object sender, EventArgs e)
        {
            rchTxtBoxData.ScrollToCaret();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Memory Import";
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            dlg.Filter = "Txt File|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(dlg.FileName))
                {
                    try
                    {
                        string line = "";
                        string memoryName = "";
                        string memoryData = "";
                        Dictionary<string, string> MemoryDatas_New = new Dictionary<string, string>();

                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line != "" || line.StartsWith("//"))//"//"←註解
                            {
                                string[] lineDetail = line.Split(':');

                                if (lineDetail[0] == "Name")
                                    memoryName = lineDetail[1];
                                else if (lineDetail[0] == "Data")
                                {
                                    memoryData = lineDetail[1];

                                    if (string.IsNullOrEmpty(memoryName))
                                        memoryName = memoryData;
                                    MemoryDatas_New.Add(memoryName, memoryData);
                                }
                            }
                        }

                        MemoryDatas = MemoryDatas_New;
                        listBoxMemory.Items.Clear();
                        foreach (var data in MemoryDatas)
                            listBoxMemory.Items.Add(data.Key);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("檔案格式有誤");
                    }
                }
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Memory Export";
            dlg.FileName = "Memory_" + DateTime.Now.ToString("yyyyMMddHHmmSS");
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            dlg.Filter = "Txt File|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dlg.FileName))
                {
                    foreach(var data in MemoryDatas)
                    {
                        sw.WriteLine("Name:" + data.Key);
                        sw.WriteLine("Data:" + data.Value);
                        sw.WriteLine();
                    }
                }
            }
        }

        //CloseForm
        private void SerialPortCommunicate_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (RefreshCom_Thread.IsAlive)
                RefreshCom_Thread.Abort();
            if (DataReceived != null && DataReceived.IsAlive)
                DataReceived.Abort();
            Dispose();
        }
    }
}
