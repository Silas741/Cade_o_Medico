using Cade_o_Medico.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cade_o_Medico.Filtro
{
    [HandleError]
    [[AttributeUsage(AttributeTargets.Class |
      AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AutorizacaoDeAcesso : ActionFilterAttribute
    {    
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                var Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
                var Action = filterContext.ActionDescriptor.ActionName;
                if (Controller !="Home" || Action !="Login")
                {
                    if (RepositorioUsuarios.VerificaUsuarioLogado()==null)
                    {
                        filterContext.RequestContext.HttpContext.Response.Redirect("/Home/Login?Url=" + filterContext.HttpContext.Request.Url.LocalPath);
                    }
                }
            }      
    }
}