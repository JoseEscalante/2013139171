using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    class CalificacionHospedaje
    {

        private int _Calificacion;

        public int Calificacion
        {
            get
            {
                return _Calificacion;
            }

            set
            {
                if (value > 0)
                    _Calificacion = value;
            }
        }

        public CalificacionHospedaje(int califacion)
        {
            Calificacion = califacion;
        }

       
    }
}
