using NguyenHoangLinh_QLBanhangMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NguyenHoangLinh_QLBanhangMVC.Controllers
{
    public class DanhMucSanPhamController : Controller
    {
        QuanLyBanHangModel db = new QuanLyBanHangModel();
        // GET: DanhMucSanPham
        public ActionResult Index(string searchString)
        {
            // lấy toàn bộ danh sáchz
            var listDanhMuc = db.DanhMucSanPhams.ToList();
            return View( listDanhMuc);
        }

        // GET: DanhMucSanPham/Details/5
        public ActionResult Details(int id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucSanPham danhmucsanpham = db.DanhMucSanPhams.Find(id);
            if (danhmucsanpham == null)
            {
                return HttpNotFound();
            }
            return View(danhmucsanpham);
        }

        // GET: DanhMucSanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DanhMucSanPham/Create
        [HttpPost]
        public ActionResult Create(DanhMucSanPham dataForm)
        {
            try
            {
                // TODO: Add insert logic here
                db.DanhMucSanPhams.Add(dataForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DanhMucSanPham/Edit/5
        public ActionResult Edit(int id)
        {
            if ( id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var dataEdit = db.DanhMucSanPhams.Find(id);
            if (dataEdit == null)
            {
                return HttpNotFound();
            }

            return View( dataEdit);
        }

        // POST: DanhMucSanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DanhMucSanPham dataForm)
        {
            try
            {
                // TODO: Add update logic here
                var dataEdit = db.DanhMucSanPhams.Find(id);
                dataEdit.TenDanhMuc = dataForm.TenDanhMuc;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DanhMucSanPham/Delete/5
        public ActionResult Delete(int id)
        {
            if ( id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var dataDelete = db.DanhMucSanPhams.Find(id);
            if (dataDelete == null)
            {
                return HttpNotFound();
                    
            }
            return View(dataDelete);
        }

        // POST: DanhMucSanPham/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var dataDelete = db.DanhMucSanPhams.Find(id);
                db.DanhMucSanPhams.Remove(dataDelete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
