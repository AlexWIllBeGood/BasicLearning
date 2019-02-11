using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TestWebApi20190211
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            //默认的RestFul风格的WebApi路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                //正则表达式限制
            );
            //带有action的WebApi
            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //config.Routes.MapHttpRoute(
            //    name: "TestApi",
            //    routeTemplate: "TestApi/{controller}/{genderType}/{id}",
            //    defaults: new { genderType="aa",id = RouteParameter.Optional }
            //    //正则表达式限制
            //);
            config.Routes.MapHttpRoute(
                name: "TestApi",
                routeTemplate: "testapi/{controller}/{ordertype}/{id}",
                defaults: new { ordertype = "aa", id = RouteParameter.Optional }
            );
        }
    }
}
