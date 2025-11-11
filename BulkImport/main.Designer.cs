namespace BulkImport
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog = new OpenFileDialog();
            btnBrowser = new Button();
            txtFileName = new TextBox();
            dgvExcel = new DataGridView();
            gbEnvironment = new GroupBox();
            chkTablePostBackup = new CheckBox();
            chkTablePreBackup = new CheckBox();
            lblConnectionDetails = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            cbProductDesc = new ComboBox();
            label18 = new Label();
            label15 = new Label();
            label16 = new Label();
            cbCallPerDay = new ComboBox();
            cbCallDay = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            cbInterval = new ComboBox();
            cbStartTime = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            cbUserProductNo = new ComboBox();
            cbUserTankNo = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbTankName = new ComboBox();
            cbRegion = new ComboBox();
            cbProductId = new ComboBox();
            cbUserTankId = new ComboBox();
            cbLocationName = new ComboBox();
            cbLocationId = new ComboBox();
            label6 = new Label();
            cbRTUNumber = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cbTankId = new ComboBox();
            lblUser = new Label();
            cbUserId = new ComboBox();
            lblNoofRecords = new Label();
            lblNoofRecordsCount = new Label();
            lblNoofRecordsProcessed = new Label();
            lblNoofRecordsProcessedCount = new Label();
            lblNoOfRecordsFailedCount = new Label();
            lblNoOfRecordsFailed = new Label();
            btnStart = new Button();
            btnStop = new Button();
            dgvLogs = new DataGridView();
            groupBox1 = new GroupBox();
            ckCallsPerDay = new CheckBox();
            ckCallDay = new CheckBox();
            ckStartTime = new CheckBox();
            ckInterval = new CheckBox();
            ckUserProductNumber = new CheckBox();
            ckUserTankNumber = new CheckBox();
            ckProductId = new CheckBox();
            ckUserTankId = new CheckBox();
            ckTankName = new CheckBox();
            ckRegion = new CheckBox();
            ckLocationName = new CheckBox();
            cbOrganization = new ComboBox();
            label10 = new Label();
            label17 = new Label();
            cbUpdatedTable = new ComboBox();
            linkLabel2 = new LinkLabel();
            downloadFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvExcel).BeginInit();
            gbEnvironment.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // btnBrowser
            // 
            btnBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowser.Location = new Point(1664, 18);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Size = new Size(94, 29);
            btnBrowser.TabIndex = 1;
            btnBrowser.Text = "Browse";
            btnBrowser.UseVisualStyleBackColor = true;
            btnBrowser.Click += btnBrowser_Click;
            // 
            // txtFileName
            // 
            txtFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFileName.Location = new Point(16, 18);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(1642, 27);
            txtFileName.TabIndex = 2;
            txtFileName.Text = "No File Selected";
            // 
            // dgvExcel
            // 
            dgvExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcel.Location = new Point(16, 128);
            dgvExcel.Name = "dgvExcel";
            dgvExcel.RowHeadersWidth = 51;
            dgvExcel.Size = new Size(738, 439);
            dgvExcel.TabIndex = 3;
            // 
            // gbEnvironment
            // 
            gbEnvironment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbEnvironment.Controls.Add(chkTablePostBackup);
            gbEnvironment.Controls.Add(chkTablePreBackup);
            gbEnvironment.Controls.Add(lblConnectionDetails);
            gbEnvironment.Controls.Add(label5);
            gbEnvironment.Location = new Point(16, 573);
            gbEnvironment.Name = "gbEnvironment";
            gbEnvironment.Size = new Size(1132, 50);
            gbEnvironment.TabIndex = 4;
            gbEnvironment.TabStop = false;
            gbEnvironment.Text = "Environment";
            // 
            // chkTablePostBackup
            // 
            chkTablePostBackup.AutoSize = true;
            chkTablePostBackup.Dock = DockStyle.Right;
            chkTablePostBackup.Location = new Point(838, 23);
            chkTablePostBackup.Name = "chkTablePostBackup";
            chkTablePostBackup.Size = new Size(149, 24);
            chkTablePostBackup.TabIndex = 27;
            chkTablePostBackup.Text = "Table Post Backup";
            chkTablePostBackup.UseVisualStyleBackColor = true;
            // 
            // chkTablePreBackup
            // 
            chkTablePreBackup.AutoSize = true;
            chkTablePreBackup.Dock = DockStyle.Right;
            chkTablePreBackup.Location = new Point(987, 23);
            chkTablePreBackup.Name = "chkTablePreBackup";
            chkTablePreBackup.Size = new Size(142, 24);
            chkTablePreBackup.TabIndex = 28;
            chkTablePreBackup.Text = "Table Per Backup";
            chkTablePreBackup.UseVisualStyleBackColor = true;
            // 
            // lblConnectionDetails
            // 
            lblConnectionDetails.AutoSize = true;
            lblConnectionDetails.Dock = DockStyle.Left;
            lblConnectionDetails.Location = new Point(144, 23);
            lblConnectionDetails.Name = "lblConnectionDetails";
            lblConnectionDetails.Size = new Size(21, 20);
            lblConnectionDetails.TabIndex = 20;
            lblConnectionDetails.Text = "--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Location = new Point(3, 23);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 19;
            label5.Text = "Connection Details :";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(cbProductDesc);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(cbCallPerDay);
            groupBox2.Controls.Add(cbCallDay);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(cbInterval);
            groupBox2.Controls.Add(cbStartTime);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(cbUserProductNo);
            groupBox2.Controls.Add(cbUserTankNo);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cbTankName);
            groupBox2.Controls.Add(cbRegion);
            groupBox2.Controls.Add(cbProductId);
            groupBox2.Controls.Add(cbUserTankId);
            groupBox2.Controls.Add(cbLocationName);
            groupBox2.Controls.Add(cbLocationId);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbRTUNumber);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbTankId);
            groupBox2.Location = new Point(1157, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 359);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mapping";
            // 
            // cbProductDesc
            // 
            cbProductDesc.FormattingEnabled = true;
            cbProductDesc.Location = new Point(137, 292);
            cbProductDesc.Name = "cbProductDesc";
            cbProductDesc.Size = new Size(182, 28);
            cbProductDesc.TabIndex = 45;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(19, 295);
            label18.Name = "label18";
            label18.Size = new Size(96, 20);
            label18.TabIndex = 44;
            label18.Text = "Product Desc";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 258);
            label15.Name = "label15";
            label15.Size = new Size(88, 20);
            label15.TabIndex = 43;
            label15.Text = "Call Per Day";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(328, 159);
            label16.Name = "label16";
            label16.Size = new Size(64, 20);
            label16.TabIndex = 42;
            label16.Text = "Call Day";
            // 
            // cbCallPerDay
            // 
            cbCallPerDay.FormattingEnabled = true;
            cbCallPerDay.Location = new Point(137, 258);
            cbCallPerDay.Name = "cbCallPerDay";
            cbCallPerDay.Size = new Size(182, 28);
            cbCallPerDay.TabIndex = 41;
            // 
            // cbCallDay
            // 
            cbCallDay.FormattingEnabled = true;
            cbCallDay.Location = new Point(409, 159);
            cbCallDay.Name = "cbCallDay";
            cbCallDay.Size = new Size(182, 28);
            cbCallDay.TabIndex = 40;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(327, 125);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 39;
            label13.Text = "Interval";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(327, 91);
            label14.Name = "label14";
            label14.Size = new Size(77, 20);
            label14.TabIndex = 38;
            label14.Text = "Start Time";
            // 
            // cbInterval
            // 
            cbInterval.FormattingEnabled = true;
            cbInterval.Location = new Point(408, 125);
            cbInterval.Name = "cbInterval";
            cbInterval.Size = new Size(182, 28);
            cbInterval.TabIndex = 37;
            // 
            // cbStartTime
            // 
            cbStartTime.FormattingEnabled = true;
            cbStartTime.Location = new Point(408, 91);
            cbStartTime.Name = "cbStartTime";
            cbStartTime.Size = new Size(182, 28);
            cbStartTime.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 226);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 35;
            label11.Text = "User Product No.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 192);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 34;
            label12.Text = "User Tank No.";
            // 
            // cbUserProductNo
            // 
            cbUserProductNo.FormattingEnabled = true;
            cbUserProductNo.Location = new Point(137, 223);
            cbUserProductNo.Name = "cbUserProductNo";
            cbUserProductNo.Size = new Size(182, 28);
            cbUserProductNo.TabIndex = 33;
            // 
            // cbUserTankNo
            // 
            cbUserTankNo.FormattingEnabled = true;
            cbUserTankNo.Location = new Point(137, 189);
            cbUserTankNo.Name = "cbUserTankNo";
            cbUserTankNo.Size = new Size(182, 28);
            cbUserTankNo.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(301, 55);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 31;
            label9.Text = "Product Id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 158);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 30;
            label8.Text = "User Tank Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 124);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 29;
            label7.Text = "Tank Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 193);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 28;
            label4.Text = "Region";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 91);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 27;
            label3.Text = "Location Name";
            // 
            // cbTankName
            // 
            cbTankName.FormattingEnabled = true;
            cbTankName.Location = new Point(137, 121);
            cbTankName.Name = "cbTankName";
            cbTankName.Size = new Size(182, 28);
            cbTankName.TabIndex = 26;
            // 
            // cbRegion
            // 
            cbRegion.FormattingEnabled = true;
            cbRegion.Location = new Point(408, 193);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new Size(182, 28);
            cbRegion.TabIndex = 25;
            // 
            // cbProductId
            // 
            cbProductId.FormattingEnabled = true;
            cbProductId.Location = new Point(409, 52);
            cbProductId.Name = "cbProductId";
            cbProductId.Size = new Size(182, 28);
            cbProductId.TabIndex = 24;
            // 
            // cbUserTankId
            // 
            cbUserTankId.FormattingEnabled = true;
            cbUserTankId.Location = new Point(137, 155);
            cbUserTankId.Name = "cbUserTankId";
            cbUserTankId.Size = new Size(182, 28);
            cbUserTankId.TabIndex = 23;
            // 
            // cbLocationName
            // 
            cbLocationName.FormattingEnabled = true;
            cbLocationName.Location = new Point(137, 88);
            cbLocationName.Name = "cbLocationName";
            cbLocationName.Size = new Size(182, 28);
            cbLocationName.TabIndex = 22;
            // 
            // cbLocationId
            // 
            cbLocationId.FormattingEnabled = true;
            cbLocationId.Location = new Point(102, 52);
            cbLocationId.Name = "cbLocationId";
            cbLocationId.Size = new Size(193, 28);
            cbLocationId.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 55);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 20;
            label6.Text = "Location Id";
            // 
            // cbRTUNumber
            // 
            cbRTUNumber.FormattingEnabled = true;
            cbRTUNumber.Location = new Point(409, 18);
            cbRTUNumber.Name = "cbRTUNumber";
            cbRTUNumber.Size = new Size(181, 28);
            cbRTUNumber.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 21);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 18;
            label2.Text = "RTU Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 17;
            label1.Text = "Tank ID";
            // 
            // cbTankId
            // 
            cbTankId.FormattingEnabled = true;
            cbTankId.Location = new Point(102, 18);
            cbTankId.Name = "cbTankId";
            cbTankId.Size = new Size(193, 28);
            cbTankId.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(19, 97);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.TabIndex = 7;
            lblUser.Text = "User";
            // 
            // cbUserId
            // 
            cbUserId.FormattingEnabled = true;
            cbUserId.Location = new Point(120, 88);
            cbUserId.Name = "cbUserId";
            cbUserId.Size = new Size(223, 28);
            cbUserId.TabIndex = 8;
            // 
            // lblNoofRecords
            // 
            lblNoofRecords.AutoSize = true;
            lblNoofRecords.Location = new Point(361, 57);
            lblNoofRecords.Name = "lblNoofRecords";
            lblNoofRecords.Size = new Size(154, 20);
            lblNoofRecords.TabIndex = 9;
            lblNoofRecords.Text = "No of Records in File :";
            // 
            // lblNoofRecordsCount
            // 
            lblNoofRecordsCount.AutoSize = true;
            lblNoofRecordsCount.Location = new Point(521, 57);
            lblNoofRecordsCount.Name = "lblNoofRecordsCount";
            lblNoofRecordsCount.Size = new Size(17, 20);
            lblNoofRecordsCount.TabIndex = 10;
            lblNoofRecordsCount.Text = "0";
            // 
            // lblNoofRecordsProcessed
            // 
            lblNoofRecordsProcessed.AutoSize = true;
            lblNoofRecordsProcessed.Location = new Point(606, 57);
            lblNoofRecordsProcessed.Name = "lblNoofRecordsProcessed";
            lblNoofRecordsProcessed.Size = new Size(177, 20);
            lblNoofRecordsProcessed.TabIndex = 11;
            lblNoofRecordsProcessed.Text = "No of Records Processed:";
            // 
            // lblNoofRecordsProcessedCount
            // 
            lblNoofRecordsProcessedCount.AutoSize = true;
            lblNoofRecordsProcessedCount.Location = new Point(789, 57);
            lblNoofRecordsProcessedCount.Name = "lblNoofRecordsProcessedCount";
            lblNoofRecordsProcessedCount.Size = new Size(17, 20);
            lblNoofRecordsProcessedCount.TabIndex = 12;
            lblNoofRecordsProcessedCount.Text = "0";
            // 
            // lblNoOfRecordsFailedCount
            // 
            lblNoOfRecordsFailedCount.AutoSize = true;
            lblNoOfRecordsFailedCount.Location = new Point(1075, 57);
            lblNoOfRecordsFailedCount.Name = "lblNoOfRecordsFailedCount";
            lblNoOfRecordsFailedCount.Size = new Size(17, 20);
            lblNoOfRecordsFailedCount.TabIndex = 14;
            lblNoOfRecordsFailedCount.Text = "0";
            // 
            // lblNoOfRecordsFailed
            // 
            lblNoOfRecordsFailed.AutoSize = true;
            lblNoOfRecordsFailed.Location = new Point(919, 57);
            lblNoOfRecordsFailed.Name = "lblNoOfRecordsFailed";
            lblNoOfRecordsFailed.Size = new Size(150, 20);
            lblNoOfRecordsFailed.TabIndex = 13;
            lblNoOfRecordsFailed.Text = "No of Records Failed:";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.Location = new Point(847, 93);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(157, 29);
            btnStart.TabIndex = 15;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.None;
            btnStop.Location = new Point(1010, 93);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(141, 29);
            btnStop.TabIndex = 16;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // dgvLogs
            // 
            dgvLogs.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(760, 128);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.Size = new Size(388, 439);
            dgvLogs.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(ckCallsPerDay);
            groupBox1.Controls.Add(ckCallDay);
            groupBox1.Controls.Add(ckStartTime);
            groupBox1.Controls.Add(ckInterval);
            groupBox1.Controls.Add(ckUserProductNumber);
            groupBox1.Controls.Add(ckUserTankNumber);
            groupBox1.Controls.Add(ckProductId);
            groupBox1.Controls.Add(ckUserTankId);
            groupBox1.Controls.Add(ckTankName);
            groupBox1.Controls.Add(ckRegion);
            groupBox1.Controls.Add(ckLocationName);
            groupBox1.Location = new Point(1157, 422);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 201);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Group";
            // 
            // ckCallsPerDay
            // 
            ckCallsPerDay.AutoSize = true;
            ckCallsPerDay.Location = new Point(209, 176);
            ckCallsPerDay.Name = "ckCallsPerDay";
            ckCallsPerDay.Size = new Size(116, 24);
            ckCallsPerDay.TabIndex = 32;
            ckCallsPerDay.Text = "Calls Per Day";
            ckCallsPerDay.UseVisualStyleBackColor = true;
            // 
            // ckCallDay
            // 
            ckCallDay.AutoSize = true;
            ckCallDay.Location = new Point(209, 146);
            ckCallDay.Name = "ckCallDay";
            ckCallDay.Size = new Size(86, 24);
            ckCallDay.TabIndex = 31;
            ckCallDay.Text = "Call Day";
            ckCallDay.UseVisualStyleBackColor = true;
            // 
            // ckStartTime
            // 
            ckStartTime.AutoSize = true;
            ckStartTime.Location = new Point(209, 86);
            ckStartTime.Name = "ckStartTime";
            ckStartTime.Size = new Size(99, 24);
            ckStartTime.TabIndex = 30;
            ckStartTime.Text = "Start Time";
            ckStartTime.UseVisualStyleBackColor = true;
            // 
            // ckInterval
            // 
            ckInterval.AutoSize = true;
            ckInterval.Location = new Point(209, 117);
            ckInterval.Name = "ckInterval";
            ckInterval.Size = new Size(80, 24);
            ckInterval.TabIndex = 29;
            ckInterval.Text = "Interval";
            ckInterval.UseVisualStyleBackColor = true;
            // 
            // ckUserProductNumber
            // 
            ckUserProductNumber.AutoSize = true;
            ckUserProductNumber.Location = new Point(19, 146);
            ckUserProductNumber.Name = "ckUserProductNumber";
            ckUserProductNumber.Size = new Size(173, 24);
            ckUserProductNumber.TabIndex = 28;
            ckUserProductNumber.Text = "User Product Number";
            ckUserProductNumber.UseVisualStyleBackColor = true;
            // 
            // ckUserTankNumber
            // 
            ckUserTankNumber.AutoSize = true;
            ckUserTankNumber.Location = new Point(19, 117);
            ckUserTankNumber.Name = "ckUserTankNumber";
            ckUserTankNumber.Size = new Size(151, 24);
            ckUserTankNumber.TabIndex = 27;
            ckUserTankNumber.Text = "User Tank Number";
            ckUserTankNumber.UseVisualStyleBackColor = true;
            // 
            // ckProductId
            // 
            ckProductId.AutoSize = true;
            ckProductId.Location = new Point(209, 56);
            ckProductId.Name = "ckProductId";
            ckProductId.Size = new Size(99, 24);
            ckProductId.TabIndex = 26;
            ckProductId.Text = "Product Id";
            ckProductId.UseVisualStyleBackColor = true;
            // 
            // ckUserTankId
            // 
            ckUserTankId.AutoSize = true;
            ckUserTankId.Location = new Point(209, 26);
            ckUserTankId.Name = "ckUserTankId";
            ckUserTankId.Size = new Size(110, 24);
            ckUserTankId.TabIndex = 25;
            ckUserTankId.Text = "User Tank Id";
            ckUserTankId.UseVisualStyleBackColor = true;
            // 
            // ckTankName
            // 
            ckTankName.AutoSize = true;
            ckTankName.Location = new Point(19, 86);
            ckTankName.Name = "ckTankName";
            ckTankName.Size = new Size(104, 24);
            ckTankName.TabIndex = 24;
            ckTankName.Text = "Tank Name";
            ckTankName.UseVisualStyleBackColor = true;
            // 
            // ckRegion
            // 
            ckRegion.AutoSize = true;
            ckRegion.Location = new Point(19, 56);
            ckRegion.Name = "ckRegion";
            ckRegion.Size = new Size(78, 24);
            ckRegion.TabIndex = 23;
            ckRegion.Text = "Region";
            ckRegion.UseVisualStyleBackColor = true;
            // 
            // ckLocationName
            // 
            ckLocationName.AutoSize = true;
            ckLocationName.Location = new Point(19, 26);
            ckLocationName.Name = "ckLocationName";
            ckLocationName.Size = new Size(132, 24);
            ckLocationName.TabIndex = 22;
            ckLocationName.Text = "Location Name";
            ckLocationName.UseVisualStyleBackColor = true;
            // 
            // cbOrganization
            // 
            cbOrganization.FormattingEnabled = true;
            cbOrganization.Location = new Point(120, 54);
            cbOrganization.Name = "cbOrganization";
            cbOrganization.Size = new Size(223, 28);
            cbOrganization.TabIndex = 21;
            cbOrganization.SelectedIndexChanged += cbOrganization_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 57);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 22;
            label10.Text = "Organization";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(361, 93);
            label17.Name = "label17";
            label17.Size = new Size(97, 20);
            label17.TabIndex = 23;
            label17.Text = "Update Table";
            // 
            // cbUpdatedTable
            // 
            cbUpdatedTable.FormattingEnabled = true;
            cbUpdatedTable.Location = new Point(464, 88);
            cbUpdatedTable.Name = "cbUpdatedTable";
            cbUpdatedTable.Size = new Size(223, 28);
            cbUpdatedTable.TabIndex = 24;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(705, 91);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(78, 20);
            linkLabel2.TabIndex = 26;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Download";
            linkLabel2.VisitedLinkColor = Color.Blue;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1770, 629);
            Controls.Add(linkLabel2);
            Controls.Add(cbUpdatedTable);
            Controls.Add(label17);
            Controls.Add(label10);
            Controls.Add(cbOrganization);
            Controls.Add(groupBox1);
            Controls.Add(dgvLogs);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblNoOfRecordsFailedCount);
            Controls.Add(lblNoOfRecordsFailed);
            Controls.Add(lblNoofRecordsProcessedCount);
            Controls.Add(lblNoofRecordsProcessed);
            Controls.Add(lblNoofRecordsCount);
            Controls.Add(lblNoofRecords);
            Controls.Add(cbUserId);
            Controls.Add(lblUser);
            Controls.Add(groupBox2);
            Controls.Add(gbEnvironment);
            Controls.Add(dgvExcel);
            Controls.Add(txtFileName);
            Controls.Add(btnBrowser);
            MaximizeBox = false;
            Name = "main";
            Text = "Bulk Import";
            ((System.ComponentModel.ISupportInitialize)dgvExcel).EndInit();
            gbEnvironment.ResumeLayout(false);
            gbEnvironment.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private Button btnBrowser;
        private TextBox txtFileName;
        private DataGridView dgvExcel;
        private GroupBox gbEnvironment;
        private GroupBox groupBox2;
        private Label lblUser;
        private ComboBox cbUserId;
        private Label lblNoofRecords;
        private Label lblNoofRecordsCount;
        private Label lblNoofRecordsProcessed;
        private Label lblNoofRecordsProcessedCount;
        private ComboBox cbTankId;
        private Label lblNoOfRecordsFailedCount;
        private Label lblNoOfRecordsFailed;
        private Button btnStart;
        private Button btnStop;
        private Label label1;
        private DataGridView dgvLogs;
        private ComboBox cbRTUNumber;
        private Label label2;
        private Label label5;
        private GroupBox groupBox1;
        private Label lblConnectionDetails;
        private ComboBox cbLocationId;
        private Label label6;
        private CheckBox ckProductId;
        private CheckBox ckUserTankId;
        private CheckBox ckTankName;
        private CheckBox ckRegion;
        private CheckBox ckLocationName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private ComboBox cbTankName;
        private ComboBox cbRegion;
        private ComboBox cbProductId;
        private ComboBox cbUserTankId;
        private ComboBox cbLocationName;
        private CheckBox chkTablePostBackup;
        private CheckBox chkTablePreBackup;
        private ComboBox cbOrganization;
        private Label label10;
        private CheckBox ckStartTime;
        private CheckBox ckInterval;
        private CheckBox ckUserProductNumber;
        private CheckBox ckUserTankNumber;
        private CheckBox ckCallsPerDay;
        private CheckBox ckCallDay;
        private Label label11;
        private Label label12;
        private ComboBox cbUserProductNo;
        private ComboBox cbUserTankNo;
        private Label label15;
        private Label label16;
        private ComboBox cbCallPerDay;
        private ComboBox cbCallDay;
        private Label label13;
        private Label label14;
        private ComboBox cbInterval;
        private ComboBox cbStartTime;
        private Label label17;
        private ComboBox cbUpdatedTable;
        private ComboBox cbProductDesc;
        private Label label18;
        private LinkLabel linkLabel2;
        private SaveFileDialog downloadFileDialog;
    }
}
