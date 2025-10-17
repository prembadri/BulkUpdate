using DAL;
using ExcelDataReader;
using System.ComponentModel;
using System.Data;

namespace BulkImport
{
    public partial class main : Form
    {

        DataTable logTable = new DataTable();
        DataTable dt = new DataTable();
        int toralProcessing = 0; int totalFailed = 0;
        bool stopProcessing = false;

        private DBHelper _dbHelper;

        public main()
        {
            _dbHelper = new DBHelper("YourConnectionStringHere");

            InitializeComponent();
            txtFileName.Enabled = false;

            btnStart.Enabled = false;
            btnStop.Enabled = false;

            DisableMappingandUpdateGroup();


            logTable.Columns.Add("Logs");
            dgvLogs.DataSource = logTable;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DisableMappingandUpdateGroup()
        {
            cbRTUNumber.Enabled = false;
            cbTankId.Enabled = false;
            cbLocationId.Enabled = false;
            cbLocationName.Enabled = false;
            cbRegion.Enabled = false;
            cbTankName.Enabled = false;
            cbUserTankId.Enabled = false;
            cbProductId.Enabled = false;

            ckLocationName.Enabled = false;
            ckProductId.Enabled = false;
            ckRegion.Enabled = false;
            ckTankName.Enabled = false;
            ckUserTankId.Enabled = false;
        }
        private void EnableMappingandUpdateGroup()
        {
            cbRTUNumber.Enabled = true;
            cbTankId.Enabled = true;
            cbLocationId.Enabled = true;
            cbLocationName.Enabled = true;
            cbRegion.Enabled = true;
            cbTankName.Enabled = true;
            cbUserTankId.Enabled = true;
            cbProductId.Enabled = true;

            ckLocationName.Enabled = true;
            ckProductId.Enabled = true;
            ckRegion.Enabled = true;
            ckTankName.Enabled = true;
            ckUserTankId.Enabled = true;
        }

        private void UpdateLogs(string message)
        {
            logTable.Rows.Add(message);
            dgvLogs.Refresh();
        }

        private void LoadExcel(string filePath)
        {
            UpdateLogs($"Strated Reading File : {Path.GetFileName(filePath)}");

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            var conf = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                {
                    UseHeaderRow = true
                }
            };

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var dataset = reader.AsDataSet(conf);
                    dt = dataset.Tables[0];
                    dgvExcel.DataSource = dt;

                    LoadMappingGroup();
                    EnableMappingandUpdateGroup();

                    lblNoofRecordsCount.Text = dt.Rows.Count.ToString();

                    UpdateLogs($"Total Columns in File: {dt.Columns.Count}");
                    UpdateLogs($"Total Rows in File: {dt.Rows.Count}");
                }
            }
            UpdateLogs("Completed Reading File");

