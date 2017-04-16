using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171
{
    class CategoriaHospedaje
    {
        private string _Categoria;

        public string Categoria
        {
            get
            {
                return _Categoria;
            }
            set
            {
                _Categoria = value;
            }
        }

        public CategoriaHospedaje(string categoria)
        {
            Categoria = categoria;
        }




    }
}
}
