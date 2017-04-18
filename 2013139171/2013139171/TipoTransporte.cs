using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class TipoTransporte
    {
        public TipoTransporte(string nom)
        {
            this.nombre = nom;
        }

        public int code { get; set; }
        public string nombre { get; set; }
        public string descrip { get; set; }



    }
}
