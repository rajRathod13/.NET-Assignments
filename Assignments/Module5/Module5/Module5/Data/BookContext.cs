using Microsoft.EntityFrameworkCore;
using Module5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module5.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
    }
}
