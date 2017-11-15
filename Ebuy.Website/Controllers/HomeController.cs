using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ebuy.Website.Models;

namespace Ebuy.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }

       // [Authorize] // especifica que el acceso está restringido a usuarios que cumplieron un requisito de autorizacion
        public ActionResult Restringida()
        {
            ViewBag.Message = "Area Restringida.";
            ViewData["Message2"] = "Que no se puede entrar!";
            
            return View();
        }
    }
}