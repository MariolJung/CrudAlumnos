using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CrudAlumnos_172.Models;

namespace CrudAlumnos_172.Controllers
{
    public class DATOS_ALUMNOS_172Controller : Controller
    {
        private ALUMNOS_ISFTEntities db = new ALUMNOS_ISFTEntities();

        // GET: DATOS_ALUMNOS_172
        public ActionResult Index()
        {
            return View(db.DATOS_ALUMNOS_172.ToList());
        }

        // GET: DATOS_ALUMNOS_172/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DATOS_ALUMNOS_172 dATOS_ALUMNOS_172 = db.DATOS_ALUMNOS_172.Find(id);
            if (dATOS_ALUMNOS_172 == null)
            {
                return HttpNotFound();
            }
            return View(dATOS_ALUMNOS_172);
        }

        // GET: DATOS_ALUMNOS_172/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DATOS_ALUMNOS_172/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,APELLIDO,NOMBRE,SEXO,DIRECCION,TELEFONO,FECHA")] DATOS_ALUMNOS_172 dATOS_ALUMNOS_172)
        {
            if (ModelState.IsValid)
            {
                db.DATOS_ALUMNOS_172.Add(dATOS_ALUMNOS_172);
                db.SaveChanges();
                ViewBag.mensaje = "Dato Guardado";
                return RedirectToAction("Index");
            }

            return View(dATOS_ALUMNOS_172);
        }

        // GET: DATOS_ALUMNOS_172/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DATOS_ALUMNOS_172 dATOS_ALUMNOS_172 = db.DATOS_ALUMNOS_172.Find(id);
            if (dATOS_ALUMNOS_172 == null)
            {
                return HttpNotFound();
            }
            
            return View(dATOS_ALUMNOS_172);
        }

        // POST: DATOS_ALUMNOS_172/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,APELLIDO,NOMBRE,SEXO,DIRECCION,TELEFONO,FECHA")] DATOS_ALUMNOS_172 dATOS_ALUMNOS_172)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dATOS_ALUMNOS_172).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dATOS_ALUMNOS_172);
        }

        // GET: DATOS_ALUMNOS_172/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DATOS_ALUMNOS_172 dATOS_ALUMNOS_172 = db.DATOS_ALUMNOS_172.Find(id);
            if (dATOS_ALUMNOS_172 == null)
            {
                return HttpNotFound();
            }
            return View(dATOS_ALUMNOS_172);
        }

        // POST: DATOS_ALUMNOS_172/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DATOS_ALUMNOS_172 dATOS_ALUMNOS_172 = db.DATOS_ALUMNOS_172.Find(id);
            db.DATOS_ALUMNOS_172.Remove(dATOS_ALUMNOS_172);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
