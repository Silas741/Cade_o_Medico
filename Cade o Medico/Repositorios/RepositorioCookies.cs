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


            //Setando o ID do usuário no cookie

            UserCookie.Values["IDUsuario"] = Cade_o_Medico.Repositorios.RepositorioCriptografia.Criptografar(IDUsuario.ToString());



            //Definindo o prazo de vida do cookie

            UserCookie.Expires = DateTime.Now.AddDays(1);



            //Adicionando o cookie no contexto da aplicação

            HttpContext.Current.Response.Cookies.Add(UserCookie);
        }
    }
}