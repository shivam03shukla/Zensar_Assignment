using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class movietableController : Controller
    {
        private moviedatabaseEntities db = new moviedatabaseEntities();

        // GET: movietable
        public ActionResult Index()
        {
            return View(db.movietables.ToList());
        }

        // GET: movietable/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            movietable movietable = db.movietables.Find(id);
            if (movietable == null)
            {
                return HttpNotFound();
            }
            return View(movietable);
        }
        [HttpGet]
        public async Task<ActionResult>Index(string Empsearch)
        {
            ViewData["Getmoviedate"] = Empsearch;
            var empquery = from x in db.movietables select x;
            if(!string.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x => x.moviename.Contains(
                      Empsearch) || x.dateofrelease.Contains(Empsearch));
            }
            return View(await empquery.AsNoTracking().ToListAsync());
        }

        // GET: movietable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: movietable/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "mid,moviename,dateofrelease")] movietable movietable)
        {
            if (ModelState.IsValid)
            {
                db.movietables.Add(movietable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movietable);
        }

        // GET: movietable/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            movietable movietable = db.movietables.Find(id);
            if (movietable == null)
            {
                return HttpNotFound();
            }
            return View(movietable);
        }

        // POST: movietable/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "mid,moviename,dateofrelease")] movietable movietable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movietable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movietable);
        }

        // GET: movietable/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            movietable movietable = db.movietables.Find(id);
            if (movietable == null)
            {
                return HttpNotFound();
            }
            return View(movietable);
        }

        // POST: movietable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            movietable movietable = db.movietables.Find(id);
            db.movietables.Remove(movietable);
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
