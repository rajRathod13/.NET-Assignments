using System;
using System.Collections.Generic;

#nullable disable

namespace Module4Que25.DBM
{
    public partial class CityTable
    {
        public CityTable()
        {
            HospitalTables = new HashSet<HospitalTable>();
            PatientTables = new HashSet<PatientTable>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? StateId { get; set; }

        public virtual StateTable State { get; set; }
        public virtual ICollection<HospitalTable> HospitalTables { get; set; }
        public virtual ICollection<PatientTable> PatientTables { get; set; }
    }
}
