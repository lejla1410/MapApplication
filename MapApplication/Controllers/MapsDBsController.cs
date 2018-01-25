
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MapApplication.Models;

namespace MapApplication.Controllers
{
    public class MapsDBsController : Controller
    {
        private MapContext db = new MapContext();

        // GET: MapsDBs
        public ActionResult Index()
        {
            return View(db.AtractionDb.ToList());
        }

        // GET: MapsDBs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AtractionDb atractionDb = db.AtractionDb.Find(id);
            if (atractionDb == null)
            {
                return HttpNotFound();
            }
            return View(atractionDb);
        }

        // GET: MapsDBs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MapsDBs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AtractionDb atractionDb)
        {
            if (ModelState.IsValid)
            {
                db.AtractionDb.Add(atractionDb);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return View(atractionDb);
        }

        // GET: MapsDBs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AtractionDb atractionDb = db.AtractionDb.Find(id);
            if (atractionDb == null)
            {
                return HttpNotFound();
            }
            return View(atractionDb);
        }

        // POST: MapsDBs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AtractionDb atractionDb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atractionDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(atractionDb);
        }

        // GET: MapsDBs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AtractionDb atractionDb = db.AtractionDb.Find(id);
            if (atractionDb == null)
            {
                return HttpNotFound();
            }
            return View(atractionDb);
        }

        // POST: MapsDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AtractionDb atractionDb = db.AtractionDb.Find(id);
            db.AtractionDb.Remove(atractionDb);
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
