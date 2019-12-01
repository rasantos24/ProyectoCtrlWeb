using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace CtrlWebT.Controllers
{
    public class InventarioController : Controller
    {
        private ConexionBD miBD = new ConexionBD();

        // GET: Inventario
        public ActionResult Index()
        {
            List<Inventario> grupos = miBD.getGrupos();
            return View(grupos);
        }
    }
}