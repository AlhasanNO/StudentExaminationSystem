namespace StudentExaminationSystem.Forms.AdminForms
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tap1 = new TabControl();
            tabPage1 = new TabPage();
            deleteCourse = new Button();
            updateCourse = new Button();
            dataGridView1 = new DataGridView();
            createCourse = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            deleteStudent = new Button();
            updateStudent = new Button();
            dataGridView3 = new DataGridView();
            createStudent = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            tabPage3 = new TabPage();
            deleteTeacher = new Button();
            updateTeacher = new Button();
            dataGridView2 = new DataGridView();
            createTeacher = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            tabPage4 = new TabPage();
            examNameTextBox = new TextBox();
            label5 = new Label();
            endMinutes = new NumericUpDown();
            label16 = new Label();
            endHours = new NumericUpDown();
            label22 = new Label();
            startMinutes = new NumericUpDown();
            label21 = new Label();
            startHours = new NumericUpDown();
            examDatePicker = new DateTimePicker();
            label20 = new Label();
            courseIdTextBox = new TextBox();
            deleteExam = new Button();
            updateExam = new Button();
            dataGridView4 = new DataGridView();
            createExam = new Button();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            descriptionTextBox = new TextBox();
            tabPage5 = new TabPage();
            label10 = new Label();
            dataGridView6 = new DataGridView();
            dataGridView5 = new DataGridView();
            tabPage6 = new TabPage();
            button3 = new Button();
            label24 = new Label();
            textBox15 = new TextBox();
            dataGridView9 = new DataGridView();
            button2 = new Button();
            label23 = new Label();
            textBox14 = new TextBox();
            dataGridView8 = new DataGridView();
            button1 = new Button();
            label15 = new Label();
            textBox13 = new TextBox();
            dataGridView7 = new DataGridView();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            tap1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)endMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            SuspendLayout();
            // 
            // tap1
            // 
            tap1.Controls.Add(tabPage1);
            tap1.Controls.Add(tabPage2);
            tap1.Controls.Add(tabPage3);
            tap1.Controls.Add(tabPage4);
            tap1.Controls.Add(tabPage5);
            tap1.Controls.Add(tabPage6);
            tap1.Dock = DockStyle.Fill;
            tap1.Location = new Point(0, 0);
            tap1.Name = "tap1";
            tap1.SelectedIndex = 0;
            tap1.Size = new Size(1026, 515);
            tap1.SizeMode = TabSizeMode.FillToRight;
            tap1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(deleteCourse);
            tabPage1.Controls.Add(updateCourse);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(createCourse);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1018, 482);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Courses";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteCourse
            // 
            deleteCourse.Location = new Point(136, 317);
            deleteCourse.Name = "deleteCourse";
            deleteCourse.Size = new Size(160, 42);
            deleteCourse.TabIndex = 39;
            deleteCourse.Text = "Delete";
            deleteCourse.UseVisualStyleBackColor = true;
            deleteCourse.Click += deleteCourse_Click;
            // 
            // updateCourse
            // 
            updateCourse.Location = new Point(136, 269);
            updateCourse.Name = "updateCourse";
            updateCourse.Size = new Size(160, 42);
            updateCourse.TabIndex = 38;
            updateCourse.Text = "Update";
            updateCourse.UseVisualStyleBackColor = true;
            updateCourse.Click += updateCourse_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(340, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 482);
            dataGridView1.TabIndex = 36;
            // 
            // createCourse
            // 
            createCourse.Location = new Point(136, 221);
            createCourse.Name = "createCourse";
            createCourse.Size = new Size(160, 42);
            createCourse.TabIndex = 35;
            createCourse.Text = "Create Course";
            createCourse.UseVisualStyleBackColor = true;
            createCourse.Click += createCourse_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 165);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 34;
            label4.Text = "Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 126);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 33;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 79);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 32;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 31;
            label1.Text = "Teacher ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 27);
            textBox4.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 27);
            textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 27);
            textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 27);
            textBox1.TabIndex = 27;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(deleteStudent);
            tabPage2.Controls.Add(updateStudent);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Controls.Add(createStudent);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1018, 482);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Students";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteStudent
            // 
            deleteStudent.Location = new Point(195, 350);
            deleteStudent.Name = "deleteStudent";
            deleteStudent.Size = new Size(160, 42);
            deleteStudent.TabIndex = 52;
            deleteStudent.Text = "Delete";
            deleteStudent.UseVisualStyleBackColor = true;
            deleteStudent.Click += deleteStudent_Click;
            // 
            // updateStudent
            // 
            updateStudent.Location = new Point(195, 302);
            updateStudent.Name = "updateStudent";
            updateStudent.Size = new Size(160, 42);
            updateStudent.TabIndex = 51;
            updateStudent.Text = "Update";
            updateStudent.UseVisualStyleBackColor = true;
            updateStudent.Click += updateStudent_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(467, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(551, 479);
            dataGridView3.TabIndex = 50;
            // 
            // createStudent
            // 
            createStudent.Location = new Point(195, 254);
            createStudent.Name = "createStudent";
            createStudent.Size = new Size(160, 42);
            createStudent.TabIndex = 48;
            createStudent.Text = "Create Student";
            createStudent.UseVisualStyleBackColor = true;
            createStudent.Click += createStudent_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(108, 152);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 47;
            label11.Text = "Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(132, 107);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 46;
            label12.Text = "Email";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(129, 66);
            label13.Name = "label13";
            label13.Size = new Size(49, 20);
            label13.TabIndex = 45;
            label13.Text = "Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(129, 198);
            label14.Name = "label14";
            label14.Size = new Size(48, 20);
            label14.TabIndex = 44;
            label14.Text = "Major";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(195, 63);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(160, 27);
            textBox9.TabIndex = 43;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(195, 104);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(160, 27);
            textBox10.TabIndex = 42;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(195, 152);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(160, 27);
            textBox11.TabIndex = 41;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(195, 195);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(160, 27);
            textBox12.TabIndex = 40;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(deleteTeacher);
            tabPage3.Controls.Add(updateTeacher);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(createTeacher);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1018, 482);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Teachers";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteTeacher
            // 
            deleteTeacher.Location = new Point(179, 349);
            deleteTeacher.Name = "deleteTeacher";
            deleteTeacher.Size = new Size(178, 42);
            deleteTeacher.TabIndex = 54;
            deleteTeacher.Text = "Delete";
            deleteTeacher.UseVisualStyleBackColor = true;
            deleteTeacher.Click += deleteTeacher_Click;
            // 
            // updateTeacher
            // 
            updateTeacher.Location = new Point(179, 301);
            updateTeacher.Name = "updateTeacher";
            updateTeacher.Size = new Size(178, 42);
            updateTeacher.TabIndex = 53;
            updateTeacher.Text = "Update";
            updateTeacher.UseVisualStyleBackColor = true;
            updateTeacher.Click += updateTeacher_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(463, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(555, 482);
            dataGridView2.TabIndex = 51;
            // 
            // createTeacher
            // 
            createTeacher.Location = new Point(179, 253);
            createTeacher.Name = "createTeacher";
            createTeacher.Size = new Size(178, 42);
            createTeacher.TabIndex = 49;
            createTeacher.Text = "Create Teacher";
            createTeacher.UseVisualStyleBackColor = true;
            createTeacher.Click += createTeacher_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 200);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 48;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(115, 110);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 47;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(113, 66);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 46;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(101, 156);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 45;
            label9.Text = "College";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(179, 63);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 27);
            textBox5.TabIndex = 44;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(179, 107);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(178, 27);
            textBox6.TabIndex = 43;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(179, 153);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(178, 27);
            textBox7.TabIndex = 42;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(179, 200);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(178, 27);
            textBox8.TabIndex = 41;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(examNameTextBox);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(endMinutes);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(endHours);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(startMinutes);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(startHours);
            tabPage4.Controls.Add(examDatePicker);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(courseIdTextBox);
            tabPage4.Controls.Add(deleteExam);
            tabPage4.Controls.Add(updateExam);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Controls.Add(createExam);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(descriptionTextBox);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1018, 482);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Exams";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // examNameTextBox
            // 
            examNameTextBox.Location = new Point(118, 87);
            examNameTextBox.Name = "examNameTextBox";
            examNameTextBox.Size = new Size(125, 27);
            examNameTextBox.TabIndex = 79;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 87);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 78;
            label5.Text = "Name";
            // 
            // endMinutes
            // 
            endMinutes.Location = new Point(343, 297);
            endMinutes.Name = "endMinutes";
            endMinutes.Size = new Size(71, 27);
            endMinutes.TabIndex = 77;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(228, 300);
            label16.Name = "label16";
            label16.Size = new Size(103, 20);
            label16.TabIndex = 76;
            label16.Text = "End Time: Min";
            // 
            // endHours
            // 
            endHours.Location = new Point(139, 297);
            endHours.Name = "endHours";
            endHours.Size = new Size(71, 27);
            endHours.TabIndex = 75;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 300);
            label22.Name = "label22";
            label22.Size = new Size(117, 20);
            label22.TabIndex = 74;
            label22.Text = "End Time: Hours";
            // 
            // startMinutes
            // 
            startMinutes.Location = new Point(343, 258);
            startMinutes.Name = "startMinutes";
            startMinutes.Size = new Size(71, 27);
            startMinutes.TabIndex = 73;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(228, 261);
            label21.Name = "label21";
            label21.Size = new Size(109, 20);
            label21.TabIndex = 72;
            label21.Text = "Start Time: Min";
            // 
            // startHours
            // 
            startHours.Location = new Point(139, 258);
            startHours.Name = "startHours";
            startHours.Size = new Size(71, 27);
            startHours.TabIndex = 71;
            // 
            // examDatePicker
            // 
            examDatePicker.Location = new Point(99, 225);
            examDatePicker.Name = "examDatePicker";
            examDatePicker.Size = new Size(315, 27);
            examDatePicker.TabIndex = 70;
            examDatePicker.Value = new DateTime(2024, 12, 19, 11, 31, 46, 0);
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(24, 33);
            label20.Name = "label20";
            label20.Size = new Size(69, 20);
            label20.TabIndex = 69;
            label20.Text = "CourseID";
            // 
            // courseIdTextBox
            // 
            courseIdTextBox.Location = new Point(99, 30);
            courseIdTextBox.Name = "courseIdTextBox";
            courseIdTextBox.Size = new Size(78, 27);
            courseIdTextBox.TabIndex = 68;
            // 
            // deleteExam
            // 
            deleteExam.Location = new Point(254, 438);
            deleteExam.Name = "deleteExam";
            deleteExam.Size = new Size(160, 42);
            deleteExam.TabIndex = 66;
            deleteExam.Text = "Delete";
            deleteExam.UseVisualStyleBackColor = true;
            deleteExam.Click += deleteExam_Click;
            // 
            // updateExam
            // 
            updateExam.Location = new Point(254, 390);
            updateExam.Name = "updateExam";
            updateExam.Size = new Size(160, 42);
            updateExam.TabIndex = 65;
            updateExam.Text = "Update";
            updateExam.UseVisualStyleBackColor = true;
            updateExam.Click += updateExam_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(420, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(598, 482);
            dataGridView4.TabIndex = 64;
            // 
            // createExam
            // 
            createExam.Location = new Point(254, 342);
            createExam.Name = "createExam";
            createExam.Size = new Size(160, 42);
            createExam.TabIndex = 62;
            createExam.Text = "Create Exam";
            createExam.UseVisualStyleBackColor = true;
            createExam.Click += createExam_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(52, 225);
            label17.Name = "label17";
            label17.Size = new Size(41, 20);
            label17.TabIndex = 60;
            label17.Text = "Date";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 130);
            label18.Name = "label18";
            label18.Size = new Size(85, 20);
            label18.TabIndex = 59;
            label18.Text = "Description";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 261);
            label19.Name = "label19";
            label19.Size = new Size(123, 20);
            label19.TabIndex = 58;
            label19.Text = "Start Time: Hours";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(99, 127);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(315, 82);
            descriptionTextBox.TabIndex = 55;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(dataGridView6);
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1018, 482);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Results";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(659, 23);
            label10.Name = "label10";
            label10.Size = new Size(297, 20);
            label10.TabIndex = 3;
            label10.Text = "Number of students enrolled in each course";
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(579, 59);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.Size = new Size(452, 423);
            dataGridView6.TabIndex = 2;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(0, 59);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(573, 423);
            dataGridView5.TabIndex = 1;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label27);
            tabPage6.Controls.Add(label26);
            tabPage6.Controls.Add(label25);
            tabPage6.Controls.Add(button3);
            tabPage6.Controls.Add(label24);
            tabPage6.Controls.Add(textBox15);
            tabPage6.Controls.Add(dataGridView9);
            tabPage6.Controls.Add(button2);
            tabPage6.Controls.Add(label23);
            tabPage6.Controls.Add(textBox14);
            tabPage6.Controls.Add(dataGridView8);
            tabPage6.Controls.Add(button1);
            tabPage6.Controls.Add(label15);
            tabPage6.Controls.Add(textBox13);
            tabPage6.Controls.Add(dataGridView7);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1018, 482);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Report";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(897, 401);
            button3.Name = "button3";
            button3.Size = new Size(107, 44);
            button3.TabIndex = 35;
            button3.Text = "Show";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(744, 410);
            label24.Name = "label24";
            label24.Size = new Size(75, 20);
            label24.TabIndex = 34;
            label24.Text = "StudentID";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(825, 410);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(66, 27);
            textBox15.TabIndex = 33;
            // 
            // dataGridView9
            // 
            dataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView9.Location = new Point(684, 53);
            dataGridView9.Name = "dataGridView9";
            dataGridView9.RowHeadersWidth = 51;
            dataGridView9.Size = new Size(326, 327);
            dataGridView9.TabIndex = 32;
            // 
            // button2
            // 
            button2.Location = new Point(539, 404);
            button2.Name = "button2";
            button2.Size = new Size(107, 44);
            button2.TabIndex = 31;
            button2.Text = "Show ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(388, 413);
            label23.Name = "label23";
            label23.Size = new Size(60, 20);
            label23.TabIndex = 30;
            label23.Text = "ExamID";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(454, 413);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(66, 27);
            textBox14.TabIndex = 29;
            // 
            // dataGridView8
            // 
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(340, 53);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.RowHeadersWidth = 51;
            dataGridView8.Size = new Size(338, 327);
            dataGridView8.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(189, 406);
            button1.Name = "button1";
            button1.Size = new Size(107, 44);
            button1.TabIndex = 3;
            button1.Text = "Show Exams";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 415);
            label15.Name = "label15";
            label15.Size = new Size(73, 20);
            label15.TabIndex = 2;
            label15.Text = "TeacherId";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(91, 415);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(69, 27);
            textBox13.TabIndex = 1;
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(3, 53);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.Size = new Size(331, 327);
            dataGridView7.TabIndex = 0;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(3, 17);
            label25.Name = "label25";
            label25.Size = new Size(310, 20);
            label25.TabIndex = 36;
            label25.Text = "list of exams that belong to a specific teacher";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(693, 17);
            label26.Name = "label26";
            label26.Size = new Size(322, 20);
            label26.TabIndex = 37;
            label26.Text = "Retrieve the course with the lowest exam result.";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(336, 17);
            label27.Name = "label27";
            label27.Size = new Size(342, 20);
            label27.TabIndex = 38;
            label27.Text = "Find the student with the highest result for a exam.";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 515);
            Controls.Add(tap1);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            tap1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)endMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)endHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)startMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)startHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tap1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button deleteCourse;
        private Button updateCourse;
        private DataGridView dataGridView1;
        private Button createCourse;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button deleteTeacher;
        private Button updateTeacher;
        private DataGridView dataGridView2;
        private Button createTeacher;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button deleteStudent;
        private Button updateStudent;
        private DataGridView dataGridView3;
        private Button createStudent;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button deleteExam;
        private Button updateExam;
        private DataGridView dataGridView4;
        private Button createExam;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox descriptionTextBox;
        private Label label20;
        private TextBox courseIdTextBox;
        private DateTimePicker examDatePicker;
        private NumericUpDown startHours;
        private NumericUpDown endMinutes;
        private Label label16;
        private NumericUpDown endHours;
        private Label label22;
        private NumericUpDown startMinutes;
        private Label label21;
        private TabPage tabPage5;
        private DataGridView dataGridView5;
        private TextBox examNameTextBox;
        private Label label5;
        private DataGridView dataGridView6;
        private Label label10;
        private TabPage tabPage6;
        private Button button1;
        private Label label15;
        private TextBox textBox13;
        private DataGridView dataGridView7;
        private Button button2;
        private Label label23;
        private TextBox textBox14;
        private DataGridView dataGridView8;
        private Button button3;
        private Label label24;
        private TextBox textBox15;
        private DataGridView dataGridView9;
        private Label label26;
        private Label label25;
        private Label label27;
    }
}