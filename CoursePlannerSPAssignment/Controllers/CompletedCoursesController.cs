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
    public class CompletedCoursesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CompletedCourses
        public ActionResult Index()
        {
            var completedCourses = db.CompletedCourses.Include(c => c.Course).Include(c => c.Student);
            return View(completedCourses.ToList());
        }

        // GET: CompletedCourses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompletedCourse completedCourse = db.CompletedCourses.Find(id);
            if (completedCourse == null)
            {
                return HttpNotFound();
            }
            return View(completedCourse);
        }

        // GET: CompletedCourses/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseCode");
            ViewBag.ApplicationUserId = new SelectList(db.Students, "ApplicationUserId", "FName");
            return View();
        }

        // POST: CompletedCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompleteId,CourseId,Passed,YearCompleted,SemesterCompleted,ApplicationUserId")] CompletedCourse completedCourse)
        {
            if (ModelState.IsValid)
            {
                db.CompletedCourses.Add(completedCourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseCode", completedCourse.CourseId);
            ViewBag.ApplicationUserId = new SelectList(db.Students, "ApplicationUserId", "FName", completedCourse.ApplicationUserId);
            return View(completedCourse);
        }

        // GET: CompletedCourses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompletedCourse completedCourse = db.CompletedCourses.Find(id);
            if (completedCourse == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseCode", completedCourse.CourseId);
            ViewBag.ApplicationUserId = new SelectList(db.Students, "ApplicationUserId", "FName", completedCourse.ApplicationUserId);
            return View(completedCourse);
        }

        // POST: CompletedCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompleteId,CourseId,Passed,YearCompleted,SemesterCompleted,ApplicationUserId")] CompletedCourse completedCourse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(completedCourse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseCode", completedCourse.CourseId);
            ViewBag.ApplicationUserId = new SelectList(db.Students, "ApplicationUserId", "FName", completedCourse.ApplicationUserId);
            return View(completedCourse);
        }

        // GET: CompletedCourses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompletedCourse completedCourse = db.CompletedCourses.Find(id);
            if (completedCourse == null)
            {
                return HttpNotFound();
            }
            return View(completedCourse);
        }

        // POST: CompletedCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompletedCourse completedCourse = db.CompletedCourses.Find(id);
            db.CompletedCourses.Remove(completedCourse);
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
