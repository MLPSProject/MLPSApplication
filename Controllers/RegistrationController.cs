using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MLPSApplication.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisteredUser()
        {
            return View();
        }

        public ActionResult UnRegisteredUser()
        {
            return View();
        }
    }
}