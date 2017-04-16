using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    class TipoHospedaje
    {
        private string _TipoH;


        public string TipoH
        {

            get
            {
                return _TipoH;
            }
            set
            {
                _TipoH = value;
            }
        }

        public TipoHospedaje(string tipoH)
        {
            TipoH = tipoH;
        }

    }
}
