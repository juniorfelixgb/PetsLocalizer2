using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetsLocalizer2.Controllers
{
    public class MascotasController : Controller
    {
        // GET: Mascotas
        public ActionResult Index()
        {
            return View();
        }
    }
}