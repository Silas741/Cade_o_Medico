using Cade_o_Medico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cade_o_Medico.Controllers
{
    public class CidadesController : Controller
    {
        private CadeMeuMedicoEntities1 db = new CadeMeuMedicoEntities1();
        // GET: Cidade
        public ActionResult Index()
        {
            var cidades = db.Cidades;
            return View(cidades);
        }
        public ActionResult Adicionar()

        {

            return View();

        }
        [HttpPost]

        public ActionResult Adicionar(Cidades cidade)

        {

            if (ModelState.IsValid)

            {

                db.Cidades.Add(cidade);

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(cidade);

        }
        public ActionResult Editar(long id)

        {

            var cidade = db.Cidades.Find(id);



            return View(cidade);

        }

        [HttpPost]

        public ActionResult Editar(Cidades cidade)

        {

            if (ModelState.IsValid)

            {

                db.Entry(cidade).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(cidade);

        }
        [HttpPost]
        public string Excluir(long Id)
        {
            try
            {
                Cidades cidade = db.Cidades.Find(Id);
                db.Cidades.Remove(cidade);
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