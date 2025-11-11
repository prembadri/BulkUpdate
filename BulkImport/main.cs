using DataAccess;
using ExcelDataReader;
using System.Data;
using System.Windows.Forms;

namespace BulkImport
{
    public partial class main : Form
    {
        DataTable logTable = new DataTable();
        DataTable dt = new DataTable();
        int toalProcessing = 0; int totalFailed = 0;
        bool stopProcessing = false;

        private DBHelper _dbHelper;

        public main()
        {
            _dbHelper = new DBHelper("");

            InitializeComponent();
            txtFileName.Enabled = false;

            btnStart.Enabled = false;
            btnStop.Enabled = false;

            EnableDisableMappingandUpdateGroup(false);

            logTable.Columns.Add("Logs");
            dgvLogs.DataSource = logTable;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadOrganizations();
            LoadUpdateTables();
        }

        public void LoadUpdateTables()
        {
            var items = new List<string>()
            {
                "Tank",
                "Location",
                "Product"
            };

            cbUpdatedTable.DataSource = items;
            cbUpdatedTable.SelectedIndex = 0;
        }

        #region Events
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopProcessing = true;
        }

        private void cbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orgId = cbOrganization.SelectedIndex;
            cbUserId.Enabled = false;
            LoadUsers(orgId);
        }
        #endregion


        private void UpdateLogs(string message)
        {
            logTable.Rows.Add(message);
            dgvLogs.Refresh();
        }

        private void EnableDisableMappingandUpdateGroup(bool flag)
        {
            // ComboBoxes
            cbRTUNumber.Enabled = flag;
            cbTankId.Enabled = flag;
            cbLocationId.Enabled = flag;
            cbRegion.Enabled = flag;
            cbTankName.Enabled = flag;
            cbLocationName.Enabled = flag;
            cbUserTankId.Enabled = flag;
            cbProductId.Enabled = flag;
            cbUserTankNo.Enabled = flag;
            cbUserProductNo.Enabled = flag;
            cbCallDay.Enabled = flag;
            cbCallPerDay.Enabled = flag;
            cbInterval.Enabled = flag;
            cbStartTime.Enabled = flag;

            // Checkboxes
            ckLocationName.Enabled = flag;
            ckRegion.Enabled = flag;
            ckTankName.Enabled = flag;
            ckProductId.Enabled = flag;
            ckUserTankId.Enabled = flag;
            ckUserProductNumber.Enabled = flag;
            ckUserTankNumber.Enabled = flag;
            ckStartTime.Enabled = flag;
            ckInterval.Enabled = flag;
            ckCallDay.Enabled = flag;
            ckCallsPerDay.Enabled = flag;
        }

        private void LoadMappingGroup()
        {
            var list = (from dc in dt.Columns.Cast<DataColumn>()
                        select dc.ColumnName).ToArray();

            cbRTUNumber.Items.AddRange(list);
            cbTankId.Items.AddRange(list);
            cbLocationId.Items.AddRange(list);
            cbTankName.Items.AddRange(list);
            cbLocationName.Items.AddRange(list);
            cbRegion.Items.AddRange(list);
            cbProductId.Items.AddRange(list);
            cbUserTankId.Items.AddRange(list);
            cbUserProductNo.Items.AddRange(list);
            cbUserTankNo.Items.AddRange(list);
            cbStartTime.Items.AddRange(list);
            cbInterval.Items.AddRange(list);
            cbCallDay.Items.AddRange(list);
            cbCallPerDay.Items.AddRange(list);
        }

        private void LoadOrganizations()
        {
            var organizations = _dbHelper.GetListOfOrganization();
            cbOrganization.DataSource = organizations;
            cbOrganization.DisplayMember = "OrganizationName";
            cbOrganization.ValueMember = "OrganizationId";
            cbOrganization.SelectedIndex = -1; // No selection by default
        }

        private void LoadUsers(int orgID)
        {
            var users = _dbHelper.GetListOfUsers(orgID);
            cbUserId.DataSource = users;
            cbUserId.DisplayMember = "UserName";
            cbUserId.ValueMember = "UserId";
            cbUserId.SelectedIndex = -1; // No selection by default
            if (users.Count() > 0)
            {
                cbUserId.Enabled = true;
            }
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
                    EnableDisableMappingandUpdateGroup(true);

                    lblNoofRecordsCount.Text = dt.Rows.Count.ToString();

                    UpdateLogs($"Total Columns in File: {dt.Columns.Count}");
                    UpdateLogs($"Total Rows in File: {dt.Rows.Count}");
                }
            }
            UpdateLogs("Completed Reading File");

            btnStart.Enabled = true;
            btnStop.Enabled = true;
        }

        private void ShowValidationMessage(string message)
        {
            MessageBox.Show(message, "Validation Failed");
        }

        private bool ValidateMapping()
        {
            bool isValid = false;

            UpdateLogs("Validating Mapping Started...");

            // Organization Validation
            if (cbUserId.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select User.");
                UpdateLogs("Please select User.");
            }

            // At least one field should be selected
            if (!ckTankName.Checked && !ckRegion.Checked && !ckLocationName.Checked &&
                !ckUserTankId.Checked && !ckProductId.Checked &&
                !ckUserProductNumber.Checked && !ckUserTankNumber.Checked &&
                !ckStartTime.Checked && !ckInterval.Checked && !ckCallDay.Checked && !ckCallsPerDay.Checked)
            {
                isValid = false;
                ShowValidationMessage("Please select at least one field in the Mapping Group");
                UpdateLogs("Please select at least one field in the Mapping Group");

                return isValid;
            }

            // Primary Key Validation
            if (ckTankName.Checked || ckRegion.Checked ||
               ckUserProductNumber.Checked || ckUserTankNumber.Checked ||
               ckStartTime.Checked || ckInterval.Checked || ckCallDay.Checked || ckCallsPerDay.Checked)
            {
                if (cbTankId.SelectedIndex >= 0 || cbRTUNumber.SelectedIndex >= 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    ShowValidationMessage("Please select (Tank ID or RTU Number) field in the Mapping Group");
                    UpdateLogs("Validation Failed - Please select (Tank ID or RTU Number) field in the Mapping Group");
                }
            }

            if (ckLocationName.Checked)
            {
                if (cbLocationId.SelectedIndex >= 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    ShowValidationMessage("Please select Location ID field in the Mapping Group");
                    UpdateLogs("Validation Failed - Please select Location ID field in the Mapping Group");
                }
            }


            // Field Specific Validation
            if (ckUserProductNumber.Checked && cbUserProductNo.SelectedIndex == -1)
            {

                isValid = false;
                ShowValidationMessage("Please select User Product Number field and (Tank ID or RTU Number) field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select User Product Number field and (Tank ID or RTU Number) field in the Mapping Group");
            }
            else
            {
                isValid = true;
            }

            if (ckUserTankNumber.Checked && cbUserTankNo.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select User Tank Number field and (Tank ID or RTU Number) field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select User Tank Number field and (Tank ID or RTU Number) field in the Mapping Group");
            }
            else
            {
                isValid = true;
            }

            if (ckProductId.Checked && cbProductId.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select Product ID field and (Tank ID or RTU Number) field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select Product ID field and (Tank ID or RTU Number) field in the Mapping Group");
            }
            else
            {
                isValid = true;
            }

            if (ckUserTankId.Checked && cbUserTankId.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select User Tank ID field and (Tank ID or RTU Number) field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select User Tank ID field and (Tank ID or RTU Number) field in the Mapping Group");
            }
            else
            {
                isValid = true;
            }

            if (ckTankName.Checked && cbTankName.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select Tank Name field and (Tank ID or RTU Number) field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select Tank Name field and (Tank ID or RTU Number) field in the Mapping Group");
            }
            else
            {
                isValid = true;
            }

            if (ckLocationName.Checked && cbLocationName.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select Location Name field or Location ID field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select Location Name field or Location ID field in the Mapping Group");
            }
            else
            {
                isValid = true;
            }

            if (ckRegion.Checked && cbRegion.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select Region field or (Tank ID and RTU Number) field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select Region field or (Tank ID and RTU Number) field in the Mapping Group");

            }
            else
            {
                isValid = true;
            }

            if (ckCallDay.Checked && cbCallDay.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select Call Day field and (Tank ID or RTU Number) field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select Call Day field and (Tank ID or RTU Number) field in the Mapping Group");
            }
            else
            {
                isValid = true;
            }

            if (ckCallsPerDay.Checked && cbCallPerDay.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select Calls Per Day field and (Tank ID or RTU Number) field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select Calls Per Day field and (Tank ID or RTU Number) field in the Mapping Group");
            }
            else
            {
                isValid = true;
            }

            if (ckInterval.Checked && cbInterval.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select Interval field and (Tank ID or RTU Number) field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select Interval field and (Tank ID or RTU Number) field in the Mapping Group");
            }
            else
            {
                isValid = true;
            }

            if (ckStartTime.Checked && cbStartTime.SelectedIndex == -1)
            {
                isValid = false;
                ShowValidationMessage("Please select Start Time field and (Tank ID or RTU Number) field in the Mapping Group");
                UpdateLogs("Validation Failed - Please select Start Time field and (Tank ID or RTU Number) field in the Mapping Group");
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

        private void StartProcessing()
        {
            UpdateLogs("Started Processing Data.");
            btnStart.Enabled = false;

            if (ValidateMapping())
            {
                if (chkTablePreBackup.Checked)
                {
                    TakeBackup(dt.Rows);
                }

                StartUpdating(dt.Rows);

                if (chkTablePostBackup.Checked)
                {
                    TakeBackup(dt.Rows, true);
                }
            }

            UpdateLogs("Completed Processing Data.");
            btnStart.Enabled = true;
        }

        private void CreateBackupFile(string tableName, int selectedIndex, DataRowCollection dataRow, bool isPostBackup = false)
        {
            List<string> ids = new List<string>();
            string filePath = string.Empty;
            if (isPostBackup)
            {
                filePath = $@"{tableName}_PostBackup_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.csv";
            }
            else
            {
                filePath = $@"{tableName}_PreBackup_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.csv";
            }
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {

                var columns = _dbHelper.GetColumnsAsync(tableName);
                writer.WriteLine(string.Join(",", columns));

                foreach (var item in dataRow)
                {
                    ids.Add(((System.Data.DataRow)item).ItemArray[selectedIndex].ToString());

                    if (ids.Count() > 5)
                    {
                        foreach (var tanks in _dbHelper.GetAllRecordsAsync(tableName, ids))
                        {
                            writer.WriteLine(string.Join(",", tanks.Values));
                        }

                        ids.Clear();
                    }
                }

                if (ids.Count() > 0)
                {
                    foreach (var tanks in _dbHelper.GetAllRecordsAsync(tableName, ids))
                    {
                        writer.Write(string.Join(",", tanks.Values));
                    }
                }
            }
        }

        private void TakeBackup(DataRowCollection dataRow, bool isPostBackup = false)
        {
            UpdateLogs("Started Pre Backup of the Table...");

            if (ckTankName.Checked || ckRegion.Checked ||
                ckUserProductNumber.Checked || ckUserTankNumber.Checked ||
                ckStartTime.Checked || ckCallDay.Checked || ckCallsPerDay.Checked || ckInterval.Checked
                 )
            {
                CreateBackupFile("Tank", cbTankId.SelectedIndex, dataRow, isPostBackup);
                CreateBackupFile("TankConfig", cbTankId.SelectedIndex, dataRow, isPostBackup);
            }

            if (ckLocationName.Checked)
            {
                CreateBackupFile("Location", cbLocationId.SelectedIndex, dataRow, isPostBackup);
            }

            if (ckUserTankId.Checked || ckProductId.Checked)
            {
                CreateBackupFile("DFTank", cbTankId.SelectedIndex, dataRow, isPostBackup);
            }

            UpdateLogs("Completed Pre Backup of the Table...");
        }

        private void StartUpdating(DataRowCollection dataRow)
        {
            UpdateLogs("Started Updating Records...");

            toalProcessing = 0; totalFailed = 0; stopProcessing = false;

            foreach (var item in dataRow)
            {
                if (stopProcessing)
                {
                    UpdateLogs("Processing Stopped by User...");
                    break;
                }
                var row = (System.Data.DataRow)item;
                bool isUpdated = false;

                if (row != null)
                {
                    var columnsToUpdate = new List<Dictionary<string, object>>();

                    if (ckTankName.Checked || ckRegion.Checked ||
                        ckUserProductNumber.Checked || ckUserTankNumber.Checked ||
                        ckStartTime.Checked || ckCallDay.Checked || ckCallsPerDay.Checked || ckInterval.Checked)
                    {
                        if (ckTankName.Checked)
                        {
                            columnsToUpdate.Add(new Dictionary<string, object>
                            {
                                { "ColumnName", "TankName" },
                                { "ColumnValue", row[cbTankName.SelectedItem.ToString()] }
                            });
                        }

                        if (ckRegion.Checked)
                        {
                            columnsToUpdate.Add(new Dictionary<string, object>
                            {
                                { "ColumnName", "Region" },
                                { "ColumnValue", row[cbRegion.SelectedItem.ToString()] }
                            });
                        }

                        if (ckUserTankNumber.Checked)
                        {
                            columnsToUpdate.Add(new Dictionary<string, object>
                            {
                                { "ColumnName", "UserTankNumber" },
                                { "ColumnValue", row[cbUserTankNo.SelectedItem.ToString()] }
                            });
                        }

                        if (ckUserProductNumber.Checked)
                        {
                            columnsToUpdate.Add(new Dictionary<string, object>
                            {
                                { "ColumnName", "UserProductNumber" },
                                { "ColumnValue", row[cbUserProductNo.SelectedItem.ToString()] }
                            });
                        }

                        if (ckStartTime.Checked)
                        {
                            columnsToUpdate.Add(new Dictionary<string, object>
                            {
                                { "ColumnName", "StartTime" },
                                { "ColumnValue", row[cbStartTime.SelectedItem.ToString()] }
                            });
                        }

                        if (ckInterval.Checked)
                        {
                            columnsToUpdate.Add(new Dictionary<string, object>
                            {
                                { "ColumnName", "Interval" },
                                { "ColumnValue", row[cbInterval.SelectedItem.ToString()] }
                            });
                        }

                        if (ckCallDay.Checked)
                        {
                            columnsToUpdate.Add(new Dictionary<string, object>
                            {
                                { "ColumnName", "CallDay" },
                                { "ColumnValue", row[cbCallDay.SelectedItem.ToString()] }
                            });
                        }

                        if (ckCallsPerDay.Checked)
                        {
                            columnsToUpdate.Add(new Dictionary<string, object>
                            {
                                { "ColumnName", "CallsPerDay" },
                                { "ColumnValue", row[cbCallPerDay.SelectedItem.ToString()] }
                            });
                        }

                        _dbHelper.UpdateValues("TankConfig", columnsToUpdate
                        , cbTankId.SelectedIndex >= 0 ? row[cbTankId.SelectedItem.ToString()].ToString() : row[cbRTUNumber.SelectedItem.ToString()].ToString(),
                        cbUserId.SelectedIndex);
                    }
                    if (ckLocationName.Checked)
                    {

                    }
                    _dbHelper.UpdateValues("", "", "", "", cbUserId.SelectedIndex);
                }

                toalProcessing++;
                if (isUpdated)
                {
                    UpdateLogs($"Record {toalProcessing} Updated Successfully.");
                }
                else
                {
                    totalFailed++;
                    UpdateLogs($"Record {toalProcessing} Failed to Update.");
                }
            }
            UpdateLogs("Completed Updating Records...");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sourceFilePath = @"Templates\\";

            if (cbUpdatedTable.SelectedIndex > -1)
            {
                switch (cbUpdatedTable.SelectedIndex)
                {
                    case 0: // Tank
                        sourceFilePath += "TankConfig_Template.xlsx";
                        break;
                    case 1: // Location
                        sourceFilePath += "Location_Template.xlsx";
                        break;
                    case 2:
                        sourceFilePath += "Product_Template.xlsx";
                        break;
                    default:
                        break;
                }

                // Configure the SaveFileDialog
                downloadFileDialog.FileName = "template.xlsx";
                downloadFileDialog.Filter = "Excel files (*.xlsx)|*.csv";
                downloadFileDialog.Title = "Save File";


                if (downloadFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Copy the file from the source to the selected destination
                        File.Copy(sourceFilePath, downloadFileDialog.FileName, true);
                        MessageBox.Show("File downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("Source file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Permission denied to save the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a table to download the template.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //public DateTime ChangeTime(this DateTime dateTime, int hours, int minutes, int seconds, int milliseconds)
        //{
        //    return new DateTime(
        //        dateTime.Year,
        //        dateTime.Month,
        //        dateTime.Day,
        //        hours,
        //        minutes,
        //        seconds,
        //        milliseconds,
        //        dateTime.Kind);
        //}
    }
}
