using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomaticTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        //GET /home/index
        [MyLoggingFilter]
        public ActionResult Index()
        {
            throw new StackOverflowException();
            return View(); //when view is called without parameters, its going to look for the view whose name matches the class method name
            //and since in the homecontroller, will look for home in the views for the cshtml file
        }

        //GET /home/about
        [ActionName("about-this-atm")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About"); //now this view is going to look in the views/home/about.cshtml
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thanks, we got your message";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVCATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            //return Content(serial);
            //return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
            return RedirectToAction("Index");
        }
    }
}