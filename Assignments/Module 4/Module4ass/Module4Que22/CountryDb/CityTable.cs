using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;

#nullable disable

namespace Module4Que22.CountryDb
{
    public partial class CityTable
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? StateId { get; set; }

        [BindNever]
        public int? CountryId { get; set; }


        public virtual CountryTable Country { get; set; }
        public virtual StateTable State { get; set; }
    }
}
