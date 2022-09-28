using System;
using System.Collections.Generic;

#nullable disable

namespace Module4Que25.DBM
{
    public partial class HospitalTable
    {
        public HospitalTable()
        {
            DoctorTables = new HashSet<DoctorTable>();
        }

        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string HospitalProfileimg { get; set; }
        public string HospitalAdd { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public string HospitalMail { get; set; }
        public string HospitalPass { get; set; }
        public string HospitalContact { get; set; }

        public virtual CityTable City { get; set; }
        public virtual StateTable State { get; set; }
        public virtual ICollection<DoctorTable> DoctorTables { get; set; }
    }
}
