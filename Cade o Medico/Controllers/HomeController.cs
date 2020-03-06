using Cade_o_Medico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cade_o_Medico.Controllers
{
    public class HomeController : BaseController
    {
        private CadeMeuMedicoEntities1 db = new CadeMeuMedicoEntities1();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Especialidades = new SelectList(db.Especialidade, "IDEspecialidade", "Nome");

            ViewBag.Cidades = new SelectList(db.Cidades, "IDCidade", "Nome");



            return View();
        }
        public ActionResult Home()


        {
            return View();
        }
    
        public ActionResult Login()
        {
            ViewBag.Title = "Seja bem vindo";
            return View();
        }
    }
}