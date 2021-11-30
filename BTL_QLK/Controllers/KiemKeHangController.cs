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
    public class KiemKeHangController : Controller
    {
        private QLKDbContext db = new QLKDbContext();

        // GET: KiemKeHang
        public ActionResult Index()
        {
            return View(db.KiemKeHangs.ToList());
        }

        // GET: KiemKeHang/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KiemKeHang kiemKeHang = db.KiemKeHangs.Find(id);
            if (kiemKeHang == null)
            {
                return HttpNotFound();
            }
            return View(kiemKeHang);
        }

        // GET: KiemKeHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KiemKeHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHang,TenHang,SoLuong,NhaSX,TinhTrang,DonGia")] KiemKeHang kiemKeHang)
        {
            if (ModelState.IsValid)
            {
                db.KiemKeHangs.Add(kiemKeHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kiemKeHang);
        }

        // GET: KiemKeHang/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KiemKeHang kiemKeHang = db.KiemKeHangs.Find(id);
            if (kiemKeHang == null)
            {
                return HttpNotFound();
            }
            return View(kiemKeHang);
        }

        // POST: KiemKeHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHang,TenHang,SoLuong,NhaSX,TinhTrang,DonGia")] KiemKeHang kiemKeHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kiemKeHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kiemKeHang);
        }

        // GET: KiemKeHang/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KiemKeHang kiemKeHang = db.KiemKeHangs.Find(id);
            if (kiemKeHang == null)
            {
                return HttpNotFound();
            }
            return View(kiemKeHang);
        }

        // POST: KiemKeHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KiemKeHang kiemKeHang = db.KiemKeHangs.Find(id);
            db.KiemKeHangs.Remove(kiemKeHang);
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
