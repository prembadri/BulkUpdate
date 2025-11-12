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

        public DBLayer(string connectionString)
        {
            _connectionString = connectionString;
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

        public bool UpdateRecords(string table, DataTable dataTable, int userId)
        {
            bool result = false;

            switch (table)
            {
                case "TankConfig":

                    // Insert Copy of the old records 
                    var copyQuery = "INSERT INTO table_name (column1, column2, column3)\r\nSELECT column1, column2, column3\r\nFROM table_name\r\nWHERE condition;";
                    
                    // Update the New record tank Config 

                    var update = "updateQuery";
                    
                    // Update the new tankConfig to the Tank Table 

                    break;

                default:
                    break;
            }

            return result;
        }
    }
}
