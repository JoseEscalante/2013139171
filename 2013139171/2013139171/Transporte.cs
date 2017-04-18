using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class Transporte : ServicioTuristico
    {
        public Transporte(TipoTransporte tipT, CategoriaTransporte catT, double prec)
        {
            this.tipoTransporte = tipT;
            this.categoriaTransporte = catT;
            this.precio = prec;
        }

        public int code { get; set; }
        public TipoTransporte tipoTransporte { get; set; }
        public CategoriaTransporte categoriaTransporte { get; set; }
        public double precio { get; set; }
        public override double obtenerPrecio()
        {
            return this.precio;
        }

    }
}
