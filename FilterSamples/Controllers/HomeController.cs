using FilterSamples.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterSamples.Controllers
{
    //Custom Attributes Used Here
    [Authenticate]
    [CustomAction]
    [CustomResult]
    public class HomeController : Controller
    {
        [Filters.HandleError]
        public ActionResult Index()
        {
            //try
            //{
            //    var x = 0;
            //    var y = 5 / x;
            //}
            //catch
            //{
            //    throw new DivideByZeroException();
            //}

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}