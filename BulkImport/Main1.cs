using DataAccess;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkImport
{
    public partial class BulkUpsertTool : Form
    {
        private DataTable _logDateTable = new DataTable();
        private DataTable _excelDataTable = new DataTable();
        private DBLayer _db;
        private SqlQueryGenerator _sqlQueryGenerator;
        private bool _stopFlage = false;

        public BulkUpsertTool()
        {
            InitializeComponent();
            
            // Initialize DBHelper
            _db = new DBLayer("Server=MARK-II\\SQLEXPRESS;Database=blazorecommerce;Trusted_Connection=True;");
            var test = _db.TestConnection();
            _sqlQueryGenerator = new SqlQueryGenerator();

            //Disable
            txtBrowse.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = false;

            // Setup Logs DataTable
            _logDateTable.Columns.Add("Logs");
            dgvLogs.DataSource = _logDateTable;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load Dropdowns
            LoadUpdateTables();
            LoadOrganizations();
        }

        #region LoadComboBox
        public void LoadUpdateTables()
        {
            var items = new List<string>()
            {
                "Tank",
                "Location",
                "Product"
            };

            cbCatagory.DataSource = items;
            cbCatagory.SelectedIndex = 0;
        }

        private void LoadOrganizations()
        {
            var organizations = _db.GetListOfOrganization();
            cbOrganization.DataSource = organizations;
            cbOrganization.DisplayMember = "OrganizationName";
            cbOrganization.ValueMember = "OrganizationId";
            cbOrganization.SelectedIndex = -1; // No selection by default
        }

        private void LoadUsers(int orgID)
        {
            var users = _db.GetListOfUsers(orgID);
            cbUser.DataSource = users;
            cbUser.DisplayMember = "UserName";
            cbUser.ValueMember = "UserId";
            cbUser.SelectedIndex = -1; // No selection by default
            if (users.Count() > 0)
            {
                cbUser.Enabled = true;
            }
        }
        #endregion

        #region Events
        private void cbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orgId = cbOrganization.SelectedIndex;
            cbUser.Enabled = false;
            LoadUsers(orgId);
        }

        private void linkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sourceFilePath = @"Templates\\";

            if (cbCatagory.SelectedIndex > -1)
            {
                switch (cbCatagory.SelectedIndex)
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
                saveFileDialog.FileName = "template.xlsx";
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save File";


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Copy the file from the source to the selected destination
                        File.Copy(sourceFilePath, saveFileDialog.FileName, true);
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;

                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    txtBrowse.Text = fileName;

                    LoadExcel(fileName);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string message = "List of Fields to Update";
            string title = "Conform to Start the process";
            if (ShowYesNoMessage(title, message))
            {
                StartProcessing();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _stopFlage = true;
        }
        #endregion

        #region Helpers
        private void StartProcessing()
        {
            _db.UpdateRecords(cbCatagory.SelectedItem.ToString(), _excelDataTable, Convert.ToInt32(0));
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
                    _excelDataTable = dataset.Tables[0];
                    dgvExcel.DataSource = _excelDataTable;
                    lblRecordsinFiles.Text = _excelDataTable.Rows.Count.ToString();

                    UpdateLogs($"Total Columns in File: {_excelDataTable.Columns.Count}");
                    UpdateLogs($"Total Rows in File: {_excelDataTable.Rows.Count}");
                }
            }
            UpdateLogs("Completed Reading File");

            btnStart.Enabled = true;
            btnStop.Enabled = true;
        }

        private void UpdateLogs(string message)
        {
            _logDateTable.Rows.Add(message);
            dgvLogs.Refresh();
        }
         
        private void ShowValidationMessage(string message)
        { 
            MessageBox.Show(message, "Validation Failed");
        }

        private bool ShowYesNoMessage(string title, string message)
        {
            bool flage = false;
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                flage = true;
            }

            return flage;

        }
        #endregion
    }
}
