using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystem.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int TeacherID { get; set; } // Foreign key to Teacher
        public Teacher Teacher { get; set; } // Navigation property to Teacher
        public ICollection<StudentCourse> StudentCourses { get; set; } // Many-to-many navigation property
        public ICollection<Exam> Exams { get; set; }  // One-to-many with Exam

    }
}
