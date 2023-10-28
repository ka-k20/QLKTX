using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using QLKTX.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKTX.Areas.Admin.Controllers
{
    public class RoleController : Controller
    {
        private QLKTXDBContext _dbConect = new QLKTXDBContext();

        // GET: Admin/Role
        public ActionResult Index()
        {
            var items = _dbConect.AspNetRoles.ToList();
            return View(items);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (IdentityRole identityRole)
        {
            if(ModelState.IsValid)
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_dbConect));
                roleManager.Create(identityRole);
                return RedirectToAction("Index");
            }   
            return View(identityRole);
        }
    }
}