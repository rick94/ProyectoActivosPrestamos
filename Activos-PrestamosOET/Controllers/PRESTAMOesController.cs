﻿using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Activos_PrestamosOET.Models;

namespace Activos_PrestamosOET.Controllers
{
    public class PRESTAMOesController : Controller
    {
        private PrestamosEntities db = new PrestamosEntities();

        // GET: PRESTAMOes
        public ActionResult Index()
        {
            if (true)
                return View(db.PRESTAMOS.ToList());
            else
            {
                return View(db.PRESTAMOS.ToList());
            }
           
           
        }

        // GET: PRESTAMOes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRESTAMO pRESTAMO = db.PRESTAMOS.Find(id);
            if (pRESTAMO == null)
            {
                return HttpNotFound();
            }
            return View(pRESTAMO);
        }

        // GET: PRESTAMOes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PRESTAMOes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NUMERO_BOLETA,MOTIVO,FECHA_SOLICITUD,FECHA_RETIRO,PERIODO_USO,SOFTWARE_REQUERIDO,OBSERVACIONES_SOLICITANTE,OBSERVACIONES_APROBADO,OBSERVACIONES_RECIBIDO,CEDULA_USUARIO,SIGLA_CURSO")] PRESTAMO pRESTAMO)
        {
            if (ModelState.IsValid)
            {
                db.PRESTAMOS.Add(pRESTAMO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pRESTAMO);
        }

        // GET: PRESTAMOes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRESTAMO pRESTAMO = db.PRESTAMOS.Find(id);
            if (pRESTAMO == null)
            {
                return HttpNotFound();
            }
            return View(pRESTAMO);
        }

        // POST: PRESTAMOes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NUMERO_BOLETA,MOTIVO,FECHA_SOLICITUD,FECHA_RETIRO,PERIODO_USO,SOFTWARE_REQUERIDO,OBSERVACIONES_SOLICITANTE,OBSERVACIONES_APROBADO,OBSERVACIONES_RECIBIDO,CEDULA_USUARIO,SIGLA_CURSO")] PRESTAMO pRESTAMO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRESTAMO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pRESTAMO);
        }

        // GET: PRESTAMOes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRESTAMO pRESTAMO = db.PRESTAMOS.Find(id);
            if (pRESTAMO == null)
            {
                return HttpNotFound();
            }
            return View(pRESTAMO);
        }

        // POST: PRESTAMOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PRESTAMO pRESTAMO = db.PRESTAMOS.Find(id);
            db.PRESTAMOS.Remove(pRESTAMO);
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