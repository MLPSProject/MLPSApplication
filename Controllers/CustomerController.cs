using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MLPSApplication.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ApplyLoan()
        {
            return View();
        }

        public ActionResult EMICalculator()
        {
            return View();
        }


    }
}