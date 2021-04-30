using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Grupo2.eCommerceMVC.UI.Web.Models;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;

namespace Grupo2.eCommerceMVC.UI.Web.Controllers
{
    [AllowAnonymous]
    public class LoginController : BaseController
    {
        [HttpGet]
        public ActionResult Index(string returnUrl)
        {
            Session["sesion"] = "No logueado";
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View();

            if (model.Email == "prueba@prueba.com" && model.Password == "123")
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, "prueba@prueba.com"),
                    new Claim(ClaimTypes.Email, "prueba@prueba.com"),
                    new Claim(ClaimTypes.Country, "Argentina"),
                };
                var identity = new ClaimsIdentity(claims, "ApplicationCookie");
                IOwinContext ctx = Request.GetOwinContext();
                IAuthenticationManager authManager = ctx.Authentication;
                authManager.SignIn(identity);
                Session["sesion"] = "Logueado";
                ViewData["Prueba"] = "Logueado";
                ViewBag.sesion = Session["sesion"];
                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }
            ModelState.AddModelError("", "El correo electrónico o la contraseña no son válidos.");
            return View();
        }
        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }
    }
}