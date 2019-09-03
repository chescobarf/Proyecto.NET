using CoreNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServiceAPI.Controllers
{
    public class LoginController : ApiController
    {
        Login Log = new Login();

		[HttpPostAttribute]
        public bool PostAuth(decimal usr, string pass)
        {
			Login persona = new Login();
			persona.PERSONA_RUT = usr;
			persona.PASSWORD = pass;
			persona.ESTADO = "1";
			return Log.Validar(persona);
        }

        public List<Login> GetReadAll()
        {
            return Log.ReadAll();
        }

        public List<Login> GetReadBy(decimal usr)
        {
            return Log.ReadAllByRut(usr);
        }
    }
}
