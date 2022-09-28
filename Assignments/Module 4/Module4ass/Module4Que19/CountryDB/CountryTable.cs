using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Module4Que19.CountryDB
{
    public partial class CountryTable
    {
        public CountryTable()
        {
            CityTables = new HashSet<CityTable>();
            StateTables = new HashSet<StateTable>();
        }

        public int CountryId { get; set; }


        [Required(ErrorMessage ="Country name required..!!")]
        public string CountryName { get; set; }

        public virtual ICollection<CityTable> CityTables { get; set; }
        public virtual ICollection<StateTable> StateTables { get; set; }
    }
}
