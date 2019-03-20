using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SkriptPrototyp.Models;

namespace SkriptPrototyp.Controllers
{
    public class SkriptsController : Controller
    {
        private SkriptDBContext db = new SkriptDBContext();

        /*  //Returns all Skripts
          // GET: Skripts
          public ActionResult Index()
          {
              return View(db.Skripte.ToList());
          } */

        //Returns all Skripts with search function
        // GET: Skripts
        public ActionResult Index(string searchString)
        {
            var skripts = from m in db.Skripte select m;
            if (!String.IsNullOrEmpty(searchString))
            { skripts = skripts.Where(s => s.Status.Contains(searchString)); }

            return View(skripts);
        }

        //Return the Skript with {ID}
        // GET: Skripts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skript skript = db.Skripte.Find(id);
            if (skript == null)
            {
                return HttpNotFound();
            }
            return View(skript);
        }

        // GET: Skripts/Create
        public ActionResult Create()
        {
            return View();
        }


        //Add a new Skript
        // POST: Skripts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Displayname,Discription,Status")] Skript skript)
        {
            if (ModelState.IsValid)
            {
                db.Skripte.Add(skript);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skript);
        }

        // GET: Skripts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skript skript = db.Skripte.Find(id);
            if (skript == null)
            {
                return HttpNotFound();
            }
            return View(skript);
        }

        // POST: Skripts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Displayname,Discription,Status")] Skript skript)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skript).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skript);
        }

        // GET: Skripts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skript skript = db.Skripte.Find(id);
            if (skript == null)
            {
                return HttpNotFound();
            }
            return View(skript);
        }

        // POST: Skripts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Skript skript = db.Skripte.Find(id);
            db.Skripte.Remove(skript);
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
