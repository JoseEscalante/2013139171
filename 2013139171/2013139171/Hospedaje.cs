using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    class Hospedaje : ServicioTuristico
    {
        private List<TipoHospedaje> _TipoH;

        public Hospedaje (int tipoH, int califacion)
        {
            _TipoH = new List<TipoHospedaje> (tipoH);
            _Calificacion = new List<CalificacionHospedaje>(califacion);
        }

        private List<CalificacionHospedaje> _Calificacion;

      


















    }
}
