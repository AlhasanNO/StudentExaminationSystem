using StudentExaminationSystem.Forms.AdminForms;
using StudentExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystem
{
    public partial class Login : Form
    {
     
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string username = textBox1.Text;
            string password = textBox2.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (var context = new AppDbContext())
            {
           
                Teacher teacher = context.Teachers
                    .FirstOrDefault(t => t.Name == username && t.Password == password);

                Student student = context.Students
                    .FirstOrDefault(s => s.Name == username && s.Password == password);

                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    AdminDashboard AdminDathboard = new AdminDashboard();
                    AdminDathboard.Show();
                    this.Hide();
                    return;
                }
               else if (teacher != null)
                {
                    MessageBox.Show($"Welcome {teacher.Name}, you are logged in as Teacher.");
                    TeacherDashboard teacherForm = new TeacherDashboard(teacher.Id);
                    teacherForm.Show();
                    this.Hide();
                }

                else if (student != null)
                {
                    MessageBox.Show($"Welcome {student.Name}, you are logged in as Student.");
                    StudentDashboard studentForm = new StudentDashboard(student.Id);
                    
                    studentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
        }
    }
}