using BulkUpdateModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DBLayer
    {
        private string _connectionString;
        private SqlQueryGenerator _sqlQueryGenerator;

        public DBLayer(string connectionString)
        {
            _connectionString = connectionString;
            _sqlQueryGenerator = new SqlQueryGenerator();
        }

        public bool TestConnection()
        {
            bool isConnected = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    isConnected = true;
                }
            }
            catch (Exception ex)
            {
                string errorMsg = ex.Message;
            }
            return isConnected;
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

        public int RunQuery(string query,bool requiredId= false)
        {
            int result = 0;
            if (requiredId)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            int rowsAffected = (int)cmd.ExecuteScalar();
                            result = rowsAffected;
                        }
                    }
                }
                catch (Exception ex)
                {
                    string errorMsg = ex.Message;
                } 
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            result = rowsAffected;
                        }
                    }
                }
                catch (Exception ex)
                {
                    string errorMsg = ex.Message;
                }
            }
            return result;
        }

        public string UpdateRecords(string table, DataTable dataTable, int userId)
        {
            int result = 0;
            int failed = 0;

            switch (table)
            {
                case "TankConfig":

                    // Get the old Tank Config Id from the DataTable

                    // Insert Copy of the old records 
                    var copyQuery = "INSERT INTO table_name (column1, column2, column3)\r\nSELECT column1, column2, column3\r\nFROM table_name\r\nWHERE condition;";
                    var copyTankId = RunQuery(copyQuery,true);

                    // Update the New record tank Config 
                    var update = "updateQuery";
                    var updateResult = RunQuery(update);

                    // Update the new tankConfig to the Tank Table 

                    break;
                default:
                    {
                        foreach (var query in _sqlQueryGenerator.GenerateUpdateQueries(dataTable, "Location", "Id"))
                        {
                            using (SqlConnection conn = new SqlConnection(_connectionString))
                            {
                                conn.Open();
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    int rowsAffected = cmd.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                        result++;
                                    else
                                        failed++;
                                }
                            }
                        }
                    }
                    break;
            }

            return string.Format("{0}|{1}", result, failed);
        }
    }
}