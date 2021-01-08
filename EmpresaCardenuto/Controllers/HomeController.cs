using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpresaCardenuto.Models;

namespace EmpresaCardenuto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Concluido = false;
            return View();
        }

        [HttpPost]
        public ActionResult Contato(Contatos contato)
        {
            try
            {
                Classes.RotinasWeb.GravarContato(contato);
                ViewBag.Concluido = true;
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }
       
    }
}