using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CURDApplication.Models
{
    public class Employee
    {
        public int Emp_Id { get; set; }
        public string Lname { get;set; }
        public string Fname {  get; set; }  
        public long Salary { get; set; }
    }
}