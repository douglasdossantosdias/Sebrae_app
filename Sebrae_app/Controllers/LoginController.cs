using Sebrae_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sebrae_app.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
          
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {

            if (ModelState.IsValid)
            {
                try
                {

                    //aqui a lógica de comparacao de login e senha
                    Usuario u = new Usuario() ;
                    u.NomeUsuario = "douglas";
                    u.SenhaUsuario = "123456";


                    if (model.NomeUsuario.Equals(u.NomeUsuario)&&model.SenhaUsuario.Equals(u.SenhaUsuario))
                    {
                        
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Mensagem = "Acesso Negado.Tente novamente";
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            
            return View();
        }

        [HttpPost]
        public ActionResult LogOff()
        {
            return RedirectToAction("Login");
        }
    }
}