using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cade_o_Medico.Repositorios
{
    public class RepositorioCookies
    {
        public static void RegistrarCookieAutenticacao(long IDUsuario)
        {
            HttpCookie UserCookie = new HttpCookie("UserCookieAuthentication");

            UserCookie.Values["IDUsuario"] = Cade_o_Medico.Repositorios.RepositorioCriptografia
        }
    }
}