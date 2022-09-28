using System;
using System.Collections.Generic;

#nullable disable

namespace Module4Que19.CountryDB
{
    public partial class StateTable
    {
        public StateTable()
        {
            CityTables = new HashSet<CityTable>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }
        public int? CountryId { get; set; }

        public virtual CountryTable Country { get; set; }
        public virtual ICollection<CityTable> CityTables { get; set; }
    }
}
