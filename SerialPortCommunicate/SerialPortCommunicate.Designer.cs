namespace SerialPortCommunicate
{
    partial class SerialPortCommunicate
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialPortCommunicate));
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groBoxComPortSet = new System.Windows.Forms.GroupBox();
            this.comBoxStopBits = new System.Windows.Forms.ComboBox();
            this.labStopBits = new System.Windows.Forms.Label();
            this.comBoxDataBits = new System.Windows.Forms.ComboBox();
            this.labDataBits = new System.Windows.Forms.Label();
            this.comBoxParity = new System.Windows.Forms.ComboBox();
            this.labParity = new System.Windows.Forms.Label();
            this.comBoxBR = new System.Windows.Forms.ComboBox();
            this.labBR = new System.Windows.Forms.Label();
            this.comBoxPort = new System.Windows.Forms.ComboBox();
            this.labPort = new System.Windows.Forms.Label();
            this.ComPort = new System.IO.Ports.SerialPort(this.components);
            this.groBoxDataMode = new System.Windows.Forms.GroupBox();
            this.radHex = new System.Windows.Forms.RadioButton();
            this.radTxt = new System.Windows.Forms.RadioButton();
            this.groBoxLineSingals = new System.Windows.Forms.GroupBox();
            this.chkCD = new System.Windows.Forms.CheckBox();
            this.chkDSR = new System.Windows.Forms.CheckBox();
            this.chkCTS = new System.Windows.Forms.CheckBox();
            this.chkRTS = new System.Windows.Forms.CheckBox();
            this.chkDTR = new System.Windows.Forms.CheckBox();
            this.timComRefresh = new System.Windows.Forms.Timer(this.components);
            this.listBoxMemory = new System.Windows.Forms.ListBox();
            this.rchTxtBoxData = new System.Windows.Forms.RichTextBox();
            this.chkClearOnOpen = new System.Windows.Forms.CheckBox();
            this.chkClearWithDTR = new System.Windows.Forms.CheckBox();
            this.btnPortOnOff = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.groBoxComPortSet.SuspendLayout();
            this.groBoxDataMode.SuspendLayout();
            this.groBoxLineSingals.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Enabled = false;
            this.txtCommand.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtCommand.Location = new System.Drawing.Point(16, 335);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(375, 25);
            this.txtCommand.TabIndex = 1;
            this.txtCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommand_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(616, 332);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 29);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(400, 332);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 29);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groBoxComPortSet
            // 
            this.groBoxComPortSet.Controls.Add(this.comBoxStopBits);
            this.groBoxComPortSet.Controls.Add(this.labStopBits);
            this.groBoxComPortSet.Controls.Add(this.comBoxDataBits);
            this.groBoxComPortSet.Controls.Add(this.labDataBits);
            this.groBoxComPortSet.Controls.Add(this.comBoxParity);
            this.groBoxComPortSet.Controls.Add(this.labParity);
            this.groBoxComPortSet.Controls.Add(this.comBoxBR);
            this.groBoxComPortSet.Controls.Add(this.labBR);
            this.groBoxComPortSet.Controls.Add(this.comBoxPort);
            this.groBoxComPortSet.Controls.Add(this.labPort);
            this.groBoxComPortSet.Location = new System.Drawing.Point(16, 371);
            this.groBoxComPortSet.Margin = new System.Windows.Forms.Padding(4);
            this.groBoxComPortSet.Name = "groBoxComPortSet";
            this.groBoxComPortSet.Padding = new System.Windows.Forms.Padding(4);
            this.groBoxComPortSet.Size = new System.Drawing.Size(599, 79);
            this.groBoxComPortSet.TabIndex = 4;
            this.groBoxComPortSet.TabStop = false;
            this.groBoxComPortSet.Text = "Com Port Settings";
            // 
            // comBoxStopBits
            // 
            this.comBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxStopBits.FormattingEnabled = true;
            this.comBoxStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.comBoxStopBits.Location = new System.Drawing.Point(497, 42);
            this.comBoxStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxStopBits.Name = "comBoxStopBits";
            this.comBoxStopBits.Size = new System.Drawing.Size(92, 23);
            this.comBoxStopBits.TabIndex = 1;
            // 
            // labStopBits
            // 
            this.labStopBits.AutoSize = true;
            this.labStopBits.Location = new System.Drawing.Point(495, 24);
            this.labStopBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStopBits.Name = "labStopBits";
            this.labStopBits.Size = new System.Drawing.Size(63, 15);
            this.labStopBits.TabIndex = 0;
            this.labStopBits.Text = "Stop Bits:";
            // 
            // comBoxDataBits
            // 
            this.comBoxDataBits.FormattingEnabled = true;
            this.comBoxDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.comBoxDataBits.Location = new System.Drawing.Point(396, 42);
            this.comBoxDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxDataBits.Name = "comBoxDataBits";
            this.comBoxDataBits.Size = new System.Drawing.Size(92, 23);
            this.comBoxDataBits.TabIndex = 1;
            // 
            // labDataBits
            // 
            this.labDataBits.AutoSize = true;
            this.labDataBits.Location = new System.Drawing.Point(393, 24);
            this.labDataBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDataBits.Name = "labDataBits";
            this.labDataBits.Size = new System.Drawing.Size(69, 15);
            this.labDataBits.TabIndex = 0;
            this.labDataBits.Text = "Data Bites:";
            // 
            // comBoxParity
            // 
            this.comBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxParity.FormattingEnabled = true;
            this.comBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comBoxParity.Location = new System.Drawing.Point(295, 42);
            this.comBoxParity.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxParity.Name = "comBoxParity";
            this.comBoxParity.Size = new System.Drawing.Size(92, 23);
            this.comBoxParity.TabIndex = 1;
            // 
            // labParity
            // 
            this.labParity.AutoSize = true;
            this.labParity.Location = new System.Drawing.Point(292, 22);
            this.labParity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labParity.Name = "labParity";
            this.labParity.Size = new System.Drawing.Size(45, 15);
            this.labParity.TabIndex = 0;
            this.labParity.Text = "Parity:";
            // 
            // comBoxBR
            // 
            this.comBoxBR.FormattingEnabled = true;
            this.comBoxBR.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comBoxBR.Location = new System.Drawing.Point(193, 42);
            this.comBoxBR.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxBR.Name = "comBoxBR";
            this.comBoxBR.Size = new System.Drawing.Size(92, 23);
            this.comBoxBR.TabIndex = 1;
            // 
            // labBR
            // 
            this.labBR.AutoSize = true;
            this.labBR.Location = new System.Drawing.Point(191, 22);
            this.labBR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBR.Name = "labBR";
            this.labBR.Size = new System.Drawing.Size(69, 15);
            this.labBR.TabIndex = 0;
            this.labBR.Text = "Baud Rate:";
            // 
            // comBoxPort
            // 
            this.comBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPort.FormattingEnabled = true;
            this.comBoxPort.Location = new System.Drawing.Point(11, 42);
            this.comBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxPort.Name = "comBoxPort";
            this.comBoxPort.Size = new System.Drawing.Size(173, 23);
            this.comBoxPort.TabIndex = 1;
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(8, 22);
            this.labPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(62, 15);
            this.labPort.TabIndex = 0;
            this.labPort.Text = "ComPort:";
            // 
            // groBoxDataMode
            // 
            this.groBoxDataMode.Controls.Add(this.radHex);
            this.groBoxDataMode.Controls.Add(this.radTxt);
            this.groBoxDataMode.Location = new System.Drawing.Point(623, 371);
            this.groBoxDataMode.Margin = new System.Windows.Forms.Padding(4);
            this.groBoxDataMode.Name = "groBoxDataMode";
            this.groBoxDataMode.Padding = new System.Windows.Forms.Padding(4);
            this.groBoxDataMode.Size = new System.Drawing.Size(93, 79);
            this.groBoxDataMode.TabIndex = 4;
            this.groBoxDataMode.TabStop = false;
            this.groBoxDataMode.Text = "Data Mode";
            // 
            // radHex
            // 
            this.radHex.AutoSize = true;
            this.radHex.Checked = true;
            this.radHex.Location = new System.Drawing.Point(8, 55);
            this.radHex.Margin = new System.Windows.Forms.Padding(4);
            this.radHex.Name = "radHex";
            this.radHex.Size = new System.Drawing.Size(51, 19);
            this.radHex.TabIndex = 0;
            this.radHex.TabStop = true;
            this.radHex.Text = "Hex";
            this.radHex.UseVisualStyleBackColor = true;
            // 
            // radTxt
            // 
            this.radTxt.AutoSize = true;
            this.radTxt.Location = new System.Drawing.Point(9, 28);
            this.radTxt.Margin = new System.Windows.Forms.Padding(4);
            this.radTxt.Name = "radTxt";
            this.radTxt.Size = new System.Drawing.Size(54, 19);
            this.radTxt.TabIndex = 0;
            this.radTxt.Text = "Text";
            this.radTxt.UseVisualStyleBackColor = true;
            // 
            // groBoxLineSingals
            // 
            this.groBoxLineSingals.Controls.Add(this.chkCD);
            this.groBoxLineSingals.Controls.Add(this.chkDSR);
            this.groBoxLineSingals.Controls.Add(this.chkCTS);
            this.groBoxLineSingals.Controls.Add(this.chkRTS);
            this.groBoxLineSingals.Controls.Add(this.chkDTR);
            this.groBoxLineSingals.Location = new System.Drawing.Point(16, 458);
            this.groBoxLineSingals.Margin = new System.Windows.Forms.Padding(4);
            this.groBoxLineSingals.Name = "groBoxLineSingals";
            this.groBoxLineSingals.Padding = new System.Windows.Forms.Padding(4);
            this.groBoxLineSingals.Size = new System.Drawing.Size(347, 56);
            this.groBoxLineSingals.TabIndex = 4;
            this.groBoxLineSingals.TabStop = false;
            this.groBoxLineSingals.Text = "Line Singals";
            // 
            // chkCD
            // 
            this.chkCD.AutoSize = true;
            this.chkCD.Enabled = false;
            this.chkCD.Location = new System.Drawing.Point(284, 26);
            this.chkCD.Margin = new System.Windows.Forms.Padding(4);
            this.chkCD.Name = "chkCD";
            this.chkCD.Size = new System.Drawing.Size(55, 19);
            this.chkCD.TabIndex = 0;
            this.chkCD.Text = "CD*";
            this.chkCD.UseVisualStyleBackColor = true;
            // 
            // chkDSR
            // 
            this.chkDSR.AutoSize = true;
            this.chkDSR.Enabled = false;
            this.chkDSR.Location = new System.Drawing.Point(215, 26);
            this.chkDSR.Margin = new System.Windows.Forms.Padding(4);
            this.chkDSR.Name = "chkDSR";
            this.chkDSR.Size = new System.Drawing.Size(63, 19);
            this.chkDSR.TabIndex = 0;
            this.chkDSR.Text = "DSR*";
            this.chkDSR.UseVisualStyleBackColor = true;
            // 
            // chkCTS
            // 
            this.chkCTS.AutoSize = true;
            this.chkCTS.Enabled = false;
            this.chkCTS.Location = new System.Drawing.Point(147, 26);
            this.chkCTS.Margin = new System.Windows.Forms.Padding(4);
            this.chkCTS.Name = "chkCTS";
            this.chkCTS.Size = new System.Drawing.Size(62, 19);
            this.chkCTS.TabIndex = 0;
            this.chkCTS.Text = "CTS*";
            this.chkCTS.UseVisualStyleBackColor = true;
            // 
            // chkRTS
            // 
            this.chkRTS.AutoSize = true;
            this.chkRTS.Location = new System.Drawing.Point(79, 26);
            this.chkRTS.Margin = new System.Windows.Forms.Padding(4);
            this.chkRTS.Name = "chkRTS";
            this.chkRTS.Size = new System.Drawing.Size(55, 19);
            this.chkRTS.TabIndex = 0;
            this.chkRTS.Text = "RTS";
            this.chkRTS.UseVisualStyleBackColor = true;
            this.chkRTS.CheckedChanged += new System.EventHandler(this.chkRTS_CheckedChanged);
            // 
            // chkDTR
            // 
            this.chkDTR.AutoSize = true;
            this.chkDTR.Location = new System.Drawing.Point(8, 26);
            this.chkDTR.Margin = new System.Windows.Forms.Padding(4);
            this.chkDTR.Name = "chkDTR";
            this.chkDTR.Size = new System.Drawing.Size(57, 19);
            this.chkDTR.TabIndex = 0;
            this.chkDTR.Text = "DTR";
            this.chkDTR.UseVisualStyleBackColor = true;
            this.chkDTR.CheckedChanged += new System.EventHandler(this.chkDTR_CheckedChanged);
            // 
            // timComRefresh
            // 
            this.timComRefresh.Enabled = true;
            this.timComRefresh.Interval = 5000;
            this.timComRefresh.Tick += new System.EventHandler(this.timComRefresh_Tick);
            // 
            // listBoxMemory
            // 
            this.listBoxMemory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxMemory.FormattingEnabled = true;
            this.listBoxMemory.HorizontalScrollbar = true;
            this.listBoxMemory.ItemHeight = 15;
            this.listBoxMemory.Location = new System.Drawing.Point(724, 15);
            this.listBoxMemory.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMemory.Name = "listBoxMemory";
            this.listBoxMemory.Size = new System.Drawing.Size(185, 424);
            this.listBoxMemory.TabIndex = 5;
            this.listBoxMemory.Click += new System.EventHandler(this.listBoxMemory_Click);
            this.listBoxMemory.DoubleClick += new System.EventHandler(this.listBoxMemory_DoubleClick);
            // 
            // rchTxtBoxData
            // 
            this.rchTxtBoxData.BackColor = System.Drawing.SystemColors.Window;
            this.rchTxtBoxData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rchTxtBoxData.Location = new System.Drawing.Point(16, 15);
            this.rchTxtBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.rchTxtBoxData.Name = "rchTxtBoxData";
            this.rchTxtBoxData.ReadOnly = true;
            this.rchTxtBoxData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rchTxtBoxData.Size = new System.Drawing.Size(699, 312);
            this.rchTxtBoxData.TabIndex = 6;
            this.rchTxtBoxData.Text = "";
            this.rchTxtBoxData.TextChanged += new System.EventHandler(this.rchTxtBoxData_TextChanged);
            // 
            // chkClearOnOpen
            // 
            this.chkClearOnOpen.AutoSize = true;
            this.chkClearOnOpen.Location = new System.Drawing.Point(371, 466);
            this.chkClearOnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.chkClearOnOpen.Name = "chkClearOnOpen";
            this.chkClearOnOpen.Size = new System.Drawing.Size(108, 19);
            this.chkClearOnOpen.TabIndex = 7;
            this.chkClearOnOpen.Text = "Clear on open";
            this.chkClearOnOpen.UseVisualStyleBackColor = true;
            // 
            // chkClearWithDTR
            // 
            this.chkClearWithDTR.AutoSize = true;
            this.chkClearWithDTR.Location = new System.Drawing.Point(371, 494);
            this.chkClearWithDTR.Margin = new System.Windows.Forms.Padding(4);
            this.chkClearWithDTR.Name = "chkClearWithDTR";
            this.chkClearWithDTR.Size = new System.Drawing.Size(127, 19);
            this.chkClearWithDTR.TabIndex = 7;
            this.chkClearWithDTR.Text = "Clear with DTR*";
            this.chkClearWithDTR.UseVisualStyleBackColor = true;
            // 
            // btnPortOnOff
            // 
            this.btnPortOnOff.Location = new System.Drawing.Point(597, 469);
            this.btnPortOnOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnPortOnOff.Name = "btnPortOnOff";
            this.btnPortOnOff.Size = new System.Drawing.Size(119, 45);
            this.btnPortOnOff.TabIndex = 2;
            this.btnPortOnOff.Text = "Open Port";
            this.btnPortOnOff.UseVisualStyleBackColor = true;
            this.btnPortOnOff.Click += new System.EventHandler(this.btnPortOnOff_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.Enabled = false;
            this.btnMemory.Location = new System.Drawing.Point(508, 332);
            this.btnMemory.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(100, 29);
            this.btnMemory.TabIndex = 3;
            this.btnMemory.Text = "Memory";
            this.btnMemory.UseVisualStyleBackColor = true;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(724, 414);
            this.txtEdit.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(132, 25);
            this.txtEdit.TabIndex = 8;
            this.txtEdit.Visible = false;
            this.txtEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdit_KeyPress);
            this.txtEdit.Leave += new System.EventHandler(this.txtEdit_Leave);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(724, 484);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(182, 29);
            this.btn_Export.TabIndex = 2;
            this.btn_Export.Text = "Memory Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(724, 447);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(182, 29);
            this.btn_Import.TabIndex = 2;
            this.btn_Import.Text = "Memory Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // SerialPortCommunicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 520);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.chkClearWithDTR);
            this.Controls.Add(this.chkClearOnOpen);
            this.Controls.Add(this.rchTxtBoxData);
            this.Controls.Add(this.listBoxMemory);
            this.Controls.Add(this.groBoxDataMode);
            this.Controls.Add(this.groBoxLineSingals);
            this.Controls.Add(this.groBoxComPortSet);
            this.Controls.Add(this.btnMemory);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnPortOnOff);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCommand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SerialPortCommunicate";
            this.Text = "SerialPortCommunicate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerialPortCommunicate_FormClosed);
            this.Load += new System.EventHandler(this.SerialPortCommunicate_Load);
            this.groBoxComPortSet.ResumeLayout(false);
            this.groBoxComPortSet.PerformLayout();
            this.groBoxDataMode.ResumeLayout(false);
            this.groBoxDataMode.PerformLayout();
            this.groBoxLineSingals.ResumeLayout(false);
            this.groBoxLineSingals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groBoxComPortSet;
        private System.Windows.Forms.ComboBox comBoxStopBits;
        private System.Windows.Forms.Label labStopBits;
        private System.Windows.Forms.ComboBox comBoxDataBits;
        private System.Windows.Forms.Label labDataBits;
        private System.Windows.Forms.ComboBox comBoxParity;
        private System.Windows.Forms.Label labParity;
        private System.Windows.Forms.ComboBox comBoxBR;
        private System.Windows.Forms.Label labBR;
        private System.Windows.Forms.ComboBox comBoxPort;
        private System.Windows.Forms.Label labPort;
        private System.IO.Ports.SerialPort ComPort;
        private System.Windows.Forms.GroupBox groBoxDataMode;
        private System.Windows.Forms.RadioButton radHex;
        private System.Windows.Forms.RadioButton radTxt;
        private System.Windows.Forms.GroupBox groBoxLineSingals;
        private System.Windows.Forms.CheckBox chkCD;
        private System.Windows.Forms.CheckBox chkDSR;
        private System.Windows.Forms.CheckBox chkCTS;
        private System.Windows.Forms.CheckBox chkRTS;
        private System.Windows.Forms.CheckBox chkDTR;
        private System.Windows.Forms.Timer timComRefresh;
        private System.Windows.Forms.ListBox listBoxMemory;
        private System.Windows.Forms.RichTextBox rchTxtBoxData;
        private System.Windows.Forms.CheckBox chkClearOnOpen;
        private System.Windows.Forms.CheckBox chkClearWithDTR;
        private System.Windows.Forms.Button btnPortOnOff;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Import;
    }
}

