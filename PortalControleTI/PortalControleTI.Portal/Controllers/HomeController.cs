using PortalControleTI.Core;
using PortalControleTI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalControleTI.Portal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Cliente
        [HttpGet]
        public ActionResult Index()
        {
            var model = ComputadorCore.Get();
            return View(model);
        }

        [HttpGet]
        public ActionResult Form(int Id)
        {
            Computador model;

            if (Id == 0)
            {
                model = new Computador();
                model.DataNfe = DateTime.Now;
            }
            else
            {
                model = ComputadorCore.Get(Id);
            }

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Form(Computador computador)
        {
            if (ModelState.IsValid)
            {
                if (computador.Id == 0)
                {
                    ComputadorCore.Add(computador);
                    TempData["Message"] = string.Format("Você incluiu o cliente {0} com sucesso!", computador.Serial);
                    return RedirectToAction("Index");
                }
                else
                {
                    ComputadorCore.Update(computador);
                    TempData["Message"] = string.Format("Você alterou o cliente {0} com sucesso!", computador.Serial);
                    return RedirectToAction("Index");
                }
            }

            return View(computador);
        }

        [HttpGet]
        public ActionResult Term(int Id)
        {
            Computador model = ComputadorCore.Get(Id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }
    }
}