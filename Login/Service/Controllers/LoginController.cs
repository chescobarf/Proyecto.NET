using CoreNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Service.Controllers
{
    public class LoginController : ApiController
    {
           Login login = new Login();

        //GET http://<server>/api/login     HTTP/1.1
        public bool validar(decimal usr, string pass)
        {
            return login.Validar(usr, pass);
        }

        
    }
}
