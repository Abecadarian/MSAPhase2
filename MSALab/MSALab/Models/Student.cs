using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MSALab.Models
{
    public class Student
    {

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Password { get; set; }
        public DateTime EnrollmentDate { get; set; }


        [JsonIgnore]
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}