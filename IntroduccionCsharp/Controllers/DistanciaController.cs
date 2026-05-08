using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class DistanciaController : Controller
    {

        public ActionResult DistanciaEntrePuntos(Distancia distancia)
        {
            distancia.CalculoDistancia();
            return View(distancia);

        }
    }
}
