using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityDB.Controllers
{
    public class tareaController : Controller
    {
        private tasksEntities db = new tasksEntities();

        //
        // GET: /tarea/

        public ActionResult Index()
        {
            var tareas = db.tareas.Include(t => t.Usuario);
            return View(tareas.ToList());
        }

        //
        // GET: /tarea/Details/5

        public ActionResult Details(int id = 0)
        {
            tarea tarea = db.tareas.Find(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        //
        // GET: /tarea/Create

        public ActionResult Create()
        {
            ViewBag.iduser = new SelectList(db.Usuarios, "id", "nombre");
            return View();
        }

        //
        // POST: /tarea/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tarea tarea)
        {
            if (ModelState.IsValid)
            {
                db.tareas.Add(tarea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.iduser = new SelectList(db.Usuarios, "id", "nombre", tarea.iduser);
            return View(tarea);
        }

        //
        // GET: /tarea/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tarea tarea = db.tareas.Find(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            ViewBag.iduser = new SelectList(db.Usuarios, "id", "nombre", tarea.iduser);
            return View(tarea);
        }

        //
        // POST: /tarea/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tarea tarea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.iduser = new SelectList(db.Usuarios, "id", "nombre", tarea.iduser);
            return View(tarea);
        }

        //
        // GET: /tarea/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tarea tarea = db.tareas.Find(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        //
        // POST: /tarea/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tarea tarea = db.tareas.Find(id);
            db.tareas.Remove(tarea);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}