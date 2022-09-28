using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module4ass.EMD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module4ass.Controllers
{
    public class DefaultController : Controller
    {
        private emplContext _emp = null;
        private readonly IHttpContextAccessor _contextAccessor;

        public DefaultController(emplContext emp,IHttpContextAccessor contextAccessor)
        {
            _emp = emp;
            _contextAccessor = contextAccessor;
        }
        public IActionResult EmployeeHome()
        {
            return View(_emp.Emdtables.ToList());
        }

        //Module 4 --> Que 7,
       public IActionResult EmployeeData()
        {
            return View(_emp.Emdtables.ToList());
        }

        public IActionResult GetData()
        {
            return View(_emp.Emdtables.ToList());
        }

        //Module 4 --> Que 10,
        public IActionResult Login()
        {
            _contextAccessor.HttpContext.Session.SetString("uname", "Raj");
            return View();
        }
    }
}
