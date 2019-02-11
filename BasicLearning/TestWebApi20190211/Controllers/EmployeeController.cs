using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TestWebApi20190211.Models;

namespace TestWebApi20190211.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Employee> empList = null;
        public EmployeeController()
        {
            empList = new List<Employee>() {
                new Employee(){CardNo=65,EmployeeName="Alex",Id="421127199308050021",Post="Engineer",Gender="male"},
                new Employee(){CardNo=66,EmployeeName="Jane",Id="421127199308050022",Post="Engineer",Gender="female"},
                new Employee(){CardNo=67,EmployeeName="Jarry",Id="421127199308050022",Post="ProjectManager",Gender="male"},
                new Employee(){CardNo=68,EmployeeName="Jack",Id="421127199308050022",Post="Engineer",Gender="male"},
                new Employee(){CardNo=69,EmployeeName="Jay",Id="421127199308050022",Post="Engineer",Gender="male"},
                new Employee(){CardNo=70,EmployeeName="Jason",Id="421127199308050022",Post="Boss",Gender="male"}
            };
        }
        [System.Web.Http.HttpGet]
        public List<Employee> GetAll()
        {
            return empList;
        }
        [System.Web.Http.ActionName("GetSome")]
        [System.Web.Http.HttpGet]
        public List<Employee> GetEmpById(int id)
        {
            return empList.Where(e => e.CardNo == id).ToList();
        }
        [System.Web.Http.HttpGet]
        public object GetAll1()
        {
            return "Success";
        }


    }
}