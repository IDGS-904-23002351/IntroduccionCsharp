using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(IntroduccionCsharp.Models.Pelicula))]

namespace IntroduccionCsharp.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public DateTime Publicacion {  get; set; }
        public string Pais { get; set; }
    }
}
