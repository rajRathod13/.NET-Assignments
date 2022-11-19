using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Que8.Data;
using Que8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Que8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase

    {
        private ApiContext _context;
        public MasterController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEmp()
        {
            _context.emps.ToList();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSingleEmp(int id)
        {
            _context.emps.Find(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddEmp(EmpData emp)
        {
            if(emp != null)
            {
                _context.emps.Add(emp);
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult EditEmp(int id)
        {
            var model = _context.emps.Find(id);
            if(model == null)
            {
                return BadRequest();
            }
            _context.emps.Update(model);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmp(int id)
        {
                var model = _context.emps.Find(id);
                if (model != null)
                {
                    _context.emps.Remove(model);
                    _context.SaveChanges();
                    return Ok();
                }
            return BadRequest();
        }
    }
    
}
