using System;
using System.Collections.Generic;

#nullable disable

namespace Module4Que25.DBM
{
    public partial class DoctorTable
    {
        public int DoctorId { get; set; }
        public string DoctorFname { get; set; }
        public string DoctorLname { get; set; }
        public string DoctorMail { get; set; }
        public string DoctorPass { get; set; }
        public string DoctorContact { get; set; }
        public string DoctorProfileimg { get; set; }
        public string DoctorDegree { get; set; }
        public string DoctorSpeciality { get; set; }
        public int? HospitalId { get; set; }

        public virtual HospitalTable Hospital { get; set; }
    }
}
