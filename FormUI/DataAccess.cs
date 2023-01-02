using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Employee> GetEmployees(string LastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Data")))
            {
                var output =  connection.Query<Employee>($"SELECT * FROM Employee where LastName = '{LastName}'").ToList();
                return output;
            }
        }
    }
}
