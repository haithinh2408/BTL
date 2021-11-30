using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTL_QLK.Models;

namespace BTL_QLK.Controllers
{
    public class NhapHangController : Controller
    {
        private QLKDbContext db = new QLKDbContext();

        // GET: NhapHang
        public ActionResult Index()
        {
            return View(db.NhapHangs.ToList());
        }

        // GET: NhapHang/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhapHang nhapHang = db.NhapHangs.Find(id);
            if (nhapHang == null)
            {
                return HttpNotFound();
            }
            return View(nhapHang);
        }

        // GET: NhapHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhapHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHang,TenHang,SoLuong,NhaSX")] NhapHang nhapHang)
        {
            if (ModelState.IsValid)
            {
                db.NhapHangs.Add(nhapHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhapHang);
        }

        // GET: NhapHang/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhapHang nhapHang = db.NhapHangs.Find(id);
            if (nhapHang == null)
            {
                return HttpNotFound();
            }
            return View(nhapHang);
        }

        // POST: NhapHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHang,TenHang,SoLuong,NhaSX")] NhapHang nhapHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhapHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhapHang);
        }

        // GET: NhapHang/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhapHang nhapHang = db.NhapHangs.Find(id);
            if (nhapHang == null)
            {
                return HttpNotFound();
            }
            return View(nhapHang);
        }

        // POST: NhapHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NhapHang nhapHang = db.NhapHangs.Find(id);
            db.NhapHangs.Remove(nhapHang);
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
