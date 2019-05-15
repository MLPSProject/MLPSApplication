using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MLPSApplication.Controllers
{
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
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpGet]
        public ActionResult RegisteredLogin()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UnRegisteredLogin()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Enquiry()
        {
            return View();
        }

        [HttpGet]
         public ActionResult UnRegisterApply()
        {
            return View();
        }
    }
}