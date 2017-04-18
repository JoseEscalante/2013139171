using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    public class VentaPaquete
    {
        public VentaPaquete(Cliente clien, Paquete paque, ComprobantePago compP, MedioPago medio, Empleado emple, DateTime fecha)
        {
            this.cliente = clien;
            this.paquete = paque;
            this.comprobantePago = compP;
            this.medioPago = medio;
            this.empleado = emple;
            this.fecha = fecha;
        }
        public int code { get; set; }
        public Cliente cliente { get; set; }

        //venta de un paquete a la vez
        public Paquete paquete { get; set; }
        public ComprobantePago comprobantePago { get; set; }
        public MedioPago medioPago { get; set; }
        //El empleado que realizara la venta
        public Empleado empleado { get; set; }
        public DateTime fecha { get; set; }
        public double montoTotal
        {
            get
            {
                return this.paquete.calcularPrecioTotal();
            }
            set
            {
                this.montoTotal = this.paquete.calcularPrecioTotal();
                this.comprobantePago.monto = this.paquete.calcularPrecioTotal();
            }
        }
            public string reporte()
        {
            string reporte = "";
            reporte += "Cliente : " + this.cliente.persona.nombreCompleto() + "\n";
            reporte += "Empleado responsable: " + this.empleado.persona.nombreCompleto() + "\n";
            reporte += "Fecha: " + this.fecha + "\n";
            reporte += "Monto total del paquete: s/. " + this.montoTotal + "\n";
            return reporte;


        }
        

    }
}
