namespace BulkImport
{
    partial class BulkUpsertTool
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
            txtBrowse = new TextBox();
            btnBrowse = new Button();
            label1 = new Label();
            label2 = new Label();
            cbOrganization = new ComboBox();
            cbUser = new ComboBox();
            cbCatagory = new ComboBox();
            label3 = new Label();
            linkDownload = new LinkLabel();
            panel1 = new Panel();
            lblConnection = new Label();
            label7 = new Label();
            lblRecordsFailed = new Label();
            lblRecordsSuccess = new Label();
            lblRecordsinFiles = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ckbPreBackup = new CheckBox();
            ckbPostBackup = new CheckBox();
            btnStart = new Button();
            btnStop = new Button();
            panel2 = new Panel();
            dgvExcel = new DataGridView();
            panel3 = new Panel();
            dgvLogs = new DataGridView();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExcel).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // txtBrowse
            // 
            txtBrowse.Location = new Point(12, 12);
            txtBrowse.Name = "txtBrowse";
            txtBrowse.Size = new Size(1135, 27);
            txtBrowse.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(1153, 10);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(175, 29);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 48);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 3;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 48);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 4;
            label2.Text = "Organization";
            // 
            // cbOrganization
            // 
            cbOrganization.FormattingEnabled = true;
            cbOrganization.Location = new Point(137, 45);
            cbOrganization.Name = "cbOrganization";
            cbOrganization.Size = new Size(199, 28);
            cbOrganization.TabIndex = 5;
            // 
            // cbUser
            // 
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(406, 45);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(199, 28);
            cbUser.TabIndex = 6;
            // 
            // cbCatagory
            // 
            cbCatagory.FormattingEnabled = true;
            cbCatagory.Location = new Point(693, 45);
            cbCatagory.Name = "cbCatagory";
            cbCatagory.Size = new Size(199, 28);
            cbCatagory.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(618, 48);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Catagory";
            // 
            // linkDownload
            // 
            linkDownload.AutoSize = true;
            linkDownload.Location = new Point(898, 48);
            linkDownload.Name = "linkDownload";
            linkDownload.Size = new Size(78, 20);
            linkDownload.TabIndex = 9;
            linkDownload.TabStop = true;
            linkDownload.Text = "Download";
            linkDownload.LinkClicked += linkDownload_LinkClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblConnection);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblRecordsFailed);
            panel1.Controls.Add(lblRecordsSuccess);
            panel1.Controls.Add(lblRecordsinFiles);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ckbPreBackup);
            panel1.Controls.Add(ckbPostBackup);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(txtBrowse);
            panel1.Controls.Add(linkDownload);
            panel1.Controls.Add(btnBrowse);
            panel1.Controls.Add(cbCatagory);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbOrganization);
            panel1.Controls.Add(cbUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1335, 147);
            panel1.TabIndex = 10;
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.Location = new Point(137, 112);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(39, 20);
            lblConnection.TabIndex = 22;
            lblConnection.Text = "--/--";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 112);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 21;
            label7.Text = "Connection : ";
            // 
            // lblRecordsFailed
            // 
            lblRecordsFailed.AutoSize = true;
            lblRecordsFailed.Location = new Point(824, 80);
            lblRecordsFailed.Name = "lblRecordsFailed";
            lblRecordsFailed.Size = new Size(17, 20);
            lblRecordsFailed.TabIndex = 20;
            lblRecordsFailed.Text = "0";
            // 
            // lblRecordsSuccess
            // 
            lblRecordsSuccess.AutoSize = true;
            lblRecordsSuccess.Location = new Point(511, 80);
            lblRecordsSuccess.Name = "lblRecordsSuccess";
            lblRecordsSuccess.Size = new Size(17, 20);
            lblRecordsSuccess.TabIndex = 19;
            lblRecordsSuccess.Text = "0";
            // 
            // lblRecordsinFiles
            // 
            lblRecordsinFiles.AutoSize = true;
            lblRecordsinFiles.Location = new Point(185, 80);
            lblRecordsinFiles.Name = "lblRecordsinFiles";
            lblRecordsinFiles.Size = new Size(17, 20);
            lblRecordsinFiles.TabIndex = 18;
            lblRecordsinFiles.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 80);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 17;
            label6.Text = "No. Records Success : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(675, 80);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 16;
            label5.Text = "No. Records Failed : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 80);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 15;
            label4.Text = "No. Records In File : ";
            // 
            // ckbPreBackup
            // 
            ckbPreBackup.AutoSize = true;
            ckbPreBackup.Location = new Point(1027, 79);
            ckbPreBackup.Name = "ckbPreBackup";
            ckbPreBackup.Size = new Size(104, 24);
            ckbPreBackup.TabIndex = 14;
            ckbPreBackup.Text = "Pre Backup";
            ckbPreBackup.UseVisualStyleBackColor = true;
            // 
            // ckbPostBackup
            // 
            ckbPostBackup.AutoSize = true;
            ckbPostBackup.Location = new Point(1191, 79);
            ckbPostBackup.Name = "ckbPostBackup";
            ckbPostBackup.Size = new Size(110, 24);
            ckbPostBackup.TabIndex = 13;
            ckbPostBackup.Text = "Post Backup";
            ckbPostBackup.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(986, 45);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(170, 29);
            btnStart.TabIndex = 12;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(1162, 44);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(170, 29);
            btnStop.TabIndex = 11;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvExcel);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 559);
            panel2.TabIndex = 11;
            // 
            // dgvExcel
            // 
            dgvExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcel.Dock = DockStyle.Fill;
            dgvExcel.Location = new Point(0, 0);
            dgvExcel.Name = "dgvExcel";
            dgvExcel.RowHeadersWidth = 51;
            dgvExcel.Size = new Size(845, 559);
            dgvExcel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvLogs);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(851, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(484, 559);
            panel3.TabIndex = 12;
            // 
            // dgvLogs
            // 
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Dock = DockStyle.Fill;
            dgvLogs.Location = new Point(0, 0);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.Size = new Size(484, 559);
            dgvLogs.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // BulkUpsertTool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 706);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "BulkUpsertTool";
            Text = "Bulk Upsert Tool";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExcel).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private TextBox txtBrowse;
        private Button btnBrowse;
        private Label label1;
        private Label label2;
        private ComboBox cbOrganization;
        private ComboBox cbUser;
        private ComboBox cbCatagory;
        private Label label3;
        private LinkLabel linkDownload;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvExcel;
        private Panel panel3;
        private DataGridView dgvLogs;
        private Button btnStart;
        private Button btnStop;
        private Label label4;
        private CheckBox ckbPreBackup;
        private CheckBox ckbPostBackup;
        private Label label6;
        private Label label5;
        private Label lblRecordsFailed;
        private Label lblRecordsSuccess;
        private Label lblRecordsinFiles;
        private Label lblConnection;
        private Label label7;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}