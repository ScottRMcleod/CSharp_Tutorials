using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    //Get / home/index
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble send us a message.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thank you, One of our consultants will be in contact with you shortley";

            return View();
        }
        public ActionResult Foo()
        {
     
            return View("About");
        }

        public ActionResult Serail(string letterCase)
        {
            //this applicatins
            string serail = "ASPNETMVC5ATM1";

            //Created an If statement passing
            if (letterCase == "lower")
            {
                return Content(serail.ToLower());
            }
            //else
            //  return Content(serail.ToUpper());

            //return Json(new { name = "serial", value = serail}, JsonRequestBehavior.AllowGet);
            //return Content(serail);
            return RedirectToAction("Index");

        }
    }
}