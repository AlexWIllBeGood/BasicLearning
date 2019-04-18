using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TestWebApi20190218.Models;
using Newtonsoft.Json;

namespace TestWebApi20190218.Controllers
{
    [System.Web.Http.RoutePrefix("BPO/Employee")]
    public class EmployeeController : ApiController
    {
        List<Employee> employeeList = new List<Employee>() {
            new Employee(){Name="Alex",Age="25",ID="SZ45001" },
            new Employee(){Name="Jason",Age="28",ID="SZ45002" },
            new Employee(){Name="Jane",Age="21",ID="SZ45003"}
        };
        #region 查询
        [System.Web.Http.Route("All")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetAll()
        {
            JsonHelper json = new JsonHelper() { Status="y"};
            json.Data = JsonConvert.SerializeObject(employeeList);
            return Json(json);
        }
        [System.Web.Http.Route("GetById/{id}")]
        [System.Web.Http.HttpGet]
        public Employee GetById(string id)
        {
            return employeeList.Where(e => e.ID == id).FirstOrDefault();
        }
        [System.Web.Http.Route("GetByName/{name}")]
        [System.Web.Http.HttpGet]
        public List<Employee> GetByName(string name)
        {
            return employeeList.Where(e => e.Name.Contains(name)).ToList();
        }
        #endregion  
        [System.Web.Http.Route("Add")]
        [System.Web.Http.HttpPost]
        public List<Employee> AddEmployee(Employee emp)
        {
            employeeList.Add(emp);
            return employeeList;
        }
        [System.Web.Http.Route("Delete")]
        [System.Web.Http.HttpPost]
        public bool Delete(Employee emp)
        {
            try
            {
                var item = employeeList.Where(e => e.ID == emp.ID).FirstOrDefault();
                if (item != null)
                {
                    employeeList.Remove(item);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        [System.Web.Http.Route("Update")]
        [System.Web.Http.HttpPost]
        public bool Update(Employee emp)
        {
            try
            {
                var item = employeeList.Where(e => e.ID == emp.ID).FirstOrDefault();
                if (item != null)
                {
                    employeeList.Remove(item);
                    employeeList.Add(emp);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}