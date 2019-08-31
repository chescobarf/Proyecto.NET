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

        //GET http://<server>/api/login     HTTP/1.1
        public bool GetValidacion(decimal usr, string pass)
        {
            return Log.Validar(usr, pass);
        }

        public List<Login> GetReadAll()
        {
            return Log.ReadAll();
        }

        public List<Login> GetReadAll(decimal usr)
        {
            return Log.ReadAllByRut(usr);
        }
    }
}
