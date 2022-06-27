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
        public ActionResult Form(string serial)
        {
            Computador model = ComputadorCore.Get(serial);

            if (serial == null)
            {
                model = new Computador();
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
                Computador serial = ComputadorCore.Get(computador.Serial);
                
                if (serial == null)
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
    }
}