using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class ComprobantePago
    {
        public ComprobantePago(TipoComprobante tipocomprobante, DateTime fecha)
        {
            this.tipoComprobante = tipocomprobante;
            this.fecha = fecha;
        }
        public int code { get; set; }
        public TipoComprobante tipoComprobante { get; set; }
        public DateTime fecha { get; set; }
        public double monto { get; set; }

    }

}
