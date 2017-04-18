using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class TipoComprobante
    {
        public TipoComprobante(string nom, char abrevia)
        {
            this.nombre = nom;
            this.abreviatura = abrevia;
        }

        public int code { get; set; }
        public string nombre { get; set; }

        //Factura - F / Boleta - B
        public char abreviatura { get; set; }
    }

}
