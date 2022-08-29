using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using template2.Models;

namespace template2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentInfo()
        {
            List<Student> li = new List<Student>();
            li.Add(new Student { Roll_no = 1, sName = "Rathod Raj", per = 78 });
            li.Add(new Student { Roll_no = 2, sName = "Nikunj Patel", per = 87 });
            li.Add(new Student { Roll_no = 3, sName = "Prashant Sharma", per = 88 });


            return View(li);
        }
    }
}
