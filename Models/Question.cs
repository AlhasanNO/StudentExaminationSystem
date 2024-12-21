using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystem.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string Choice1 { get; set; }
        public string Choice2 { get; set; }
        public string Choice3 { get; set; }
        public string Choice4 { get; set; }
        public string Answer { get; set; }

        // Foreign Key for Exam
        public int ExamID { get; set; }
        public Exam Exam { get; set; }
    }
}
