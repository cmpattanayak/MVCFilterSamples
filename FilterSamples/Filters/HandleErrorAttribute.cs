using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterSamples.Filters
{
    public class HandleErrorAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                filterContext.Result = new RedirectResult("~/Error.html");
                filterContext.ExceptionHandled = true;
            }
        }
    }
}