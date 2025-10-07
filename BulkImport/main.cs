using ExcelDataReader;
using System.ComponentModel;
using System.Data;

namespace BulkImport
{
    public partial class main : Form
    {

        DataTable logTable = new DataTable();
        DataTable dt = new DataTable();
        int completedProcessing = 0; int totalProcessing = 0; int totalFailed = 0;
        public main()
        {
            InitializeComponent();
            txtFileName.Enabled = false;

            cbRTUNumber.Enabled = false;
            cbTankId.Enabled = false;
            cbLocationId.Enabled = false;

            ckLocationName.Enabled = false;
            ckProductId.Enabled = false;
            ckRegion.Enabled = false;
            ckTankName.Enabled = false;
            ckUserTankId.Enabled = false;

            logTable.Columns.Add("Logs");
            dgvLogs.DataSource = logTable;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                    LoadComboBox();

                    lblNoofRecordsCount.Text = dt.Rows.Count.ToString();

                    UpdateLogs($"Total Columns in File: {dt.Columns.Count}");
                    UpdateLogs($"Total Rows in File: {dt.Rows.Count}");
                }
            }
            UpdateLogs("Completed Reading File");
        }

        private void LoadComboBox()
        {
            cbRTUNumber.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                        select dc.ColumnName).ToArray());
           
            cbTankId.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                   select dc.ColumnName).ToArray());

            cbLocationId.Items.AddRange((from dc in dt.Columns.Cast<DataColumn>()
                                       select dc.ColumnName).ToArray());

            cbTankId.Enabled = true;
            cbRTUNumber.Enabled = true;
            cbLocationId.Enabled = true;

            ckProductId.Enabled = true;
            ckLocationName.Enabled = true;
            ckRegion.Enabled = true;
            ckTankName.Enabled = true;
            ckUserTankId.Enabled = true;
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

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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

        private void StartProcessing()
        {
            UpdateLogs("Started Processing Data.");

            foreach (DataColumn dc in dt.Columns)
            {
                completedProcessing++;

                if (completedProcessing % 10 == 0)
                {
                    UpdateLogs($"Completed processing {completedProcessing}");
                }
            }

            UpdateLogs("Completed Processing Data.");
        }

    }
}
