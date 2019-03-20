using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkriptPrototyp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "In dieser App können Skripte angelegt, geändert, gelöscht und einegesehen werden.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hilfe.de.";

            return View();
        }
    }
}