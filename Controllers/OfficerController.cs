using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MLPSApplication.Controllers
{
    public class OfficerController : Controller
    {
        // GET: Officer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pending()
        {
            return View();
        }

        public ActionResult Process()
        {
            return View();
        }
    }
}