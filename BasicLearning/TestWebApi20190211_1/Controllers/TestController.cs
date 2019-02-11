using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebApi20190211_1.Controllers
{
    public class TestController : System.Web.Http.ApiController
    {
        [HttpGet]
        public string GetAll()
        {
            return "GetAll";
        }
        [HttpGet]
        public string GetOne(string id)
        {
            return string.Format("GetOne {0}", id);
        }
        [HttpDelete]
        public string DeleteAll()
        {
            return "DeleteAll";
        }
        [HttpDelete]
        public string DeleteOne(string id)
        {
            return string.Format("DeleteOne {0}", id);
        }
        [HttpPut]
        public string UpdateAll()
        {
            return "UpdateAll";
        }
        [HttpPut]
        public string UpdateOne(string id)
        {
            return string.Format("UpdateOne {0}", id);
        }
        [HttpPost]
        public string Add(string id)
        {
            return "UpdateAll";
        }
    }
}