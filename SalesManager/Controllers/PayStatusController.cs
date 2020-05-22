using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalesManager;

namespace SalesManager.Controllers
{
    public class PayStatusController : Controller
    {
        private Model1 db = new Model1();

        // GET: PayStatus
        public ActionResult Index()
        {
            return View(db.PayStatus.ToList());
        }

        // GET: PayStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayStatu payStatu = db.PayStatus.Find(id);
            if (payStatu == null)
            {
                return HttpNotFound();
            }
            return View(payStatu);
        }

        // GET: PayStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PayStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PayPercent,AccessInfo")] PayStatu payStatu)
        {
            if (ModelState.IsValid)
            {
                db.PayStatus.Add(payStatu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(payStatu);
        }

        // GET: PayStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayStatu payStatu = db.PayStatus.Find(id);
            if (payStatu == null)
            {
                return HttpNotFound();
            }
            return View(payStatu);
        }

        // POST: PayStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PayPercent,AccessInfo")] PayStatu payStatu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(payStatu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(payStatu);
        }

        // GET: PayStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayStatu payStatu = db.PayStatus.Find(id);
            if (payStatu == null)
            {
                return HttpNotFound();
            }
            return View(payStatu);
        }

        // POST: PayStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PayStatu payStatu = db.PayStatus.Find(id);
            db.PayStatus.Remove(payStatu);
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
