using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreDatos;

namespace CoreNegocio
{
    public class CommonBC
    {
        private static CoreDatos.FeriaVirtual _modelo;

        public static FeriaVirtual Modelo
        {
            get
            {
                if (_modelo == null)
                {
                    _modelo = new FeriaVirtual();
                }
                return _modelo;
            }
        }
    }
}
