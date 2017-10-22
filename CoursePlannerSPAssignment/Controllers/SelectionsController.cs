using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoursePlannerSPAssignment.Models;

namespace CoursePlannerSPAssignment.Controllers
{
    public class SelectionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Selections
        public ActionResult Index()
        {
            var selections = db.Selections.Include(s => s.Course).Include(s => s.Student);
            return View(selections.ToList());
        }

        // GET: Selections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Selection selection = db.Selections.Find(id);
            if (selection == null)
            {
                return HttpNotFound();
            }
            return View(selection);
        }

        // GET: Selections/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseCode");
            ViewBag.ApplicationUserId = new SelectList(db.Students, "ApplicationUserId", "FName");
            return View();
        }

        // POST: Selections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SelectionId,ApplicationUserId,CourseId")] Selection selection)
        {
            if (ModelState.IsValid)
            {
                db.Selections.Add(selection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseCode", selection.CourseId);
            ViewBag.ApplicationUserId = new SelectList(db.Students, "ApplicationUserId", "FName", selection.ApplicationUserId);
            return View(selection);
        }

        // GET: Selections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Selection selection = db.Selections.Find(id);
            if (selection == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseCode", selection.CourseId);
            ViewBag.ApplicationUserId = new SelectList(db.Students, "ApplicationUserId", "FName", selection.ApplicationUserId);
            return View(selection);
        }

        // POST: Selections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SelectionId,ApplicationUserId,CourseId")] Selection selection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(selection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseCode", selection.CourseId);
            ViewBag.ApplicationUserId = new SelectList(db.Students, "ApplicationUserId", "FName", selection.ApplicationUserId);
            return View(selection);
        }

        // GET: Selections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Selection selection = db.Selections.Find(id);
            if (selection == null)
            {
                return HttpNotFound();
            }
            return View(selection);
        }

        // POST: Selections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Selection selection = db.Selections.Find(id);
            db.Selections.Remove(selection);
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
