using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCsharp.Models
{
    public class Distancia
    {
        public double Numx1 { get; set; }
        public double Numx2 { get; set; }
        public double Numy3 { get; set; }
        public double Numy4 { get; set; }
        public double Res { get; set; }
        public void CalculoDistancia()
        {
            double paso = Math.Pow(Numx2 - Numx1, 2) + Math.Pow(Numy4 - Numy3, 2);
            this.Res = Math.Sqrt(paso);
        }
    }
}