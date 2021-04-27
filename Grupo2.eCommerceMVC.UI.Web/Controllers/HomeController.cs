using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grupo2.eCommerceMVC.UI.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            //Session["sesion2"] = ViewBag.sesion;
            //ViewBag.otrasesion = Session["sesion2"];
            return View();
        }
    }
}