            btnStart.Enabled = true;
            btnStop.Enabled = true;
        }

        private void LoadMappingGroup()
        {
            cbRTUNumber.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                        select dc.ColumnName).ToArray());

            cbTankId.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                     select dc.ColumnName).ToArray());

            cbLocationId.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                         select dc.ColumnName).ToArray());

            cbLocationName.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                           select dc.ColumnName).ToArray());

            cbProductId.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                        select dc.ColumnName).ToArray());

            cbUserTankId.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                         select dc.ColumnName).ToArray());

            cbRegion.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                     select dc.ColumnName).ToArray());

            cbTankName.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                       select dc.ColumnName).ToArray());
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;

                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    txtFileName.Text = fileName;

                    LoadExcel(fileName);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string message = "List of Fields to Update";
            string title = "Conform to Start the process";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                StartProcessing();
            }
        }

        private bool ValidateMapping()
        {
            bool isValid = false;

            UpdateLogs("Validating Mapping Started...");

            if (cbUserId.SelectedIndex < 0)
            {
                // write logic once user id logic is added
            }


            if (!ckTankName.Checked && !ckTankName.Checked && !ckUserTankId.Checked && !ckRegion.Checked && !ckLocationName.Checked)
            {
                isValid = false;
                MessageBox.Show("Please select at least one field in the Mapping Group", "Validation Failed");
                UpdateLogs("Please select at least one field in the Mapping Group");

                return isValid;
            }

            if (ckProductId.Checked)
            {
                if (cbProductId.SelectedIndex > 0 && (cbTankId.SelectedIndex > 0 || cbRTUNumber.SelectedIndex > 0))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    MessageBox.Show("Please select Product ID field and (Tank ID or RTU Number) field in the Mapping Group", "Validation Failed");
                    UpdateLogs("Validation Failed - Please select Product ID field and (Tank ID or RTU Number) field in the Mapping Group");
                }
            }
            else if (ckTankName.Checked)
            {
                if (cbTankName.SelectedIndex > 0 && (cbTankId.SelectedIndex > 0 || cbRTUNumber.SelectedIndex > 0))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    MessageBox.Show("Please select Tank Name field and (Tank ID or RTU Number) field in the Mapping Group", "Validation Failed");
                    UpdateLogs("Validation Failed - Please select Tank Name field and (Tank ID or RTU Number) field in the Mapping Group");
                }
            }
            else if (ckUserTankId.Checked)
            {
                if (cbUserTankId.SelectedIndex > 0 && (cbTankId.SelectedIndex > 0 || cbRTUNumber.SelectedIndex > 0))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    MessageBox.Show("Please select User Tank ID field and (Tank ID or RTU Number) field in the Mapping Group", "Validation Failed");
                    UpdateLogs("Validation Failed - Please select User Tank ID field and (Tank ID or RTU Number) field in the Mapping Group");
                }
            }
            else if (ckLocationName.Checked)
            {
                if (cbLocationName.SelectedIndex > 0 && cbLocationId.SelectedIndex > 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    MessageBox.Show("Please select Location Name field or Location ID field in the Mapping Group", "Validation Failed");
                    UpdateLogs("Validation Failed - Please select Location Name field or Location ID field in the Mapping Group");
                }
            }
            else if (ckRegion.Checked)
            {
                if (cbRegion.SelectedIndex > 0 && (cbTankId.SelectedIndex > 0 || cbRTUNumber.SelectedIndex > 0))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    MessageBox.Show("Please select Region field or (Tank ID and RTU Number) field in the Mapping Group", "Validation Failed");
                    UpdateLogs("Validation Failed - Please select Region field or (Tank ID and RTU Number) field in the Mapping Group");
                }
            }
            return isValid;
        }

        private void StartProcessing()
        {
            UpdateLogs("Started Processing Data.");

            if (ValidateMapping())
            {
                if (chkTablePreBackup.Checked)
                {
                    PreBackup();
                }

                foreach (DataRow dc in dt.Rows)
                {
                    toralProcessing++;
                    lblNoofRecordsProcessedCount.Text = toralProcessing.ToString();

                    if (!stopProcessing)
                    {
                        StartUpdating();
                    }

                    if (toralProcessing % 10 == 0)
                    {
                        UpdateLogs($"Completed processing {toralProcessing}");
                    }
                }

                if (chkTablePostBackup.Checked)
                {
                    PostBackup();
                }
            }

            UpdateLogs("Completed Processing Data.");
        }

        private void PreBackup()
        {
            UpdateLogs("Started Pre Backup of the Table...");
            
            foreach (var item in _dbHelper.GetTableData("Tank"))
            {

            }
            
            foreach (var item in _dbHelper.GetTableData("Location"))
            {
            
            }

            foreach (var item in _dbHelper.GetTableData("TankConfig"))
            {
            
            }
            
            UpdateLogs("Completed Pre Backup of the Table...");
        }

        private void PostBackup()
        {
            UpdateLogs("Started Post Backup of the Table...");

            foreach (var item in _dbHelper.GetTableData("Tank"))
            {

            }

            foreach (var item in _dbHelper.GetTableData("Location"))
            {

            }

            foreach (var item in _dbHelper.GetTableData("TankConfig"))
            {

            }

            UpdateLogs("Completed Post Backup of the Table...");
        }

        private void StartUpdating()
        {
            UpdateLogs("Started Updating Records...");

            UpdateLogs("Completed Updating Records...");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopProcessing = true;
        }
    }
}
