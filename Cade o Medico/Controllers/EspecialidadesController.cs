using Cade_o_Medico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cade_o_Medico.Controllers
{
    public class EspecialidadesController : Controller
    {
        private CadeMeuMedicoEntities1 db = new CadeMeuMedicoEntities1();
        // GET: Especialidades
        public ActionResult Index()
        {
            var especialidade = db.Especialidade;

            return View(especialidade);
        }
        public ActionResult Adicionar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adicionar( Especialidade especialidade)
        {
            if (ModelState.IsValid)
            {
                db.Especialidade.Add(especialidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View (especialidade);
        }

        public ActionResult Editar (long Id)
        {
            var especialidade = db.Especialidade.Find(Id);
            return View(especialidade);
        }

        [HttpPost]
        public ActionResult Editar (Especialidade especialidade)
        {
            if (ModelState.IsValid)

            {

                db.Entry(especialidade).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");

            }
            return View(especialidade);
        }
        [HttpPost]
        public string Excluir(long Id)
        {
            try
            {
                Especialidade especialidade = db.Especialidade.Find(Id);
                db.Especialidade.Remove(especialidade);
                db.SaveChanges();
                return bool.TrueString;
            }
            catch (Exception)
            {

                return Boolean.FalseString;
            }
        }

    }
}