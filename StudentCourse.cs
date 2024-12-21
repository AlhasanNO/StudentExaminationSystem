using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentExaminationSystem.Models;

namespace StudentExaminationSystem
{
    public class StudentCourse
    {
        public int StudentID { get; set; }  // Foreign key to Student
        public Student Student { get; set; } // Navigation property to Student

        public int CourseID { get; set; }    // Foreign key to Course
        public Course Course { get; set; }  // Navigation property to Course
    }
}
