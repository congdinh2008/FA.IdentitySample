﻿using System.Web;
using System.Web.Mvc;

namespace FA.IdentitySample.WebMVCWithNuget
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
