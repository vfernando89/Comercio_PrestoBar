using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebMarket.Controllers
{
    public class HomeController : Controller
    {
        private Models.DBPrestoBarEntities bd = new Models.DBPrestoBarEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string id="")
        {
            //Logica de acceso a base de datos
            var productos = bd.Producto.Where(x=>x.Descripcion.Contains(id)).ToList();
            //Devolver una lista de Productos
            return View(productos);
        }
    }
}