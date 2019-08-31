using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CoreNegocios
{
   public class Login
    {
        public string PASSWORD { get; set; }
        public string ESTADO { get; set; }
        public decimal PERSONA_RUT { get; set; }

        public Login()
        {
            PASSWORD = string.Empty;
            ESTADO = string.Empty;
            PERSONA_RUT = 0;
        }

        public bool Validar(decimal rut, string pass)
        {
            try
            { 
                CapaDeDatos.LOGIN u = CommonBC.Modelo.LOGIN.First(p => p.PERSONA_RUT == PERSONA_RUT);
                if (u.PASSWORD == PASSWORD)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Login> ReadAll()
        {

            return GenerarListado(CommonBC.Modelo.LOGIN.ToList<CapaDeDatos.LOGIN>() );

        }

        public List<Login> ReadAllByRut(decimal rut)
        {

            var lista = CommonBC.Modelo.LOGIN.Where(e => e.PERSONA_RUT == PERSONA_RUT);

            return GenerarListado(lista.ToList<CapaDeDatos.LOGIN>());

        }

        private List<Login> GenerarListado(List<CapaDeDatos.LOGIN> listaDALC)
        {
            List<Login> listaBC = new List<Login>();

            foreach (CapaDeDatos.LOGIN registro in listaDALC)
            {
                Login log = new Login();
                log.PASSWORD = registro.PASSWORD;
                log.PERSONA_RUT = registro.PERSONA_RUT;
                log.ESTADO = registro.ESTADO;

                listaBC.Add(log);

            }

            return listaBC;
        }
    }
}
