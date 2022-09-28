using System;
using System.Collections.Generic;

#nullable disable

namespace Module4Que25.DBM
{
    public partial class StateTable
    {
        public StateTable()
        {
            CityTables = new HashSet<CityTable>();
            HospitalTables = new HashSet<HospitalTable>();
            PatientTables = new HashSet<PatientTable>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<CityTable> CityTables { get; set; }
        public virtual ICollection<HospitalTable> HospitalTables { get; set; }
        public virtual ICollection<PatientTable> PatientTables { get; set; }
    }
}
