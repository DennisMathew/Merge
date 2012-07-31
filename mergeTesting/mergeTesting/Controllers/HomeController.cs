using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mergeTesting.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        //master changes
            //added by keerthi
            //added by Nandini 

            //deldeted by keerthi
        }

        public ActionResult About()
        {
            //view
            return View();
        }
    }
}
