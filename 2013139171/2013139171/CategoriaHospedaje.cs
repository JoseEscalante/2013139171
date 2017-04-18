using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class CategoriaHospedaje
    {
        public CategoriaHospedaje(string nombre, double factorPrecio)
        {
            this.nombre = nombre;
            this.factorPrecio = factorPrecio;
        }

        public int code { get; set; }
        public string nombre { get; set; }
        public double factorPrecio { get; set; }

    }
}

