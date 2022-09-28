using Microsoft.AspNetCore.Mvc;
using Module4Que19.CountryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module4Que19.Controllers
{
    public class DefaultController : Controller
    {
        private CountryContext _countryContext = null;

        public DefaultController(CountryContext countryContext)
        {
            _countryContext = countryContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewCountry()
        {
            return View(_countryContext.CountryTables.ToList());
        }
        public IActionResult AddCountry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCountry(CountryTable obj)
        {
            _countryContext.CountryTables.Add(obj);
            _countryContext.SaveChanges();
            return RedirectToAction("ViewCountry");
        }

        public IActionResult ViewCity()
        {
            return View(_countryContext.CityTables.ToList());
        }

        public IActionResult AddCity()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddCity(CityTable obj)
        {
            _countryContext.CityTables.Add(obj);
            _countryContext.SaveChanges();
            return RedirectToAction("ViewCity");
        }
    }
}
