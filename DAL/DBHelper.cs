using System.Collections;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHelper
    {

        private string _connectionString;

        public DBHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<string> GetTableData(string tableName)
        {
            yield return "Sample Data from " + tableName;
        }
        public IEnumerable<Dictionary<string, object>> GetAllRecordsAsync(string tableName, List<string> ids)
        {
            var records = new List<Dictionary<string, object>>();

            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            // Query to get all records
            string query = $"SELECT * FROM {tableName}";

            using var command = new SqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            // Get column count
            int columnCount = reader.FieldCount;

            // Process each row
            while (await reader.ReadAsync())
            {
                var record = new Dictionary<string, object>();

                // Add each column value to the dictionary
                for (int i = 0; i < columnCount; i++)
                {
                    string columnName = reader.GetName(i);
                    object value = reader.IsDBNull(i) ? null : reader.GetValue(i);
                    record[columnName] = value;
                }

                
            }

            return records;
        }

        public List<string> GetColumnsAsync(string tableName)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            // Query to get column information
            string query = @"
            SELECT COLUMN_NAME 
            FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = @tableName";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@tableName", tableName);

            var columns = new List<string>();

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                columns.Add(reader["COLUMN_NAME"].ToString());
            }

            return columns;
        }
    }
}
