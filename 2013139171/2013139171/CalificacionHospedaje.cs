using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class CalificacionHospedaje
    {

       public CalificacionHospedaje(string nombre, double factorPrecio)
        {
            this.nombre = nombre;
            this.factorPrecio = factorPrecio;
        }
        
        public int code { get; set; }
        public string nombre { get; set; }

        //Califacion de estrellas del 1 al 5.
        public short calificacionHospedaje { get; set; }

        //Requerimientos para cumplir cada calificacion
        public string descrip { get; set; }

        //El factor que influye en precio final del hospedaje
        public double factorPrecio { get; set; }
       
    }
}
