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
            int num1 = Convert.ToInt16(x);
            int num2 = Convert.ToInt16(y);
            if (rl == "Suma")
            {
                resultado = num1 + num2;
            } else if (rl == "Resta")
            {
                resultado = num1 - num2;
            }
            ViewBag.Resultado = resultado;
            return View();
        }
    }
}