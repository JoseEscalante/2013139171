using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class ServicioHospedaje
    {
        public ServicioHospedaje(string nom, double facPrecio)
        {
            this.nombre = nom;
            this.factorPrecio = facPrecio;
        }
        public int code { get; set; }
        public string nombre { get; set; }
        public double factorPrecio { get; set; }
    }
}
