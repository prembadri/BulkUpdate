using BulkUpdateModel;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
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

            var query = "";

            if (tableName.Trim().Equals("Tank", StringComparison.InvariantCultureIgnoreCase))
            {
                query = $"SELECT * FROM Tank WHERE TankID IN ({string.Join(",", ids)})";
            }
            else if (tableName.Trim().Equals("TankConfig", StringComparison.InvariantCultureIgnoreCase))
            {
                query = $"SELECT TC.* FROM TankConfig (nolock) TC Join Tank (nolock) T On T.TankConfigId = TC.TankConfigId WHERE T.TankID IN ({string.Join("", "", ids)})";
            }

            SqlDataReader dr = DAL.ReturnDataReader(query, _connectionString, null, true, 20);
            if (dr != null)
            {
                int columnCount = dr.FieldCount;
                while (dr.Read())
                {
                    var record = new Dictionary<string, object>();

                    // Add each column value to the dictionary
                    for (int i = 0; i < columnCount; i++)
                    {
                        string columnName = dr.GetName(i);
                        object value = dr.IsDBNull(i) ? null : dr.GetValue(i);
                        record[columnName] = value;
                    }
                    yield return record;
                }
                dr.Close();
            }
        }

        public List<string> GetColumnsAsync(string tableName)
        {
            var query = @"SELECT COLUMN_NAME 
            FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = @tableName";
            SqlParameter[] paramArray = new SqlParameter[1];
            paramArray[0] = DAL.Parameter("@tableName", tableName);
            SqlDataReader dr = DAL.ReturnDataReader(query, _connectionString, paramArray, true, 20);

            var columns = new List<string>();

            if (dr != null)
            {
                while (dr.Read())
                {
                    columns.Add(dr["COLUMN_NAME"].ToString());
                }
                dr.Close();
            }

            return columns;
        }

        public List<User> GetListOfUsers(int orgID)
        {
            var users = new List<User>();
            try
            {
                var query = @"select UserID,UserName from [User] where OrganizationID = @organizationID;";
                SqlParameter[] paramArray = new SqlParameter[1];
                paramArray[0] = DAL.Parameter("@organizationID", orgID);
                SqlDataReader dr = DAL.ReturnDataReader(query, _connectionString, paramArray, true, 20);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        var user = new User();

                        user.UserId = dr.GetInt32(0);
                        user.UserName = dr.GetString(1);
                        users.Add(user);
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                string errorMsg = ex.Message;
            }
            return users;
        }

        public List<Organization> GetListOfOrganization()
        {
            var organizations = new List<Organization>();
            try
            {
                var query = @"select OrganizationID, OrganizationName from Organization";
                SqlDataReader dr = DAL.ReturnDataReader(query, _connectionString, null, true, 20);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        var organization = new Organization();

                        organization.OrganizationId = dr.GetInt32(0);
                        organization.OrganizationName = dr.GetString(1);
                        organizations.Add(organization);
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                string errorMsg = ex.Message;
            }
            return organizations;
        }


        public bool UpdateValues(string table, List<Dictionary<string, object>> updateFiels, string id, int userId)
        {
            switch (table)
            {
                case "TankConfig":
                    {
                        var status = false;
                        using (var conn = new SqlConnection(_connectionString))
                        {
                            conn.Open();
                            using (var cmd = conn.CreateCommand())
                            {
                                string query = $"INSERT INTO [dbo].[TankConfig] (";

                                foreach (var item in updateFiels)
                                {
                                    query += $"{item["ColumnName"]}, ";
                                }

                                query += "ModifiedBy, ModifiedOn) VALUES (";
                                foreach (var item in updateFiels)
                                {
                                    query += $"@columnValue, ";
                                }
                                SqlParameter[] paramArray = new SqlParameter[updateFiels.Count];
                                int columnIndex = 0;
                                foreach (var field in updateFiels)
                                {
                                    
                                    paramArray[columnIndex] = DAL.Parameter("@columnValue", field["ColumnValue"]);
                                    columnIndex++;
                                }
                                cmd.Parameters.AddRange(paramArray);
                                cmd.CommandText = query;
                                cmd.CommandType = System.Data.CommandType.Text;
                                cmd.CommandTimeout = 20;

                                cmd.Parameters.AddRange(new SqlParameter[]
                                {
                                    DAL.Parameter("@id", id),
                                    DAL.Parameter("@modifiedBy", userId),
                                    DAL.Parameter("@modifiedOn", DateTime.UtcNow)
                                });

                                int rowsAffected = (int)cmd.ExecuteScalar();
                                status = UpdateValues("Tank", "TankConfigId", rowsAffected.ToString(), id, userId);
                            }
                        }

                        return status;
                    }
                default:
                    return false;
            }
        }

        public bool UpdateValues(string table, string column, string columnValue, string id, int userId)
        {
            switch (table)
            {
                case "Tank":
                    {
                        var query = $"UPDATE Tank SET {column} = @columnValue, ModifiedBy = @modifiedBy ,ModifiedOn = @modifiedOn WHERE TankID = @id";
                        SqlParameter[] paramArray = new SqlParameter[4];
                        paramArray[0] = DAL.Parameter("@columnValue", columnValue);
                        paramArray[1] = DAL.Parameter("@id", id);
                        paramArray[2] = DAL.Parameter("@modifiedBy", userId);
                        paramArray[3] = DAL.Parameter("@modifiedOn", DateTime.UtcNow);
                        var rowsAffected = DAL.ExecuteNonQuery(query, _connectionString, paramArray, true, 20);
                        return rowsAffected;
                    }
                case "Location":
                    {
                        var query = $"UPDATE Location SET {column} = @columnValue, ModifiedBy = @modifiedBy ,ModifiedOn = @modifiedOn WHERE LocationID = @id";
                        SqlParameter[] paramArray = new SqlParameter[4];
                        paramArray[0] = DAL.Parameter("@columnValue", columnValue);
                        paramArray[1] = DAL.Parameter("@id", id);
                        paramArray[2] = DAL.Parameter("@modifiedBy", userId);
                        paramArray[3] = DAL.Parameter("@modifiedOn", DateTime.UtcNow);
                        var rowsAffected = DAL.ExecuteNonQuery(query, _connectionString, paramArray, true, 20);
                        return rowsAffected;
                    }

                default:
                    return false;
            }
        }
    }
}
