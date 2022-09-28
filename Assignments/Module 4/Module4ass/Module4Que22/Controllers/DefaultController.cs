using Microsoft.AspNetCore.Mvc;
using Module4Que22.CountryDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module4Que22.Controllers
{
    public class DefaultController : Controller
    {
        private CountryContext _context = null;

        public DefaultController(CountryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewState()
        {
            return View(_context.StateTables.ToList());
        }
        public IActionResult AddState()
        {
            return View();
        }
        public IActionResult ViewCity()
        {
            return View(_context.CityTables.ToList());
        }
        public IActionResult Edit(int id)
        {
            return View(_context.CityTables.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(CityTable obj)
        {
            _context.CityTables.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("ViewCity");
        }
    }
}
