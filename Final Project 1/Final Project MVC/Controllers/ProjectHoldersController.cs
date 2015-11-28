using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Final_Project_MVC.Models;

namespace Final_Project_MVC.Controllers
{
    public class ProjectHoldersController : Controller
    {
        private Final_Project_1Entities db = new Final_Project_1Entities();

        // GET: ProjectHolders
        public ActionResult Index()
        {
            return View(db.ProjectHolders.ToList());
        }

        // GET: ProjectHolders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectHolder projectHolder = db.ProjectHolders.Find(id);
            if (projectHolder == null)
            {
                return HttpNotFound();
            }
            return View(projectHolder);
        }

        // GET: ProjectHolders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectHolders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ProjectDescription,Screenshot,LinkToRepository,LanguagesUsed")] ProjectHolder projectHolder)
        {
            if (ModelState.IsValid)
            {
                db.ProjectHolders.Add(projectHolder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectHolder);
        }

        // GET: ProjectHolders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectHolder projectHolder = db.ProjectHolders.Find(id);
            if (projectHolder == null)
            {
                return HttpNotFound();
            }
            return View(projectHolder);
        }

        // POST: ProjectHolders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ProjectDescription,Screenshot,LinkToRepository,LanguagesUsed")] ProjectHolder projectHolder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectHolder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectHolder);
        }

        // GET: ProjectHolders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectHolder projectHolder = db.ProjectHolders.Find(id);
            if (projectHolder == null)
            {
                return HttpNotFound();
            }
            return View(projectHolder);
        }

        // POST: ProjectHolders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectHolder projectHolder = db.ProjectHolders.Find(id);
            db.ProjectHolders.Remove(projectHolder);
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
