using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Module5.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}
