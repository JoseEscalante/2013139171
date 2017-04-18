using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class Cliente
    {
        public Cliente(Persona persona)
        {
            this.persona = persona;
        }

        public int code { get; set; }

        public Persona persona { get; set; }

    }
}
