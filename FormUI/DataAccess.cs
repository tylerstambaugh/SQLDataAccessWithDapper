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
        public List<Employee> GetEmployees(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Data")))
            {
                //var output =  connection.Query<Employee>($"SELECT * FROM Employee where LastName = '{lastName}'").ToList();
                var output = connection.Query<Employee>("dbo.spEmployeeLookup @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }

        public void InsertEmployee(string firstName, string lastName, string gender)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Data")))
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(
                    new Employee
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Gender = gender
                    }
                    );

                connection.Execute("dbo.spEmployeeInsert @FirstName, @LastName, @Gender", employees);
            }
        }
    }
}
