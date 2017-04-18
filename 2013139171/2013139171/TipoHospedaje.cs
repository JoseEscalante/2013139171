using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class TipoHospedaje
    {
       public TipoHospedaje(string nom, double facPrecio)
        {
            this.nombre = nom;
            this.factorPrecio = facPrecio;
        }

        public int code { get; set; }

        //Hostal,Hotel,Backpacker ....
        public string nombre { get; set; }
        
        //Factor que influye el precio final
        public double factorPrecio { get; set; }

    }
}
