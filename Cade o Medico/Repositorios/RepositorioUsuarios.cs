using Cade_o_Medico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Cade_o_Medico.Repositorios
{
    public class RepositorioUsuarios
    {
        public static bool AutenticarUsuario(string Login, string Senha)
        {
            var senhaEscondida = FormsAuthentication.HashPasswordForStoringInConfigFile(Senha, "Sha1");
            try
            {
                using(var db = new CadeMeuMedicoEntities1())
                {
                    var AutenticaUsuarios = db.Usuarios.Where(a => a.Login == Login && Senha == Senha).SingleOrDefault();

                    if (AutenticaUsuarios == null)
                    {
                        return false;
                    }
                    else
                    {
                        RepositorioCookies.RegistrarCookieAutenticacao(AutenticaUsuarios.IDUsuario);
                        return true;
                    }
                }

            }
            catch (Exception)
            {

                return false;
            }



        }
    }
}