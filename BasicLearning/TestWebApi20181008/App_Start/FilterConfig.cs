﻿using System.Web;
using System.Web.Mvc;

namespace TestWebApi20181008
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
