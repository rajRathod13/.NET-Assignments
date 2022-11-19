using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Module5.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }
    }
}
