using CURDApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CURDApplication.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/Employee/GetEmployee")]
        public string GetEmployee()
        {
            return "StudentList";
        }
        [HttpGet]
        [Route("api/Employee/Employee")]
        public string Employee(int id , string name)
        {
            return "Employee id "+id+" name"+name;
        }

        [HttpPost]
         public string InsertEmployee(Student std)
        {

            return std.City;
        }
    }
}
