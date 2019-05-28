using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insight_System.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Go()
        {
            ViewBag.Message = "Look Up Feature Places.";

            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Search Your Own Journey.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Showing Members.";

            return View();
        }


    }
}