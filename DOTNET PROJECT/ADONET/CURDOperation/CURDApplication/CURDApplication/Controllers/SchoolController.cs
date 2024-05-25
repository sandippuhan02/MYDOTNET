using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CURDApplication.Controllers
{
    public class SchoolController : ApiController
    {
        [HttpGet]
        [Route("api/School/GetSchool")]
        public string GetSchool()
        {
            return "School";
        } 
        [HttpGet]
        [Route("api/School/GetAllSchool")]
        public string GetAllSchool()
        {
            return "SchoolList";
        }
    }
}
