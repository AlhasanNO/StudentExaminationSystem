using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentExaminationSystem.Models;

namespace StudentExaminationSystem
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        // Foreign Key for Course
        public int CourseID { get; set; }
        public Course Course { get; set; }

        // many-to-many relationship with Student
        public ICollection<StudentExam> StudentExams { get; set; }

        //  one-to-many relationship with Question
        public ICollection<Question> Questions { get; set; }
    }
}
