using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class Alimentacion : ServicioTuristico
    {
        public Alimentacion(CategoriaAlimentacion cate, double precio)
        {
            this.categoriaAlmientacion = cate;
            this.precio = precio;
        }

        public int code { get; set; }
        public CategoriaAlimentacion categoriaAlmientacion { get; set; }
        public double precio { get; set; }
        public override double obtenerPrecio()
        {
            return this.precio;
        }
    }

}
