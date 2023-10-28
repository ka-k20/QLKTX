using QLKTX.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKTX.Areas.Admin.Controllers
{
    public class NVController : Controller
    {
        private QLKTXDBContext _dbConect = new QLKTXDBContext();
        // GET: Admin/NV
        public ActionResult Index()
        {
            var items = _dbConect.NhanVien;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                _dbConect.NhanVien.Add(nhanVien);
                _dbConect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhanVien);
        }
        public ActionResult Edit(int idnv)
        {
            var item = _dbConect.NhanVien.Find(idnv);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                _dbConect.NhanVien.Attach(nhanVien);
                //_dbConect.Entry(nhanVien).Property(x => x.MaNV).IsModified = true;
                _dbConect.Entry(nhanVien).Property(x => x.HoTenNV).IsModified = true;
                _dbConect.Entry(nhanVien).Property(x => x.DiaChi).IsModified = true;
                _dbConect.Entry(nhanVien).Property(x => x.SDT).IsModified = true;
                _dbConect.Entry(nhanVien).Property(x => x.Email).IsModified = true;
                _dbConect.Entry(nhanVien).Property(x => x.CCCD).IsModified = true;
                _dbConect.Entry(nhanVien).Property(x => x.GioiTinh).IsModified = true;
                _dbConect.Entry(nhanVien).Property(x => x.NgaySinh).IsModified = true;
                _dbConect.Entry(nhanVien).Property(x => x.ChucVu).IsModified = true;
                _dbConect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhanVien);
        }
        [HttpPost]
        public ActionResult Delete(int idnv)
        {
            var item = _dbConect.NhanVien.Find(idnv);
            if (item != null)
            {
                _dbConect.NhanVien.Remove(item);
                _dbConect.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}