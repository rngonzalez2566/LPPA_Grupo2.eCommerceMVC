using eCommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.BLL;

namespace Grupo2.eCommerceMVC.UI.Web.Controllers
{
    public class AltaProductoController : Controller
    {
        // GET: AltaProducto
     
        public ActionResult Index()
        {
            eCommerce.BLL.Mapper_Categoria categoria = new eCommerce.BLL.Mapper_Categoria();
            var model = categoria.TraerCategorias(); 
            return View(model);
         
        }


        [HttpPost]
        public ActionResult Index(Producto model)
        {
            if (!ModelState.IsValid) return View();

            eCommerce.BLL.Mapper_Producto prod = new eCommerce.BLL.Mapper_Producto();            
            
            prod.AltaProducto(model);
            return RedirectToAction("Index");
        }
    }
}