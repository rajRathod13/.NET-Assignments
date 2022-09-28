using System;
using System.Collections.Generic;

#nullable disable

namespace Module4Que25.DBM
{
    public partial class PatientTable
    {
        public int PatientId { get; set; }
        public string PatientFname { get; set; }
        public string PatientLname { get; set; }
        public string PatientMail { get; set; }
        public string PatientPass { get; set; }
        public string PatientContact { get; set; }
        public string PatientDob { get; set; }
        public string PatientAdd { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }

        public virtual CityTable City { get; set; }
        public virtual StateTable State { get; set; }
    }
}
