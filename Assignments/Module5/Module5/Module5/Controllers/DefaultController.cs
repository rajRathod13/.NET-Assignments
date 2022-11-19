using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Module5.Data;
using Module5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module5.Controllers
{
    public class DefaultController : Controller
    {
        private BookContext _context;
        public DefaultController(BookContext context)
        {
            _context = context;
        }
        public IActionResult GetAll()
        {
            var model = _context.books.Include(m => m.Author).ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public string Create(Book book)
        {
             _context.books.Add(book);
            _context.SaveChanges();
            return "Added Successfully";
        }
        public IActionResult Edit(int id)
        {
            var model = _context.books.Find(id);
            return View(model);
        }
        [HttpPost]
        public string Edit(Book book)
        {
            _context.books.Update(book);
            _context.SaveChanges();
            return "Updated Successfully";
        }

        public IActionResult Delete(int id)
        {
            var model = _context.books.Find(id);
            return View(model);
        }
        [HttpPost,ActionName("Delete")]
        public string SingleDelete(int id)
        {
            _context.books.Remove(_context.books.Find(id));
            _context.SaveChanges();
            return "Book Deleted";
        }

        public IActionResult GetAllAuthors()
        {
            var model = _context.authors.ToList();
            return View(model);
        }
        public IActionResult CreateAuthor()
        {
            return View();
        }
        [HttpPost]
        public string CreateAuthor(Author author)
        {
            _context.authors.Add(author);
            _context.SaveChanges();
            return "Author Added";
        }
    }
}
