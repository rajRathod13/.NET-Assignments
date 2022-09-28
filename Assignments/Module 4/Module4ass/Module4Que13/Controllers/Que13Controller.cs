using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module4Que13.Controllers
{
    public class Que13Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowMsg()
        {
            ViewBag.msg = "This msg is from ViewBag";
            TempData["data"] = "This msg from Temp data";
            return View();
        }

        public IActionResult AnotherView()
        {
            return View();
        }
    }
}
