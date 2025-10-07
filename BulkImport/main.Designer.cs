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
            lblConnectionDetails = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            cbLocationId = new ComboBox();
            label6 = new Label();
            cbRTUNumber = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cbTankId = new ComboBox();
            progressBar1 = new ProgressBar();
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
            ckProductId = new CheckBox();
            ckUserTankId = new CheckBox();
            ckTankName = new CheckBox();
            ckRegion = new CheckBox();
            ckLocationName = new CheckBox();
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
            btnBrowser.Location = new Point(1557, 18);
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
            txtFileName.Size = new Size(1535, 27);
            txtFileName.TabIndex = 2;
            txtFileName.Text = "No File Selected";
            // 
            // dgvExcel
            // 
            dgvExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcel.Location = new Point(16, 176);
            dgvExcel.Name = "dgvExcel";
            dgvExcel.RowHeadersWidth = 51;
            dgvExcel.Size = new Size(738, 391);
            dgvExcel.TabIndex = 3;
            // 
            // gbEnvironment
            // 
            gbEnvironment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbEnvironment.Controls.Add(lblConnectionDetails);
            gbEnvironment.Controls.Add(label5);
            gbEnvironment.Location = new Point(16, 573);
            gbEnvironment.Name = "gbEnvironment";
            gbEnvironment.Size = new Size(1268, 50);
            gbEnvironment.TabIndex = 4;
            gbEnvironment.TabStop = false;
            gbEnvironment.Text = "Environment";
            // 
            // lblConnectionDetails
            // 
            lblConnectionDetails.AutoSize = true;
            lblConnectionDetails.Location = new Point(153, 23);
            lblConnectionDetails.Name = "lblConnectionDetails";
            lblConnectionDetails.Size = new Size(21, 20);
            lblConnectionDetails.TabIndex = 20;
            lblConnectionDetails.Text = "--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 19;
            label5.Text = "Connection Details :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbLocationId);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbRTUNumber);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbTankId);
            groupBox2.Location = new Point(1290, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 304);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mapping";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cbLocationId
            // 
            cbLocationId.FormattingEnabled = true;
            cbLocationId.Location = new Point(162, 92);
            cbLocationId.Name = "cbLocationId";
            cbLocationId.Size = new Size(193, 28);
            cbLocationId.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 95);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 20;
            label6.Text = "Location Id";
            // 
            // cbRTUNumber
            // 
            cbRTUNumber.FormattingEnabled = true;
            cbRTUNumber.Location = new Point(162, 58);
            cbRTUNumber.Name = "cbRTUNumber";
            cbRTUNumber.Size = new Size(193, 28);
            cbRTUNumber.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 61);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 18;
            label2.Text = "RTU Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 27);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 17;
            label1.Text = "Tank ID";
            // 
            // cbTankId
            // 
            cbTankId.FormattingEnabled = true;
            cbTankId.Location = new Point(162, 24);
            cbTankId.Name = "cbTankId";
            cbTankId.Size = new Size(193, 28);
            cbTankId.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(16, 141);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1268, 29);
            progressBar1.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(18, 57);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.TabIndex = 7;
            lblUser.Text = "User";
            // 
            // cbUserId
            // 
            cbUserId.FormattingEnabled = true;
            cbUserId.Location = new Point(62, 51);
            cbUserId.Name = "cbUserId";
            cbUserId.Size = new Size(223, 28);
            cbUserId.TabIndex = 8;
            // 
            // lblNoofRecords
            // 
            lblNoofRecords.AutoSize = true;
            lblNoofRecords.Location = new Point(431, 57);
            lblNoofRecords.Name = "lblNoofRecords";
            lblNoofRecords.Size = new Size(154, 20);
            lblNoofRecords.TabIndex = 9;
            lblNoofRecords.Text = "No of Records in File :";
            // 
            // lblNoofRecordsCount
            // 
            lblNoofRecordsCount.AutoSize = true;
            lblNoofRecordsCount.Location = new Point(591, 57);
            lblNoofRecordsCount.Name = "lblNoofRecordsCount";
            lblNoofRecordsCount.Size = new Size(17, 20);
            lblNoofRecordsCount.TabIndex = 10;
            lblNoofRecordsCount.Text = "0";
            // 
            // lblNoofRecordsProcessed
            // 
            lblNoofRecordsProcessed.AutoSize = true;
            lblNoofRecordsProcessed.Location = new Point(745, 57);
            lblNoofRecordsProcessed.Name = "lblNoofRecordsProcessed";
            lblNoofRecordsProcessed.Size = new Size(177, 20);
            lblNoofRecordsProcessed.TabIndex = 11;
            lblNoofRecordsProcessed.Text = "No of Records Processed:";
            // 
            // lblNoofRecordsProcessedCount
            // 
            lblNoofRecordsProcessedCount.AutoSize = true;
            lblNoofRecordsProcessedCount.Location = new Point(928, 57);
            lblNoofRecordsProcessedCount.Name = "lblNoofRecordsProcessedCount";
            lblNoofRecordsProcessedCount.Size = new Size(17, 20);
            lblNoofRecordsProcessedCount.TabIndex = 12;
            lblNoofRecordsProcessedCount.Text = "0";
            // 
            // lblNoOfRecordsFailedCount
            // 
            lblNoOfRecordsFailedCount.AutoSize = true;
            lblNoOfRecordsFailedCount.Location = new Point(1198, 57);
            lblNoOfRecordsFailedCount.Name = "lblNoOfRecordsFailedCount";
            lblNoOfRecordsFailedCount.Size = new Size(17, 20);
            lblNoOfRecordsFailedCount.TabIndex = 14;
            lblNoOfRecordsFailedCount.Text = "0";
            // 
            // lblNoOfRecordsFailed
            // 
            lblNoOfRecordsFailed.AutoSize = true;
            lblNoOfRecordsFailed.Location = new Point(1042, 57);
            lblNoOfRecordsFailed.Name = "lblNoOfRecordsFailed";
            lblNoOfRecordsFailed.Size = new Size(150, 20);
            lblNoOfRecordsFailed.TabIndex = 13;
            lblNoOfRecordsFailed.Text = "No of Records Failed:";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.Location = new Point(943, 93);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 29);
            btnStart.TabIndex = 15;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStop.Location = new Point(1117, 93);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(147, 29);
            btnStop.TabIndex = 16;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // dgvLogs
            // 
            dgvLogs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(770, 176);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.Size = new Size(514, 391);
            dgvLogs.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckProductId);
            groupBox1.Controls.Add(ckUserTankId);
            groupBox1.Controls.Add(ckTankName);
            groupBox1.Controls.Add(ckRegion);
            groupBox1.Controls.Add(ckLocationName);
            groupBox1.Location = new Point(1290, 363);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 260);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Group";
            // 
            // ckProductId
            // 
            ckProductId.AutoSize = true;
            ckProductId.Location = new Point(19, 146);
            ckProductId.Name = "ckProductId";
            ckProductId.Size = new Size(99, 24);
            ckProductId.TabIndex = 26;
            ckProductId.Text = "Product Id";
            ckProductId.UseVisualStyleBackColor = true;
            // 
            // ckUserTankId
            // 
            ckUserTankId.AutoSize = true;
            ckUserTankId.Location = new Point(19, 116);
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
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 629);
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
            Controls.Add(progressBar1);
            Controls.Add(groupBox2);
            Controls.Add(gbEnvironment);
            Controls.Add(dgvExcel);
            Controls.Add(txtFileName);
            Controls.Add(btnBrowser);
            Name = "main";
            Text = "Bulk Import";
            Load += main_Load;
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
        private ProgressBar progressBar1;
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
    }
}
