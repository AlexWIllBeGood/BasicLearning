using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BasicLearning
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                //只是表示参数是可选的而已
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
