﻿using System.Web;
using System.Web.Mvc;

namespace Assignment1n01075532
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
