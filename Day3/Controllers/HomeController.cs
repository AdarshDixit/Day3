using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {
            TempData["Id"] = id;
            return View();
        }

        public ActionResult ThankYou(int id)
        {

            TempData["Id2"] = id;
            return View();
        }

       
    }
}