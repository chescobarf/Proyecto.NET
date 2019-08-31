using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CoreNegocios
{
    class CommonBC
    {
        private static CapaDeDatos.Entities _modelo;

        public static Entities Modelo
        {
            get
            {
                if (_modelo == null)
                {
                    _modelo = new Entities();
                }
                return _modelo;
            }
        }
    }
}
