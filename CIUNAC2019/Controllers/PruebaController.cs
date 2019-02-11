using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using Dominio.Core.Entities;
using Dominio.MainModule;

namespace CIUNAC2019.Controllers
{
    public class PruebaController : Controller
    {
        PruebaManager objDAL = new PruebaManager();

        public ActionResult listaCompra()
        {
            return View(objDAL.listaPrueba());
        }
        

        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }
    }
}