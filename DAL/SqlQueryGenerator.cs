using System.Data;

public class SqlQueryGenerator
{
    public IEnumerable<string> GenerateUpdateQueries(DataTable dataTable, string tableName, string primaryKeyColumn)
    {
        var queries = new List<string>();

        foreach (DataRow row in dataTable.Rows)
        {
            var columns = new List<string>();
            var values = new List<string>();

            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.ColumnName != primaryKeyColumn && !row.IsNull(column))
                {
                    string value = FormatValue(row[column]);
                    columns.Add($"{column.ColumnName} = {value}");
                    values.Add(value);
                }
            }

            var updateQuery = $"UPDATE {tableName} SET {string.Join(", ", columns)} WHERE {primaryKeyColumn} = {FormatValue(row[primaryKeyColumn])};";

            yield return updateQuery;
        }
    }

    public string GenerateUpdateQuery(DataColumnCollection dataColumns, DataRow dataRow, string tableName, string primaryKey, int primaryKeyId, string skipColumnName)
    {
        var columns = new List<string>();
        var values = new List<string>();

        foreach (DataColumn column in dataColumns)
        {
            if (column.ColumnName != skipColumnName && !dataRow.IsNull(column))
            {
                string value = FormatValue(dataRow[column]);
                columns.Add($"{column.ColumnName} = {value}");
                values.Add(value);
            }
        }

        var updateQuery = $"UPDATE {tableName} SET {string.Join(", ", columns)} WHERE {primaryKey} = {FormatValue(primaryKeyId)};";

        return updateQuery;
    }

    private string FormatValue(object value)
    {
        if (value == null || value == DBNull.Value)
            return "NULL";

        switch (value.GetType().Name)
        {
            case "String":
                return $"'{value.ToString().Replace("'", "''")}'";
            case "DateTime":
                return $"'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}'";
            case "Boolean":
                return ((bool)value) ? "1" : "0";
            case "Byte[]":
                return $"CONVERT(varbinary(MAX), '{Convert.ToBase64String((byte[])value)}')";
            default:
                return value.ToString();
        }
    }
}