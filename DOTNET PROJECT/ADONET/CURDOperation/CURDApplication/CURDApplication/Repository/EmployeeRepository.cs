using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CURDApplication.Repository
{
    public class EmployeeRepository
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        public List<Employee> GetEmployee

    }
}