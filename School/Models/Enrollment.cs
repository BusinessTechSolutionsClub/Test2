using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Models
{
    public enum Grade
    {
        A, B, C, D, F, W, I, P
    }

    public class Enrollment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }   // ? means is nullable.  Able to have null value

        // Navigation properties
        public virtual Course Course { get; set; }      // Enrollment can have 1 Course
        public virtual Student Student { get; set; }    // Enrollment can have 1 Student
    }
}