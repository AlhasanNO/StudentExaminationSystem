using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystem.Models
{
    public class Teacher : User
    {
        public string College { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
