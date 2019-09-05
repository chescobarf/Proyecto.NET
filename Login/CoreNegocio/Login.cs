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

        public bool Read()
        {
            try
            {
                CoreDatos.LOGIN resp =  CommonBC.Modelo.LOGIN.First(e => e.PERSONA_RUT == PERSONA_RUT && e.PASSWORD == PASSWORD);
				
				//Persona newPerson = new Persona();
				if (ESTADO=="1")
                {
					//newPerson.RUT = PERSONA_RUT;
					//return newPerson.Read();
					return true;
                    
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }



    }
}
