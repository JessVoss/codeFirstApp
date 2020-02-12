using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using codeFirstApp.DAL;
using codeFirstApp.Models;

namespace codeFirstApp.Controllers
{
    public class EncounterController : Controller
    {
        private HospitalContext db = new HospitalContext();

        // GET: Encounter
        public ActionResult Index()
        {
            return View(db.Encounters.ToList());
        }

        // GET: Encounter/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encounter encounter = db.Encounters.Find(id);
            if (encounter == null)
            {
                return HttpNotFound();
            }
            return View(encounter);
        }

        // GET: Encounter/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Encounter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EncounterID,PatientID,DOS,EmployeeID,ServiceType")] Encounter encounter)
        {
            if (ModelState.IsValid)
            {
                db.Encounters.Add(encounter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(encounter);
        }

        // GET: Encounter/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encounter encounter = db.Encounters.Find(id);
            if (encounter == null)
            {
                return HttpNotFound();
            }
            return View(encounter);
        }

        // POST: Encounter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EncounterID,PatientID,DOS,EmployeeID,ServiceType")] Encounter encounter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encounter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(encounter);
        }

        // GET: Encounter/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encounter encounter = db.Encounters.Find(id);
            if (encounter == null)
            {
                return HttpNotFound();
            }
            return View(encounter);
        }

        // POST: Encounter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Encounter encounter = db.Encounters.Find(id);
            db.Encounters.Remove(encounter);
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
