
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
        private MapsDBContext1 db = new MapsDBContext1();

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
            AtractionDb mapsDB = db.AtractionDb.Find(id);
            if (mapsDB == null)
            {
                return HttpNotFound();
            }
            return View(mapsDB);
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
        public ActionResult Create([Bind(Include = "ID,AtractionName,Latitude,Longitude,City")] AtractionDb mapsDB)
        {
            if (ModelState.IsValid)
            {
                db.AtractionDb.Add(mapsDB);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mapsDB);
        }

        // GET: MapsDBs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AtractionDb mapsDB = db.AtractionDb.Find(id);
            if (mapsDB == null)
            {
                return HttpNotFound();
            }
            return View(mapsDB);
        }

        // POST: MapsDBs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AtractionName,Latitude,Longitude,City")] AtractionDb mapsDB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mapsDB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mapsDB);
        }

        // GET: MapsDBs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AtractionDb mapsDB = db.AtractionDb.Find(id);
            if (mapsDB == null)
            {
                return HttpNotFound();
            }
            return View(mapsDB);
        }

        // POST: MapsDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AtractionDb mapsDB = db.AtractionDb.Find(id);
            db.AtractionDb.Remove(mapsDB);
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
