using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Module4Validation.EMDB
{
    public partial class Emdtable
    {
        public int EmpId { get; set; }

        [Required(ErrorMessage ="Name required..!!")]
        public string EmpName { get; set; }

        [Required(ErrorMessage ="Age reqired..!!")]
        public string EmpAge { get; set; }

        [Required(ErrorMessage ="Mail id required..!!")]
        public string EmpMail { get; set; }

        [Required(ErrorMessage ="contact reqired..!!")]
        public string EmpContact { get; set; }
    }
}
