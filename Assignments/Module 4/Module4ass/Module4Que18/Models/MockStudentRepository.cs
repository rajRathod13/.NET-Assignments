using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module4Que18.Models
{
    public class MockStudentRepository : StudentRepository
    {
        private List<Student> _studentDetails = new List<Student>();
        public MockStudentRepository()
        {
            _studentDetails.Add(new Student() { FirstName = "Raj", LastName = "Rathod", EmailId ="r.k.rathod@gmail.com",Mobile_No="7878454512",Gender="Male",City="Surat",
                Address="Surat",Courses="Full Stack Development",Fees= 70000,Tax=18,Total_Fees=75000            
            });
        }

        public Student GetData()
        {
            throw new NotImplementedException();
        }
    }
}
