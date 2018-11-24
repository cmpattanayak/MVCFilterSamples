using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterSamples.Filters
{
    public class CustomResultAttribute : ActionFilterAttribute, IResultFilter
    {
        void IResultFilter.OnResultExecuting(ResultExecutingContext filterContext)
        {
            string controllerName = filterContext.RouteData.Values["controller"].ToString();
            string actionName = filterContext.RouteData.Values["action"].ToString();
            LogHelper.Log.LogMessage("On Result Executing from " + controllerName + "\\" + actionName);
        }

        void IResultFilter.OnResultExecuted(ResultExecutedContext filterContext)
        {
            string controllerName = filterContext.RouteData.Values["controller"].ToString();
            string actionName = filterContext.RouteData.Values["action"].ToString();
            LogHelper.Log.LogMessage("On Result Executed from " + controllerName + "\\" + actionName);
        }
    }
}