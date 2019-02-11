using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApi20190211.Models
{
    public class Employee
    {
        public Employee()
        {
           
        }
        public string EmployeeName { get; set; }
        public string Id { get; set; }
        public string Post { get; set; }
        public int CardNo { get; set; }
        public string Gender { get; set; }
    }
}