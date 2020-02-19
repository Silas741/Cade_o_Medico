using Cade_o_Medico.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cade_o_Medico.Controllers
{
    public class UsuariosController : Controller
    {
        [HttpGet]
        public JsonResult AutenticacaoDeUsuario(string Login, string Senha)
        {
            if (RepositorioUsuarios.AutenticarUsuario(Login,Senha))
            {
                return Json(new { OK = true,
                    Mensagem = "Usuario autenticado. Redirecionando... " }, JsonRequestBehavior.AllowGet);
                
            }
            else
            {
                return Json(new
                {
                    OK = false,
                    Mensagem = "Usuario não encontrado. Tente novamente..."
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}