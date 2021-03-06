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
    public class PhieuXuatHangsController : Controller
    {
        private QLKDbContext db = new QLKDbContext();

        // GET: PhieuXuatHangs
        public ActionResult Index()
        {
            return View(db.PhieuXuatHangs.ToList());
        }

        // GET: PhieuXuatHangs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuXuatHang phieuXuatHang = db.PhieuXuatHangs.Find(id);
            if (phieuXuatHang == null)
            {
                return HttpNotFound();
            }
            return View(phieuXuatHang);
        }

        // GET: PhieuXuatHangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhieuXuatHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSoPhieu,NguoiTao,NgayTao,MaHang,TenHang,SoLuong,NhaSX,LiDoXuat")] PhieuXuatHang phieuXuatHang)
        {
            if (ModelState.IsValid)
            {
                db.PhieuXuatHangs.Add(phieuXuatHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(phieuXuatHang);
        }

        // GET: PhieuXuatHangs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuXuatHang phieuXuatHang = db.PhieuXuatHangs.Find(id);
            if (phieuXuatHang == null)
            {
                return HttpNotFound();
            }
            return View(phieuXuatHang);
        }

        // POST: PhieuXuatHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSoPhieu,NguoiTao,NgayTao,MaHang,TenHang,SoLuong,NhaSX,LiDoXuat")] PhieuXuatHang phieuXuatHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuXuatHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phieuXuatHang);
        }

        // GET: PhieuXuatHangs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuXuatHang phieuXuatHang = db.PhieuXuatHangs.Find(id);
            if (phieuXuatHang == null)
            {
                return HttpNotFound();
            }
            return View(phieuXuatHang);
        }

        // POST: PhieuXuatHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PhieuXuatHang phieuXuatHang = db.PhieuXuatHangs.Find(id);
            db.PhieuXuatHangs.Remove(phieuXuatHang);
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
