using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Module4Que19.CountryDB
{
    public partial class CityTable
    {
        public int CityId { get; set; }

        [Required(ErrorMessage ="City name required..!!")]
        public string CityName { get; set; }

        [Required(ErrorMessage ="Please fill..!!")]
        public int? StateId { get; set; }

        [Required(ErrorMessage = "Please fill..!!")]
        public int? CountryId { get; set; }

        public virtual CountryTable Country { get; set; }
        public virtual StateTable State { get; set; }
    }
}
