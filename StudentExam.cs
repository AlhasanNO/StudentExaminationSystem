using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentExaminationSystem.Models;

namespace StudentExaminationSystem
{
    public class StudentExam
    {
        public int StudentID { get; set; } 
        public Student Student { get; set; }

        public int ExamID { get; set; } 
        public Exam Exam { get; set; }

        public double? Result { get; set; } 
    }
}
