using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystem.Models
{
    public class Student : User
    {
        public string Speciality { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }  // Many-to-many 
        public ICollection<StudentExam> StudentExams { get; set; }     // Many-to-many 


    }
}
