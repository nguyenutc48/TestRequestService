namespace ErrorMachineManagement
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblPLCs = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtListAddr = new System.Windows.Forms.TextBox();
            this.lblMCRespon = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblPLCConnected = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numTimeOutReq = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbCPUPlc = new System.Windows.Forms.ComboBox();
            this.cmbUnitPlc = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPLCIp = new System.Windows.Forms.TextBox();
            this.btnGetServiceInfo = new System.Windows.Forms.Button();
            this.txtThoiGianThucHien = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIpService = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPortService = new System.Windows.Forms.TextBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.tmUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnImportDB = new System.Windows.Forms.Button();
            this.btnBrFileDV = new System.Windows.Forms.Button();
            this.btnBrFileMC = new System.Windows.Forms.Button();
            this.lblFileImportDevice = new System.Windows.Forms.Label();
            this.lblFileNameImport = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnStartGetData = new System.Windows.Forms.Button();
            this.btnStopGetData = new System.Windows.Forms.Button();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.LinkLabel();
            this.chkFake = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOutReq)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Scan Tuần Tự";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Scan Ngẫu Nhiên";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số lượng IP PLC:";
            // 
            // lblPLCs
            // 
            this.lblPLCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPLCs.Location = new System.Drawing.Point(139, 15);
            this.lblPLCs.Name = "lblPLCs";
            this.lblPLCs.Size = new System.Drawing.Size(100, 23);
            this.lblPLCs.TabIndex = 6;
            this.lblPLCs.Text = "0";
            this.lblPLCs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtListAddr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMCRespon);
            this.groupBox1.Controls.Add(this.lblTotalTime);
            this.groupBox1.Controls.Add(this.lblPLCConnected);
            this.groupBox1.Controls.Add(this.lblPLCs);
            this.groupBox1.Location = new System.Drawing.Point(339, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 263);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "(s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thời gian đọc:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Số máy có kết quả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng PLC kết nối:";
            // 
            // txtListAddr
            // 
            this.txtListAddr.Location = new System.Drawing.Point(9, 157);
            this.txtListAddr.Multiline = true;
            this.txtListAddr.Name = "txtListAddr";
            this.txtListAddr.Size = new System.Drawing.Size(237, 89);
            this.txtListAddr.TabIndex = 3;
            this.txtListAddr.Text = "D0,D1";
            // 
            // lblMCRespon
            // 
            this.lblMCRespon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMCRespon.Location = new System.Drawing.Point(139, 114);
            this.lblMCRespon.Name = "lblMCRespon";
            this.lblMCRespon.Size = new System.Drawing.Size(100, 23);
            this.lblMCRespon.TabIndex = 6;
            this.lblMCRespon.Text = "0";
            this.lblMCRespon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalTime.Location = new System.Drawing.Point(139, 82);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(81, 23);
            this.lblTotalTime.TabIndex = 6;
            this.lblTotalTime.Text = "0";
            this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPLCConnected
            // 
            this.lblPLCConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPLCConnected.Location = new System.Drawing.Point(139, 49);
            this.lblPLCConnected.Name = "lblPLCConnected";
            this.lblPLCConnected.Size = new System.Drawing.Size(100, 23);
            this.lblPLCConnected.TabIndex = 6;
            this.lblPLCConnected.Text = "0";
            this.lblPLCConnected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numTimeOutReq);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(339, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 105);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test với nhiều máy";
            // 
            // numTimeOutReq
            // 
            this.numTimeOutReq.Location = new System.Drawing.Point(137, 76);
            this.numTimeOutReq.Name = "numTimeOutReq";
            this.numTimeOutReq.Size = new System.Drawing.Size(82, 20);
            this.numTimeOutReq.TabIndex = 7;
            this.numTimeOutReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTimeOutReq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimeOutReq.ValueChanged += new System.EventHandler(this.numTimeOutReq_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(225, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "(s)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Số lượng IP PLC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Log list";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbCPUPlc);
            this.groupBox3.Controls.Add(this.cmbUnitPlc);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.txtPLCIp);
            this.groupBox3.Controls.Add(this.btnGetServiceInfo);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txtThoiGianThucHien);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(15, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 263);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test với 1 máy";
            // 
            // cmbCPUPlc
            // 
            this.cmbCPUPlc.FormattingEnabled = true;
            this.cmbCPUPlc.Location = new System.Drawing.Point(126, 87);
            this.cmbCPUPlc.Name = "cmbCPUPlc";
            this.cmbCPUPlc.Size = new System.Drawing.Size(177, 21);
            this.cmbCPUPlc.TabIndex = 6;
            // 
            // cmbUnitPlc
            // 
            this.cmbUnitPlc.FormattingEnabled = true;
            this.cmbUnitPlc.Location = new System.Drawing.Point(126, 57);
            this.cmbUnitPlc.Name = "cmbUnitPlc";
            this.cmbUnitPlc.Size = new System.Drawing.Size(177, 21);
            this.cmbUnitPlc.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(126, 117);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(177, 71);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "D0,D1";
            // 
            // txtPLCIp
            // 
            this.txtPLCIp.Location = new System.Drawing.Point(126, 27);
            this.txtPLCIp.Name = "txtPLCIp";
            this.txtPLCIp.Size = new System.Drawing.Size(177, 20);
            this.txtPLCIp.TabIndex = 3;
            this.txtPLCIp.Text = "192.168.3.39";
            // 
            // btnGetServiceInfo
            // 
            this.btnGetServiceInfo.Location = new System.Drawing.Point(9, 231);
            this.btnGetServiceInfo.Name = "btnGetServiceInfo";
            this.btnGetServiceInfo.Size = new System.Drawing.Size(104, 23);
            this.btnGetServiceInfo.TabIndex = 2;
            this.btnGetServiceInfo.Text = "Get Service Info";
            this.btnGetServiceInfo.UseVisualStyleBackColor = true;
            this.btnGetServiceInfo.Click += new System.EventHandler(this.btnGetServiceInfo_Click);
            // 
            // txtThoiGianThucHien
            // 
            this.txtThoiGianThucHien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThoiGianThucHien.Location = new System.Drawing.Point(126, 199);
            this.txtThoiGianThucHien.Name = "txtThoiGianThucHien";
            this.txtThoiGianThucHien.Size = new System.Drawing.Size(100, 23);
            this.txtThoiGianThucHien.TabIndex = 6;
            this.txtThoiGianThucHien.Text = "0";
            this.txtThoiGianThucHien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "DS các biến:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tên CPU của PLC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Loại kết nối PLC:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(231, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "(ms)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Thời gian thực hiện:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "IP của PLC test:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "IP của Service:";
            // 
            // txtIpService
            // 
            this.txtIpService.Location = new System.Drawing.Point(100, 22);
            this.txtIpService.Name = "txtIpService";
            this.txtIpService.Size = new System.Drawing.Size(177, 20);
            this.txtIpService.TabIndex = 3;
            this.txtIpService.Text = "127.0.0.1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Port của Service:";
            // 
            // txtPortService
            // 
            this.txtPortService.Location = new System.Drawing.Point(396, 22);
            this.txtPortService.Name = "txtPortService";
            this.txtPortService.Size = new System.Drawing.Size(160, 20);
            this.txtPortService.TabIndex = 3;
            this.txtPortService.Text = "6789";
            // 
            // txtLogs
            // 
            this.txtLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogs.Location = new System.Drawing.Point(12, 456);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(581, 103);
            this.txtLogs.TabIndex = 3;
            // 
            // tmUpdate
            // 
            this.tmUpdate.Enabled = true;
            this.tmUpdate.Interval = 60000;
            this.tmUpdate.Tick += new System.EventHandler(this.tmUpdate_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.btnImportDB);
            this.groupBox4.Controls.Add(this.btnBrFileDV);
            this.groupBox4.Controls.Add(this.btnBrFileMC);
            this.groupBox4.Controls.Add(this.lblFileImportDevice);
            this.groupBox4.Controls.Add(this.lblFileNameImport);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(15, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 105);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Import file data";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Del Machines";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // btnImportDB
            // 
            this.btnImportDB.Location = new System.Drawing.Point(9, 71);
            this.btnImportDB.Name = "btnImportDB";
            this.btnImportDB.Size = new System.Drawing.Size(121, 23);
            this.btnImportDB.TabIndex = 1;
            this.btnImportDB.Text = "Import To Database";
            this.btnImportDB.UseVisualStyleBackColor = true;
            this.btnImportDB.Click += new System.EventHandler(this.btnImportDB_Click);
            // 
            // btnBrFileDV
            // 
            this.btnBrFileDV.Location = new System.Drawing.Point(274, 38);
            this.btnBrFileDV.Name = "btnBrFileDV";
            this.btnBrFileDV.Size = new System.Drawing.Size(32, 23);
            this.btnBrFileDV.TabIndex = 1;
            this.btnBrFileDV.Text = "...";
            this.btnBrFileDV.UseVisualStyleBackColor = true;
            this.btnBrFileDV.Click += new System.EventHandler(this.btnBrFileDV_Click);
            // 
            // btnBrFileMC
            // 
            this.btnBrFileMC.Location = new System.Drawing.Point(274, 13);
            this.btnBrFileMC.Name = "btnBrFileMC";
            this.btnBrFileMC.Size = new System.Drawing.Size(32, 23);
            this.btnBrFileMC.TabIndex = 1;
            this.btnBrFileMC.Text = "...";
            this.btnBrFileMC.UseVisualStyleBackColor = true;
            this.btnBrFileMC.Click += new System.EventHandler(this.btnBrFileMC_ClickAsync);
            // 
            // lblFileImportDevice
            // 
            this.lblFileImportDevice.Location = new System.Drawing.Point(78, 43);
            this.lblFileImportDevice.Name = "lblFileImportDevice";
            this.lblFileImportDevice.Size = new System.Drawing.Size(190, 13);
            this.lblFileImportDevice.TabIndex = 0;
            this.lblFileImportDevice.Text = "list may.xls";
            // 
            // lblFileNameImport
            // 
            this.lblFileNameImport.Location = new System.Drawing.Point(78, 18);
            this.lblFileNameImport.Name = "lblFileNameImport";
            this.lblFileNameImport.Size = new System.Drawing.Size(190, 13);
            this.lblFileNameImport.TabIndex = 0;
            this.lblFileNameImport.Text = "list may.xls";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "File list lỗi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "File list máy: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtIpService);
            this.groupBox5.Controls.Add(this.txtPortService);
            this.groupBox5.Location = new System.Drawing.Point(15, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(577, 53);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cấu hình kết nối với service";
            // 
            // btnStartGetData
            // 
            this.btnStartGetData.Location = new System.Drawing.Point(11, 588);
            this.btnStartGetData.Name = "btnStartGetData";
            this.btnStartGetData.Size = new System.Drawing.Size(111, 42);
            this.btnStartGetData.TabIndex = 14;
            this.btnStartGetData.Text = "Start Thu Thập Dữ Liệu";
            this.btnStartGetData.UseVisualStyleBackColor = true;
            this.btnStartGetData.Click += new System.EventHandler(this.btnStartGetData_Click);
            // 
            // btnStopGetData
            // 
            this.btnStopGetData.Location = new System.Drawing.Point(145, 588);
            this.btnStopGetData.Name = "btnStopGetData";
            this.btnStopGetData.Size = new System.Drawing.Size(111, 42);
            this.btnStopGetData.TabIndex = 14;
            this.btnStopGetData.Text = "Stop Thu Thập Dữ Liệu";
            this.btnStopGetData.UseVisualStyleBackColor = true;
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Location = new System.Drawing.Point(12, 636);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(110, 17);
            this.chkStartup.TabIndex = 15;
            this.chkStartup.Text = "Auto boot start up";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(562, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(31, 13);
            this.btnClear.TabIndex = 16;
            this.btnClear.TabStop = true;
            this.btnClear.Text = "Clear";
            this.btnClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnClear_LinkClicked);
            // 
            // chkFake
            // 
            this.chkFake.AutoSize = true;
            this.chkFake.Location = new System.Drawing.Point(12, 565);
            this.chkFake.Name = "chkFake";
            this.chkFake.Size = new System.Drawing.Size(74, 17);
            this.chkFake.TabIndex = 17;
            this.chkFake.Text = "Fake data";
            this.chkFake.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(223, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Del List Lỗi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1Async);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 665);
            this.Controls.Add(this.chkFake);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkStartup);
            this.Controls.Add(this.btnStopGetData);
            this.Controls.Add(this.btnStartGetData);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Test Tốc Độ Lấy Dữ Liệu Từ PLC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOutReq)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPLCs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblPLCConnected;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbCPUPlc;
        private System.Windows.Forms.ComboBox cmbUnitPlc;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPLCIp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIpService;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPortService;
        private System.Windows.Forms.Label txtThoiGianThucHien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.TextBox txtListAddr;
        private System.Windows.Forms.Timer tmUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnImportDB;
        private System.Windows.Forms.Button btnBrFileDV;
        private System.Windows.Forms.Button btnBrFileMC;
        private System.Windows.Forms.Label lblFileImportDevice;
        private System.Windows.Forms.Label lblFileNameImport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnStartGetData;
        private System.Windows.Forms.Button btnStopGetData;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblMCRespon;
        private System.Windows.Forms.Button btnGetServiceInfo;
        private System.Windows.Forms.LinkLabel btnClear;
        private System.Windows.Forms.NumericUpDown numTimeOutReq;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkFake;
        private System.Windows.Forms.Button button5;
    }
}