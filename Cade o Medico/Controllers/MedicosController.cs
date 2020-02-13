using Cade_o_Medico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Cade_o_Medico.Controllers
{
    public class MedicosController : Controller
    {
        private CadeMeuMedicoEntities db = new CadeMeuMedicoEntities();
        // GET: Medicos
        public ActionResult Index()
        {
            var medicos = db.Medicos.Include("Cidades").Include("Especialidade").ToList();
            return View(medicos);
        }
        public ActionResult Adicionar()
        {
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome");
            ViewBag.IDEspecialidade = new SelectList(db.Especialidade, "IDEspecialidade", "Nome");


            return View();
        }
        [HttpPost]
        public ActionResult Adicionar (Medicos medico)
        {
            if (ModelState.IsValid)
            {
                db.Medicos.Add(medico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome", medico.IDCidade);

            ViewBag.IDEspecialidade = new SelectList(db.Especialidade, "IDEspecialidade", "Nome", medico.IDEspecialidade);

            return View(medico);
        }

        public ActionResult Editar (long id)
        {
            Medicos medico = db.Medicos.Find(id);
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidade, "IDEspecialidade", "Nome", medico.IDEspecialidade);
            return View(medico);
        }
        [HttpPost]
        public ActionResult Editar(Medicos medico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medico).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidade, "IDEspecialidade", "Nome", medico.IDEspecialidade);
            return View(medico);
        }

        [HttpPost]
        public string Excluir(long Id)
        {
            try
            {
                Medicos medico = db.Medicos.Find(Id);
                db.Medicos.Remove(medico);
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