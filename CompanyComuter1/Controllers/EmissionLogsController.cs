using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CompanyComuter1.Models;

namespace CompanyComuter1.Controllers
{
    public class EmissionLogsController : Controller
    {
        private CompanyComuterEntities1 db = new CompanyComuterEntities1();

        // GET: EmissionLogs
        public ActionResult Index()
        {
           
            
            
            return View(db.TopPerformers().ToList());
        }

        // GET: EmissionLogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmissionLog emissionLog = db.EmissionLogs.Find(id);
            if (emissionLog == null)
            {
                return HttpNotFound();
            }
            return View(emissionLog);
        }

        // GET: EmissionLogs/Create
        public ActionResult Create()
        {
            ViewBag.ssn = new SelectList(db.Employees, "ssn", "firstName");
            ViewBag.vType = new SelectList(db.Vehicles, "vType", "vType");
            return View();
        }

        // POST: EmissionLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ssn,vType,distance,co2")] EmissionLog emissionLog)
        {
            if (ModelState.IsValid)
            {
                db.EmissionLogs.Add(emissionLog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ssn = new SelectList(db.Employees, "ssn", "firstName", emissionLog.ssn);
            ViewBag.vType = new SelectList(db.Vehicles, "vType", "vType", emissionLog.vType);
            return View(emissionLog);
        }

        // GET: EmissionLogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmissionLog emissionLog = db.EmissionLogs.Find(id);
            if (emissionLog == null)
            {
                return HttpNotFound();
            }
            ViewBag.ssn = new SelectList(db.Employees, "ssn", "firstName", emissionLog.ssn);
            ViewBag.vType = new SelectList(db.Vehicles, "vType", "vType", emissionLog.vType);
            return View(emissionLog);
        }

        // POST: EmissionLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ssn,vType,distance,co2")] EmissionLog emissionLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emissionLog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ssn = new SelectList(db.Employees, "ssn", "firstName", emissionLog.ssn);
            ViewBag.vType = new SelectList(db.Vehicles, "vType", "vType", emissionLog.vType);
            return View(emissionLog);
        }

        // GET: EmissionLogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmissionLog emissionLog = db.EmissionLogs.Find(id);
            if (emissionLog == null)
            {
                return HttpNotFound();
            }
            return View(emissionLog);
        }

        // POST: EmissionLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmissionLog emissionLog = db.EmissionLogs.Find(id);
            db.EmissionLogs.Remove(emissionLog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult TopEmployees()
        {
            
            return View(db.Top5Employees().ToList());
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
