using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreNegocio
{
    public class Persona
    {
        public decimal RUT { get; set; }
        public string RUT_DV { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string EMAIL { get; set; }
        public decimal PERFIL_ID_PERFIL { get; set; }

        public Persona()
        {
            this.Init();
        }

        private void Init()
        {
            RUT = 0;
            RUT_DV = string.Empty;
            NOMBRE = string.Empty;
            APELLIDO = string.Empty;
            EMAIL = string.Empty;
            PERFIL_ID_PERFIL = 0;
        }

        public Persona Read()
        {
            try
            {
                CoreDatos.PERSONA resp = CommonBC.Modelo.PERSONA.First(e => e.RUT == RUT);
				Persona p = new Persona
				{
					RUT = resp.RUT,
					RUT_DV = resp.RUT_DV,
					NOMBRE = resp.NOMBRE,
					APELLIDO = resp.APELLIDO,
					EMAIL = resp.EMAIL,
					PERFIL_ID_PERFIL = resp.PERFIL_ID_PERFIL
				};
				return p;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
