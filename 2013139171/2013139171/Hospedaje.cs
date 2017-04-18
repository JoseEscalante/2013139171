using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class Hospedaje : ServicioTuristico
    {
        public Hospedaje(TipoHospedaje tipohospedaje, CalificacionHospedaje calificacion, CategoriaHospedaje cate, List<ServicioHospedaje> servicio)
        {
            this.tipoHospedaje = tipohospedaje;
            this.calificacionHospedaje = calificacion;
            this.categoriaHospedaje = cate;
            this._ServiciosHospedaje = servicio;
        }

        public int code { get; set; }
        public TipoHospedaje tipoHospedaje { get; set; }
        public CalificacionHospedaje calificacionHospedaje { get; set; }
        public CategoriaHospedaje categoriaHospedaje { get; set; }

        // Pueden ofrecerse 1 o más servicios dentro del hospedaje.
        private List<ServicioHospedaje> _ServiciosHospedaje;
        public List<ServicioHospedaje> ServiciosHospedaje
        {
            get { return _ServiciosHospedaje; }
            set { _ServiciosHospedaje = ServiciosHospedaje; }
        }

        public double precioFinal { get; set; }

        public double PrecioFinal
        {
            set
            {
                double factorPrecioServicios = 1;
                foreach (ServicioHospedaje ser in this.ServiciosHospedaje)
                {
                    factorPrecioServicios *= ser.factorPrecio;
                }
                precioFinal = this.tipoHospedaje.factorPrecio * this.calificacionHospedaje.factorPrecio * this.categoriaHospedaje.factorPrecio * factorPrecioServicios;
            }
        }

      
        public override double obtenerPrecio()
        {
            return this.precioFinal;
        }

    }
}
