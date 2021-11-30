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
    public class XuatHangController : Controller
    {
        private QLKDbContext db = new QLKDbContext();

        // GET: XuatHang
        public ActionResult Index()
        {
            return View(db.XuatHangs.ToList());
        }

        // GET: XuatHang/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XuatHang xuatHang = db.XuatHangs.Find(id);
            if (xuatHang == null)
            {
                return HttpNotFound();
            }
            return View(xuatHang);
        }

        // GET: XuatHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: XuatHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHang,TenHang,SoLuong,NhaSX")] XuatHang xuatHang)
        {
            if (ModelState.IsValid)
            {
                db.XuatHangs.Add(xuatHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(xuatHang);
        }

        // GET: XuatHang/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XuatHang xuatHang = db.XuatHangs.Find(id);
            if (xuatHang == null)
            {
                return HttpNotFound();
            }
            return View(xuatHang);
        }

        // POST: XuatHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHang,TenHang,SoLuong,NhaSX")] XuatHang xuatHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(xuatHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(xuatHang);
        }

        // GET: XuatHang/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XuatHang xuatHang = db.XuatHangs.Find(id);
            if (xuatHang == null)
            {
                return HttpNotFound();
            }
            return View(xuatHang);
        }

        // POST: XuatHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            XuatHang xuatHang = db.XuatHangs.Find(id);
            db.XuatHangs.Remove(xuatHang);
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
