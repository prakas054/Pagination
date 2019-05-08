using API_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace API_Demo.Controllers
{
    public class EmployeeController : ApiController
    {
        private int rowCount = 1;
        private List<SampleEmployee> employees = new List<SampleEmployee>();
        public string connection = @"Data Source=PCZ-EE210673\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        public List<SampleEmployee> GetAllEmployees(int pageNumber = 0)
        {
            
            using (IDbConnection con=new SqlConnection(connection))
            {
                int startIndex = (pageNumber * rowCount);
                int endIndex = startIndex + rowCount;
                if (employees != null)
                {
                    employees = con.Query<SampleEmployee>("Select * from StudentMarks").ToList();
                }
                return employees.Skip(startIndex).Take(rowCount).ToList();
            }
        }
    }
}
