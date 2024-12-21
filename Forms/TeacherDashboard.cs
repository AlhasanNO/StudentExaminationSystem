using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentExaminationSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentExaminationSystem
{
    public partial class TeacherDashboard : Form
    {
        private int teacherId;
        private int selectedExamId;
        public TeacherDashboard(int id)
        {
            InitializeComponent();
            teacherId = id;
            label12.Text = teacherId.ToString();
            ShowAssignedCourses();
            ShowExamsForAssignedCourses();
            DisplayStudentResults();
        }


        private void ShowAssignedCourses()
        {
            try
            {
                using (var context = new AppDbContext())
                {

                    var data = from course in context.Courses
                               where course.TeacherID == teacherId
                               select new
                               {
                                   CourseID = course.ID,
                                   CourseName = course.Name,
                                   CourseDescription = course.Description,
                                   Level = course.Level,
                                   TeacherName = context.Teachers
                                                       .Where(t => t.Id == course.TeacherID)
                                                       .Select(t => t.Name).FirstOrDefault()
                               };


                    dataGridView1.DataSource = data.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ShowExamsForAssignedCourses()
        {
            try
            {
                using (var context = new AppDbContext())
                {

                    var data = from exam in context.Exams
                               join course in context.Courses on exam.CourseID equals course.ID
                               where course.TeacherID == teacherId
                               select new
                               {
                                   ExamID = exam.Id,
                                   ExamName = exam.Name,
                                   CourseID = course.ID,
                                   ExamDescription = exam.Description,
                                   ExamDate = exam.Date,
                                   StartTime = exam.StartTime,
                                   EndTime = exam.EndTime,
                                   CourseName = course.Name
                               };


                    dataGridView2.DataSource = data.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void DisplayQuestionsForSelectedExam()
        {
            try
            {
                using (var context = new AppDbContext())
                {

                    var data = from question in context.Questions
                               where question.ExamID == selectedExamId
                               select new
                               {
                                   QuestionID = question.ID,
                                   Text = question.Text,
                                   Choice1 = question.Choice1,
                                   Choice2 = question.Choice2,
                                   Choice3 = question.Choice3,
                                   Choice4 = question.Choice4,
                                   Answer = question.Answer
                               };


                    dataGridView3.DataSource = data.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DisplayStudentResults()
        {
            try
            {
                using (var context = new AppDbContext())
                {
             
                    var data = from Result in context.StudentExams
                               join student in context.Students on Result.StudentID equals student.Id
                               join exam in context.Exams on Result.ExamID equals exam.Id
                               join course in context.Courses on exam.CourseID equals course.ID
                               select new
                               {
                                   StudentName = student.Name,
                                   ExamName = exam.Description,
                                   CourseName = course.Name,
                                   ResultScore = Result.Result,
                                   ResultID = Result.StudentID
                               };

         
                    dataGridView4.DataSource = data.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an exam first.");
                return;
            }


            DataGridViewRow selectedRow = dataGridView2.CurrentRow;


            if (selectedRow.Cells["ExamID"].Value == null || selectedRow.Cells["ExamID"].Value == DBNull.Value)
            {
                MessageBox.Show("Please select a valid exam.");
                return;
            }

            selectedExamId = Convert.ToInt32(selectedRow.Cells["ExamID"].Value);


            string questionText = textBox1.Text.Trim();
            string choice1 = textBox2.Text.Trim();
            string choice2 = textBox3.Text.Trim();
            string choice3 = textBox4.Text.Trim();
            string choice4 = textBox5.Text.Trim();
            string answer = textBox6.Text.Trim();


            if (string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(choice1) ||
                string.IsNullOrEmpty(choice2) || string.IsNullOrEmpty(choice3) ||
                string.IsNullOrEmpty(choice4) || string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {

                    var newQuestion = new Question
                    {
                        Text = questionText,
                        Choice1 = choice1,
                        Choice2 = choice2,
                        Choice3 = choice3,
                        Choice4 = choice4,
                        Answer = answer,
                        ExamID = selectedExamId
                    };


                    context.Questions.Add(newQuestion);
                    context.SaveChanges();
                    DisplayQuestionsForSelectedExam();

                    MessageBox.Show("Question added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView2_CellContentClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        
        }
    }
}
