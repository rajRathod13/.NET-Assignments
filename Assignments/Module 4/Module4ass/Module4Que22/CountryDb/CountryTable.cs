using System;
using System.Collections.Generic;

#nullable disable

namespace Module4Que22.CountryDb
{
    public partial class CountryTable
    {
        public CountryTable()
        {
            CityTables = new HashSet<CityTable>();
            StateTables = new HashSet<StateTable>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<CityTable> CityTables { get; set; }
        public virtual ICollection<StateTable> StateTables { get; set; }
    }
}
