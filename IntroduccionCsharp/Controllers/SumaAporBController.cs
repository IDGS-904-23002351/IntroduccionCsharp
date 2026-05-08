using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class SumaAporBController : Controller
    {
        public ActionResult SumaAporB(SumaAporB sumaAporB)
        {
            sumaAporB.Calculo();
            return View(sumaAporB);
        }
    }
}
