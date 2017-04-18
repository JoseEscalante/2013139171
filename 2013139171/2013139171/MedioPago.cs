using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class MedioPago
    {
        public MedioPago(string nombre, Boolean ofrecerDesc)
        {
            this.nombre = nombre;
            this.ofrecerDesc = ofrecerDesc;
        }

        public int code {  get; set; }
        public string nombre { get; set; }
        public string descrip { get; set; }

        public Boolean ofrecerDesc { get; set; }
    }
}
