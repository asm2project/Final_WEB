using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FPTModel;

namespace FPTModel.Controllers
{
    public class TrainningStaffController : Controller
    {
        private ASMWEBEntities3 db = new ASMWEBEntities3();

        // GET: TrainningStaff
        public ActionResult Index()
        {
            var couse_Cat = db.Couse_Cat.Include(c => c.Cours).Include(c => c.Role).Include(c => c.User);
            return View(couse_Cat.ToList());
        }

        // GET: TrainningStaff/Details/5
        
        // GET: TrainningStaff/Create
        public ActionResult Create()
        {
            ViewBag.Couse_ID = new SelectList(db.Courses, "Couse_ID", "CouseName");
            ViewBag.Role_id = new SelectList(db.Roles, "Role_id", "Role_name");
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Fullname");
            return View();
        }

        // POST: TrainningStaff/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CC_ID,UserID,Couse_ID,Role_id")] Couse_Cat couse_Cat)
        {
            if (ModelState.IsValid)
            {
                db.Couse_Cat.Add(couse_Cat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Couse_ID = new SelectList(db.Courses, "Couse_ID", "CouseName", couse_Cat.Couse_ID);
          
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Fullname", couse_Cat.UserID);
            return View(couse_Cat);
        }

        // GET: TrainningStaff/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Couse_Cat couse_Cat = db.Couse_Cat.Find(id);
            if (couse_Cat == null)
            {
                return HttpNotFound();
            }
            ViewBag.Couse_ID = new SelectList(db.Courses, "Couse_ID", "CouseName", couse_Cat.Couse_ID);
            
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Fullname", couse_Cat.UserID);
            return View(couse_Cat);
        }

        // POST: TrainningStaff/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CC_ID,UserID,Couse_ID,Role_id")] Couse_Cat couse_Cat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(couse_Cat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Couse_ID = new SelectList(db.Courses, "Couse_ID", "CouseName", couse_Cat.Couse_ID);
            
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Fullname", couse_Cat.UserID);
            return View(couse_Cat);
        }

        // GET: TrainningStaff/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Couse_Cat couse_Cat = db.Couse_Cat.Find(id);
            if (couse_Cat == null)
            {
                return HttpNotFound();
            }
            return View(couse_Cat);
        }

        // POST: TrainningStaff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Couse_Cat couse_Cat = db.Couse_Cat.Find(id);
            db.Couse_Cat.Remove(couse_Cat);
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
