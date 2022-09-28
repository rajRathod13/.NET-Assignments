using Microsoft.AspNetCore.Mvc;
using Module4Validation.EMDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module4Validation.Controllers
{
    public class DefaultController : Controller
    {
        private emplContext _db = null;

        public DefaultController(emplContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EmployeeList()
        {
            return View(_db.Emdtables.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Emdtable obj)
        {
            _db.Emdtables.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("EmployeeList");
        }
    }
}
