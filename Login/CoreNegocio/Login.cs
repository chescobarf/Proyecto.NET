using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreNegocio
{
    public class Login
    {
        public string PASSWORD { get; set; }
        public string ESTADO { get; set; }
        public decimal PERSONA_RUT { get; set; }

        public Login()
        {
            this.Init();
        }

        private void Init()
        {
            PASSWORD = string.Empty;
            ESTADO = string.Empty;
            PERSONA_RUT = 0;
        }

        public Persona Read()
        {
            try
            {
                CoreDatos.LOGIN resp = CommonBC.Modelo.LOGIN.First(e => e.PERSONA_RUT == PERSONA_RUT && e.PASSWORD == PASSWORD);

                ESTADO = resp.ESTADO;
                PERSONA_RUT = resp.PERSONA_RUT;

                if (int.Parse(ESTADO) == 1)
                {
                    Persona newPerson = new Persona();
                    newPerson.RUT = PERSONA_RUT;
                    newPerson.Read();
                    return newPerson;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
