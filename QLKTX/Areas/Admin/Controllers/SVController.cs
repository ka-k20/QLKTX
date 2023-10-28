using QLKTX.Models;
using QLKTX.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKTX.Areas.Admin.Controllers
{

   
    public class SVController : Controller
    {
        private QLKTXDBContext _dbConect = new QLKTXDBContext();
        // GET: Admin/SV
        public ActionResult Index()
        {
            var items = _dbConect.SinhVien;
            return View(items);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                _dbConect.SinhVien.Add(sinhVien);
                _dbConect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sinhVien);
        }
        public ActionResult Edit( string id)
        {
            var item = _dbConect.SinhVien.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                _dbConect.SinhVien.Attach(sinhVien);
                _dbConect.Entry(sinhVien).Property(x => x.MaSV).IsModified = true;
                _dbConect.Entry(sinhVien).Property(x => x.HoTen).IsModified = true;
                _dbConect.Entry(sinhVien).Property(x => x.Khoa).IsModified = true;
                _dbConect.Entry(sinhVien).Property(x => x.Lop).IsModified = true;
                _dbConect.Entry(sinhVien).Property(x => x.NgaySinh).IsModified = true;
                _dbConect.Entry(sinhVien).Property(x => x.GioiTinh).IsModified = true;
                _dbConect.Entry(sinhVien).Property(x => x.SDT).IsModified = true;
                _dbConect.Entry(sinhVien).Property(x => x.Email).IsModified = true;
                _dbConect.Entry(sinhVien).Property(x => x.CCCD).IsModified = true;
                //_dbConect.SinhVien.Add(sinhVien);
                _dbConect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sinhVien);
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            var item = _dbConect.SinhVien.Find(id);
            if( item != null)
            {
                //var DeleteItem = _dbConect.SinhVien.Attach(item);

                _dbConect.SinhVien.Remove(item);
                _dbConect.SaveChanges();
                return Json(new { success = true });

            }    
            return Json(new { success = false });
        }
    }
}