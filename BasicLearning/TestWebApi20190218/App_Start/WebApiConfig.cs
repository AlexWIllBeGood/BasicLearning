using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TestWebApi20190218
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务
            var crosAllowedMethods = ConfigurationManager.AppSettings["cors:allowedMethods"];
            var crosAllowedOrigin = ConfigurationManager.AppSettings["cors:allowedOrigin"];
            var crosAllowedHeaders = ConfigurationManager.AppSettings["cors:allowedHeaders"];
            var crosConfig = new EnableCorsAttribute(crosAllowedOrigin, crosAllowedHeaders, crosAllowedMethods);
            config.EnableCors(crosConfig);
            // Web API 路由
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "{controller}/{para}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            config.Routes.MapHttpRoute(
                name:"ActionApi",
                routeTemplate: "{controller}/{action}/{para}",
                defaults:new {para=RouteParameter.Optional}
                );
        }
    }
}
