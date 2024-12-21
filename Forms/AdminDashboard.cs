using Microsoft.EntityFrameworkCore;
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
using System.Xml.Linq;

namespace StudentExaminationSystem.Forms.AdminForms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadCourses();
            LoadStudents();
            LoadTeacher();
            LoadExams();
            showResult();
            ShowStudentEnrollment();
        }

        private void LoadStudents()
        {
            using (var context = new AppDbContext())
            {
                List<Student> students = context.Students.ToList();
                dataGridView3.DataSource = students;
            }

            dataGridView3.Columns[dataGridView3.Columns.Count - 1].Visible = false;
            dataGridView3.Columns[dataGridView3.Columns.Count - 5].Visible = false;
            dataGridView3.Columns[dataGridView3.Columns.Count - 6].Visible = false;
        }

        private void LoadCourses()
        {
            using (var context = new AppDbContext())
            {
                List<Course> courses = context.Courses.ToList();
                dataGridView1.DataSource = courses;
            }
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
            dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
            dataGridView1.Columns[dataGridView1.Columns.Count - 3].Visible = false;
        }

        private void LoadTeacher()
        {
            using (var context = new AppDbContext())
            {
                var teachers = context.Teachers
                  .Include(t => t.Courses)
                  .Select(t => new
                  {
                      t.Id,
                      t.Name,
                      t.Email,
                      t.College,
                      Courses = t.Courses.Any() ? string.Join(", ", t.Courses.Select(c => c.Name)) : "No Courses"
                  })
                   .ToList();
                dataGridView2.DataSource = teachers;
            }
            dataGridView2.Columns[dataGridView2.Columns.Count - 2].Visible = false;

        }

        private void showResult()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var data = from student in context.Students
                               join studentExam in context.StudentExams on student.Id equals studentExam.StudentID
                               join exam in context.Exams on studentExam.ExamID equals exam.Id
                               join course in context.Courses on exam.CourseID equals course.ID
                               select new
                               {
                                   StudentID = student.Id,
                                   StudentName = student.Name,
                                   ExamID = exam.Id,
                                   CourseID = course.ID,
                                   CourseName = course.Name,
                                   Result = studentExam.Result
                               };


                    dataGridView5.DataSource = data.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadExams()
        {
            using (var context = new AppDbContext())
            {
                var examsWithCourses = context.Exams
      .Join(context.Courses,
            exam => exam.CourseID,
            course => course.ID,
            (exam, course) => new
            {
                ID = exam.Id,
                CourseName = course.Name,
                ExamName = exam.Name,
                Description = exam.Description,
                Date = exam.Date,
                StartTime = exam.StartTime,
                EndTime = exam.EndTime
            })
      .ToList();
                dataGridView4.DataSource = examsWithCourses;
            }

        }

        private void ShowStudentEnrollment()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                 
                    var data = context.Courses
                        .Select(course => new
                        {
                            CourseID = course.ID,
                            CourseName = course.Name,
                            StudentCount = context.StudentCourses.Count(sc => sc.CourseID == course.ID)
                        })
                        .ToList();

                    dataGridView6.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ShowTopStudentForExam(int examId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var data = context.StudentExams
                        .Where(se => se.ExamID == examId)
                        .OrderByDescending(se => se.Result)
                        .Select(se => new
                        {
                            StudentName = context.Students
                                .Where(s => s.Id == se.StudentID)
                                .Select(s => s.Name)
                                .FirstOrDefault(),
                            ExamID = se.ExamID,
                            Result = se.Result
                        })
                        .Take(1)
                        .ToList();

                    dataGridView8.DataSource = data;

                    if (data.Count == 0)
                    {
                        MessageBox.Show("No results found for the given ExamID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ShowExamsForTeacher(int teacherId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
            
                    var data = context.Exams
                        .Where(exam => exam.Course.TeacherID == teacherId)
                        .Select(exam => new
                        {
                            ExamID = exam.Id,
                            ExamName = exam.Name,
                            CourseName = exam.Course.Name
                        })
                        .ToList();

            
                    dataGridView7.DataSource = data;

                    if (data.Count == 0)
                    {
                        MessageBox.Show("No exams found for the given Teacher ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ShowCourseWithMinResultForStudent(int studentId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
       
                    var result = context.StudentExams
                        .Where(se => se.StudentID == studentId && se.Result.HasValue)
                        .OrderBy(se => se.Result)
                        .Select(se => new
                        {
                            CourseName = se.Exam.Course.Name,
                            ExamName = se.Exam.Name,
                            Result = se.Result
                        })
                        .FirstOrDefault();

                    if (result != null)
                    {
            
                        var data = new List<object> { result };
                        dataGridView9.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("No results found for the given Student ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void createCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox1.Text, out int teacherID))
                {
                    MessageBox.Show("Please enter a valid Teacher ID.");
                    textBox1.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Course name is required.");
                    textBox2.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Course description is required.");
                    textBox3.Focus();
                    return;
                }

                if (!int.TryParse(textBox4.Text, out int level))
                {
                    MessageBox.Show("Please enter a valid Level number.");
                    textBox4.Focus();
                    return;
                }

                Course newCourse = new Course()
                {
                    Name = textBox2.Text,
                    Level = level,
                    Description = textBox3.Text,
                    TeacherID = teacherID
                };

                using (var context = new AppDbContext())
                {

                    context.Courses.Add(newCourse);
                    context.SaveChanges();

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    LoadCourses();
                    LoadTeacher();
                    MessageBox.Show("Course added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void updateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Please select a course to update.");
                    return;
                }

                int courseID = Convert.ToInt32(dataGridView1.CurrentCell.Value);

                using (var context = new AppDbContext())
                {
                    Course course = context.Courses.Find(courseID);
                    if (course == null)
                    {
                        MessageBox.Show("Course not found.");
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox1.Text) && int.TryParse(textBox1.Text, out int teacherID))
                    {
                        course.TeacherID = teacherID;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        course.Name = textBox2.Text;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        course.Description = textBox3.Text;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox4.Text) && int.TryParse(textBox4.Text, out int level))
                    {
                        course.Level = level;
                    }

                    context.Update(course);
                    context.SaveChanges();
                    LoadCourses();
                    MessageBox.Show("Course updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void deleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell == null || dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a course to delete.");
                    return;
                }

                int courseID = Convert.ToInt32(dataGridView1.CurrentCell.Value);
                using (var context = new AppDbContext())
                {
                    var course = context.Courses
                      .Include(c => c.Exams)
                      .FirstOrDefault(c => c.ID == courseID);
                    if (course == null)
                    {
                        MessageBox.Show("Course not found.");
                        return;
                    }
                    context.Exams.RemoveRange(course.Exams);


                    context.Courses.Remove(course);

                    context.SaveChanges();

                    LoadCourses();

                    MessageBox.Show("Course deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting course: {ex.Message}");
            }

        }

        private void createStudent_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    MessageBox.Show("Student name is required.");
                    textBox9.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox10.Text))
                {
                    MessageBox.Show("Email is required.");
                    textBox10.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    MessageBox.Show("Major is required.");
                    textBox12.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    MessageBox.Show("Password is required.");
                    textBox11.Focus();
                    return;
                }

                var student = new Student
                {
                    Email = textBox10.Text,
                    Password = textBox11.Text,
                    Name = textBox9.Text,
                    Speciality = textBox12.Text,
                };


                using (var context = new AppDbContext())
                {

                    if (context.Students.Any(s => s.Email == textBox10.Text))
                    {
                        MessageBox.Show("Email is already registered.");
                        return;
                    }

                    context.Students.Add(student);
                    context.SaveChanges();


                    textBox9.Clear();
                    textBox10.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    LoadStudents();
                    MessageBox.Show("Student registered successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Please select a student to update.");
                    return;
                }

                int studentID = Convert.ToInt32(dataGridView3.CurrentCell.Value);

                using (var context = new AppDbContext())
                {
                    Student student = context.Students.Find(studentID);
                    if (student == null)
                    {
                        MessageBox.Show("Stuedent not found.");
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox9.Text))
                    {
                        student.Name = textBox9.Text;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox10.Text))
                    {
                        student.Email = textBox10.Text;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox12.Text))
                    {
                        student.Speciality = textBox12.Text;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox11.Text))
                    {
                        student.Password = textBox11.Text;
                    }
                    context.Update(student);
                    context.SaveChanges();
                    LoadStudents();
                    MessageBox.Show("Student updated successfully!");
                    textBox9.Clear();
                    textBox10.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.CurrentCell == null || dataGridView3.CurrentRow == null)
                {
                    MessageBox.Show("Please select a student to delete.");
                    return;
                }

                int studentID = Convert.ToInt32(dataGridView3.CurrentCell.Value);
                using (var context = new AppDbContext())
                {
                    Student student = context.Students.Find(studentID);
                    if (student == null)
                    {
                        MessageBox.Show("Student not found.");
                        return;
                    }

                    context.Students.Remove(student);
                    context.SaveChanges();

                    LoadStudents();
                    MessageBox.Show("Student deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting course: {ex.Message}");
            }
        }

        private void createTeacher_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            string email = textBox6.Text;
            string password = textBox8.Text;
            string college = textBox7.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(college))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                using (var context = new AppDbContext())
                {

                    var teacher = new Teacher
                    {
                        Name = name,
                        Email = email,
                        Password = password,
                        College = college
                    };


                    context.Teachers.Add(teacher);
                    context.SaveChanges();

                    MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeacher();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentCell == null)
                {
                    MessageBox.Show("Please select a teacherID to update.");
                    return;
                }

                int teacherID = Convert.ToInt32(dataGridView2.CurrentCell.Value);

                using (var context = new AppDbContext())
                {
                    Teacher teacher = context.Teachers.Find(teacherID);
                    if (teacher == null)
                    {
                        MessageBox.Show("Teacher not found.");
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox5.Text))
                    {
                        teacher.Name = textBox5.Text;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox6.Text))
                    {
                        teacher.Email = textBox6.Text;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox8.Text))
                    {
                        teacher.Password = textBox8.Text;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox7.Text))
                    {
                        teacher.College = textBox7.Text;
                    }

                    context.Update(teacher);
                    context.SaveChanges();
                    LoadTeacher();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    MessageBox.Show("Teacher updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void deleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentCell == null || dataGridView2.CurrentRow == null)
                {
                    MessageBox.Show("Please select a teacherID to delete.");
                    return;
                }

                int teacherID = Convert.ToInt32(dataGridView2.CurrentCell.Value);

                using (var context = new AppDbContext())
                {
                    Teacher teacher = context.Teachers.Find(teacherID);
                    if (teacher == null)
                    {
                        MessageBox.Show("Teacher not found.");
                        return;
                    }

                    context.Teachers.Remove(teacher);
                    context.SaveChanges();

                    LoadTeacher();
                    MessageBox.Show("Teacher deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting teacher: {ex.Message}");
            }
        }



        private void createExam_Click(object sender, EventArgs e)
        {
            try
            {
        
                DateTime examDate = examDatePicker.Value.Date;

     
                TimeSpan startTime = new TimeSpan((int)startHours.Value, (int)startMinutes.Value, 0);
                TimeSpan endTime = new TimeSpan((int)endHours.Value, (int)endMinutes.Value, 0);

                if (string.IsNullOrWhiteSpace(courseIdTextBox.Text) || !int.TryParse(courseIdTextBox.Text, out int courseId))
                {
                    MessageBox.Show("Please enter a valid CourseID.");
                    courseIdTextBox.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(examNameTextBox.Text))
                {
                    MessageBox.Show("Exam name is required.");
                    examNameTextBox.Focus();
                    return;
                }
        
                if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
                {
                    MessageBox.Show("Description is required.");
                    descriptionTextBox.Focus();
                    return;
                }

       
                if (endTime <= startTime)
                {
                    MessageBox.Show("End time must be after start time.");
                    return;
                }

          
                var exam = new Exam
                {
                    CourseID = courseId,
                    Name = examNameTextBox.Text,
                    Description = descriptionTextBox.Text,
                    Date = examDate,
                    StartTime = startTime,
                    EndTime = endTime
                };

   
                using (var context = new AppDbContext())
                {
                    if (!context.Courses.Any(c => c.ID == courseId))
                    {
                        MessageBox.Show("CourseID does not exist.");
                        return;
                    }

                    context.Exams.Add(exam);
                    context.SaveChanges();

                    MessageBox.Show("Exam added successfully!");
                    LoadExams();
                    courseIdTextBox.Clear();
                    descriptionTextBox.Clear();
                    startHours.Value = 0;
                    startMinutes.Value = 0;
                    endHours.Value = 0;
                    endMinutes.Value = 0;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void updateExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView4.CurrentCell == null || dataGridView4.CurrentRow == null)
                {
                    MessageBox.Show("Please select an exam to update.");
                    return;
                }

                int examID = Convert.ToInt32(dataGridView4.CurrentRow.Cells["ID"].Value);

                using (var context = new AppDbContext())
                {
                    Exam exam = context.Exams.Find(examID);
                    if (exam == null)
                    {
                        MessageBox.Show("Exam not found.");
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(courseIdTextBox.Text) && int.TryParse(courseIdTextBox.Text, out int courseId))
                    {
                        if (!context.Courses.Any(c => c.ID == courseId))
                        {
                            MessageBox.Show("Invalid CourseID.");
                            return;
                        }
                        exam.CourseID = courseId;
                    }
                    if (!string.IsNullOrWhiteSpace(examNameTextBox.Text))
                    {
                        exam.Name = examNameTextBox.Text;
                    }
                    if (!string.IsNullOrWhiteSpace(descriptionTextBox.Text))
                    {
                        exam.Description = descriptionTextBox.Text;
                    }

                    DateTime examDate = examDatePicker.Value.Date;
                    TimeSpan startTime = new TimeSpan((int)startHours.Value, (int)startMinutes.Value, 0);
                    TimeSpan endTime = new TimeSpan((int)endHours.Value, (int)endMinutes.Value, 0);

                    if (endTime <= startTime)
                    {
                        MessageBox.Show("End time must be after start time.");
                        return;
                    }

                    exam.Date = examDate;
                    exam.StartTime = startTime;
                    exam.EndTime = endTime;

                    context.Update(exam);
                    context.SaveChanges();

                    MessageBox.Show("Exam updated successfully!");
                    LoadExams();

      
                    courseIdTextBox.Clear();
                    descriptionTextBox.Clear();
                    examNameTextBox.Clear();
                    startHours.Value = 0;
                    startMinutes.Value = 0;
                    endHours.Value = 0;
                    endMinutes.Value = 0;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void deleteExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView4.CurrentCell == null || dataGridView4.CurrentRow == null)
                {
                    MessageBox.Show("Please select an exam to delete.");
                    return;
                }

                int examID = Convert.ToInt32(dataGridView4.CurrentRow.Cells["ID"].Value);

                using (var context = new AppDbContext())
                {
                    Exam exam = context.Exams.Find(examID);
                    if (exam == null)
                    {
                        MessageBox.Show("Exam not found.");
                        return;
                    }

                    context.Exams.Remove(exam);
                    context.SaveChanges();

                    MessageBox.Show("Exam deleted successfully!");
                    LoadExams();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox13.Text, out int teacherId))
            {
                ShowExamsForTeacher(teacherId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Teacher ID.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox14.Text, out int examId))
            {
                ShowTopStudentForExam(examId);
            }
            else
            {
                MessageBox.Show("Please enter a valid ExamID.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox15.Text, out int studentId))
            {
                ShowCourseWithMinResultForStudent(studentId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID.");
            }
        }
    }
}
