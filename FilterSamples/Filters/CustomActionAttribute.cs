using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterSamples.Filters
{
    public class CustomActionAttribute : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;
            LogHelper.Log.LogMessage("On Action Executing from " + controllerName + "\\" + actionName);
        }

        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;
            LogHelper.Log.LogMessage("On Action Executed from " + controllerName + "\\" + actionName);
        }      
    }
}