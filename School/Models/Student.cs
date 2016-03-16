using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public virtual Users User { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }    // Student can have many enrollments
    }
}