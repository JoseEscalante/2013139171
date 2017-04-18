using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class Empleado 
    {
        public Empleado(Persona persona, double suel)
        {
            this.persona = persona;
            this.sueldo = suel;
        }

        public int code { get; set; }
        public Persona persona{ get; set; }
        public double sueldo { get; set; }
    }
}
