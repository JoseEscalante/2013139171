﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
   public class Paquete
    {
        public Paquete(List<ServicioTuristico> servT)
        {
            this._ServiciosTuristicos = servT;
        }

        public int code { get; set; }
        // Un paquete puede contener 1 o varios servicios turísticos, de acuerdo a necesidad.
        private List<ServicioTuristico> _ServiciosTuristicos;
        public List<ServicioTuristico> ServiciosTuristicos
        {
            get { return _ServiciosTuristicos; }
            set { _ServiciosTuristicos = ServiciosTuristicos; }
        }
        // Función que retorna el precio de acuerdo a la suma de los precios de los servicios turísticos requeridos.
        public double calcularPrecioTotal()
        {
            double precioFinal = 0;
            foreach (ServicioTuristico ser in this.ServiciosTuristicos)
            {
                precioFinal += ser.obtenerPrecio();
            }
            return precioFinal;
        }

    }
}
