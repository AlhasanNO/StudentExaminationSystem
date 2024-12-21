using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StudentExaminationSystem.Forms;

namespace StudentExaminationSystem
{


    public partial class StudentDashboard : Form
    {
        private int count = 0;
        private int studentId;
        private readonly AppDbContext _context;
        private readonly int _studentId;

        public StudentDashboard(int id)
        {
            InitializeComponent();
            studentId = id;
            label2.Text = studentId.ToString();
            ShowCourses();
            ShowRegisteredCourses();
            ShowExamsForRegisteredCourses();
            _context = new AppDbContext();
            _studentId = studentId;

        }

        private void ShowCourses()
        {
            using (var context = new AppDbContext())
            {

                var data = from course in context.Courses
                           join teacher in context.Teachers on course.TeacherID equals teacher.Id
                           select new
                           {
                               CourseID = course.ID,
                               CourseName = course.Name,
                               CourseDescription = course.Description,
                               Level = course.Level,
                               TeacherName = teacher.Name,
                               TeacherCollege = teacher.College
                           };


                dataGridView1.DataSource = data.ToList();
            }
        }

        private void ShowRegisteredCourses()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var registeredCourses = from studentCourse in context.StudentCourses
                                            join course in context.Courses on studentCourse.CourseID equals course.ID
                                            join teacher in context.Teachers on course.TeacherID equals teacher.Id
                                            where studentCourse.StudentID == studentId
                                            select new
                                            {
                                                StudentID = studentCourse.StudentID,
                                                CourseID = course.ID,
                                                CourseName = course.Name,
                                                TeacherName = teacher.Name,
                                                TeacherCollege = teacher.College
                                            };

                    dataGridView2.DataSource = registeredCourses.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        private void ShowExamsForRegisteredCourses()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var examsData = from studentCourse in context.StudentCourses
                                    join course in context.Courses on studentCourse.CourseID equals course.ID
                                    join exam in context.Exams on course.ID equals exam.CourseID
                                    where studentCourse.StudentID == studentId
                                    select new
                                    {
                                        ExamID = exam.Id,
                                        ExamDescription = exam.Description,
                                        ExamDate = exam.Date,
                                        StartTime = exam.StartTime,
                                        EndTime = exam.EndTime,
                                        CourseName = course.Name
                                    };

                    dataGridView6.DataSource = examsData.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int courseId = (int)dataGridView1.SelectedRows[0].Cells["CourseID"].Value;

                    using (var context = new AppDbContext())
                    {

                        var existingRegistration = context.StudentCourses
                            .FirstOrDefault(sc => sc.StudentID == studentId && sc.CourseID == courseId);

                        if (existingRegistration != null)
                        {
                            MessageBox.Show("You are already registered for this course.");
                        }

                        else
                        {

                            var studentCourse = new StudentCourse
                            {
                                StudentID = studentId,
                                CourseID = courseId
                            };

                            context.StudentCourses.Add(studentCourse);
                            context.SaveChanges();
                            ShowRegisteredCourses();

                            MessageBox.Show("Course registered successfully!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a course to register.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var results = context.StudentExams
                    .Where(se => se.StudentID == studentId)
                    .Select(se => new
                    {
                        se.Exam.Name,
                        se.Result
                    }).ToList();
                dataGridView3.DataSource = results;
            }
        }

        private void StartExambtn_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an exam first.");
                return;
            }

            int examId = Convert.ToInt32(dataGridView6.SelectedRows[0].Cells["ExamID"].Value);

            using (var context = new AppDbContext())
            {
                var previousAttempt = context.StudentExams
                    .FirstOrDefault(se => se.StudentID == _studentId && se.ExamID == examId);

                if (previousAttempt != null)
                {
                    MessageBox.Show("You have already attempted this exam. Multiple attempts are not allowed.");
                    return;
                }

                var exam = context.Exams
                    .Include(e => e.Questions)
                    .FirstOrDefault(e => e.Id == examId);

                if (exam == null)
                {
                    MessageBox.Show("Selected exam not found.");
                    return;
                }

                var currentTime = DateTime.Now.TimeOfDay;
                var currentDate = DateTime.Now.Date;

                if (currentDate != exam.Date.Date)
                {
                    MessageBox.Show("This exam is scheduled for " + exam.Date.ToShortDateString());
                    return;
                }

                if (currentTime < exam.StartTime)
                {
                    MessageBox.Show($"This exam hasn't started yet. It will begin at {exam.StartTime}");
                    return;
                }

                if (currentTime > exam.EndTime)
                {
                    MessageBox.Show($"This exam has ended. The deadline was {exam.EndTime}");
                    return;
                }

                var examForm = new Examination(_studentId, exam);
                this.Hide();
                examForm.ShowDialog();
                this.Show();
                ShowExamsForRegisteredCourses();
            }
        }
    }
}

