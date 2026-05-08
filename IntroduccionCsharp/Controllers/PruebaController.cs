using IntroduccionCsharp.Models;
using IntroduccionCsharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Suma()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SumaCardiel(string x, string y, string rl)
        {
            ViewBag.Resultado = Convert.ToInt16(x) + Convert.ToInt16(y);
            return View();
        }
        [HttpPost]
        public ActionResult Suma(string x, string y, string rl)
        {
            int resultado = 0;
            if (rl == "Suma")
            {
                resultado = Convert.ToInt16(x) + Convert.ToInt16(y);
            } else if (rl == "Resta")
            {
                resultado = Convert.ToInt16(x) - Convert.ToInt16(y);
            }
            ViewBag.Resultado = resultado;
            return View();
        }
        public ActionResult MuestraPeliculas()
        {
            var peliculasService = new PeliculasService();
            var model = peliculasService.ObtenerPelicula();

            return View(model);
        }
        public ActionResult Calculos(OperacionesBas operacionesBas)
        {
            operacionesBas.Suma();
            return View(operacionesBas);

        }
    }
}