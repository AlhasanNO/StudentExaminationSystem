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

namespace StudentExaminationSystem.Forms
{
    public partial class Examination : Form
    {
        private  AppDbContext _context;
        private readonly int _studentId;
        private readonly Exam _exam;
        private readonly List<Question> _questions;
        private int _currentQuestionIndex = 0;
        private int _correctAnswers = 0;

        private TimeSpan _remainingTime;
        private int examId;
        private int studentId;
        private Exam exam;

        public Examination(int studentId, Exam exam)
        {
            InitializeComponent();
            this.examId = examId;
            this.studentId = studentId;
            _context = new AppDbContext();
            _studentId = studentId;
            _exam = exam;
            _questions = exam.Questions.ToList();
            _remainingTime = exam.EndTime - exam.StartTime;
            SetupTimer();
            DisplayQuestion();

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            _remainingTime = _remainingTime.Subtract(TimeSpan.FromSeconds(1));
            label2.Text = _remainingTime.ToString(@"hh\:mm\:ss");

            if (_remainingTime.TotalSeconds <= 0)
            {
                EndExam();
            }
        }
        private void SetupTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 1 second
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }


        private void DisplayQuestion()
        {
            var question = _questions[_currentQuestionIndex];
            label1.Text = question.Text;
            label3.Text = $"Question {_currentQuestionIndex + 1}/{_questions.Count}";

            radioButton1.Text = question.Choice1;
            radioButton2.Text = question.Choice2;
            radioButton3.Text = question.Choice3;
            radioButton4.Text = question.Choice4;

            // Clear previous selection
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any option is selected
            if (!radioButton1.Checked && !radioButton2.Checked &&
                !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Please select an answer before proceeding.");
                return;
            }

            // Check answer
            var currentQuestion = _questions[_currentQuestionIndex];
            string selectedAnswer = "";

            if (radioButton1.Checked) selectedAnswer = radioButton1.Text;
            else if (radioButton2.Checked) selectedAnswer = radioButton2.Text;
            else if (radioButton3.Checked) selectedAnswer = radioButton3.Text;
            else if (radioButton4.Checked) selectedAnswer = radioButton4.Text;

            if (selectedAnswer == currentQuestion.Answer)
            {
                _correctAnswers++;
            }

            _currentQuestionIndex++;

            if (_currentQuestionIndex < _questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                EndExam();
            }
        }

        private void EndExam()
        {
            timer1.Stop();

            // Calculate percentage
            double percentage = (_correctAnswers * 100.0) / _questions.Count;

            try
            {
                // Check if student already has a result for this exam
                var existingResult = _context.StudentExams
                    .FirstOrDefault(se => se.StudentID == _studentId && se.ExamID == _exam.Id);

                if (existingResult != null)
                {
                    // Update existing result
                    existingResult.Result = percentage;
                    _context.StudentExams.Update(existingResult);
                }
                else
                {
                    // Create new result
                    var studentExam = new StudentExam
                    {
                        StudentID = _studentId,
                        ExamID = _exam.Id,
                        Result = percentage
                    };
                    _context.StudentExams.Add(studentExam);
                }

                _context.SaveChanges();
                MessageBox.Show($"Exam completed!\nYour score: {percentage:F1}%", "Exam Results");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving exam results: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
                
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

     

        private void Examination_Load(object sender, EventArgs e)
        {

        }

        private void Examination_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}