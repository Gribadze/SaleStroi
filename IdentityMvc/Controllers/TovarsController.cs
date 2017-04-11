using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IdentityMvc.Models;

namespace IdentityMvc.Controllers
{
    public class TovarsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tovars
        public ActionResult Index()
        {
            return View(db.Tovars.ToList());
        }

        // GET: Tovars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tovar tovar = db.Tovars.Find(id);
            if (tovar == null)
            {
                return HttpNotFound();
            }
            return View(tovar);
        }

        // GET: Tovars/Create
        [Authorize(Roles ="admin, moder")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tovars/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, moder")]
        public ActionResult Create([Bind(Include = "Id,TovarName,Quantity,Price,Def")] Tovar tovar)
        {
            if (ModelState.IsValid)
            {
                db.Tovars.Add(tovar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tovar);
        }

        // GET: Tovars/Edit/5
        [Authorize(Roles = "admin, moder")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tovar tovar = db.Tovars.Find(id);
            if (tovar == null)
            {
                return HttpNotFound();
            }
            return View(tovar);
        }

        // POST: Tovars/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, moder")]
        public ActionResult Edit([Bind(Include = "Id,TovarName,Quantity,Price,Def")] Tovar tovar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tovar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tovar);
        }

        // GET: Tovars/Delete/5
        [Authorize(Roles = "admin, moder")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tovar tovar = db.Tovars.Find(id);
            if (tovar == null)
            {
                return HttpNotFound();
            }
            return View(tovar);
        }

        // POST: Tovars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, moder")]
        public ActionResult DeleteConfirmed(int id)
        {
            Tovar tovar = db.Tovars.Find(id);
            db.Tovars.Remove(tovar);
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
