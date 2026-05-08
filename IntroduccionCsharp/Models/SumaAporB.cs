using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Models
{
    public class SumaAporB
    {
        public double A {  get; set; }
        public double B { get; set; }
        public double Res { get; set; }
        public string ResString { get; set; }
        public void Calculo()
        {
           for(int i = 1; i <= B; i++)
            {

                this.Res += (double)A;
                this.ResString += Convert.ToString(A);
               if(i != 5)
                {
                    this.ResString += " + ";
                }
               
            }
            
        }
    }
}