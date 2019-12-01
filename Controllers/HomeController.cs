using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CtrlWebT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "La página de descripción de su aplicación.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Su página para consultas.";

            return View();
        }
    }
}