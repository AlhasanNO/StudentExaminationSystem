namespace StudentExaminationSystem
{
    partial class TeacherDashboard
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label12 = new Label();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            label8 = new Label();
            label7 = new Label();
            dataGridView3 = new DataGridView();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            dataGridView5 = new DataGridView();
            label9 = new Label();
            dataGridView4 = new DataGridView();
            textBox7 = new TextBox();
            label10 = new Label();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(931, 588);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(923, 555);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "courses";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(124, 27);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(63, 27);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 1;
            label11.Text = "My ID :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(841, 396);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(923, 555);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Exams";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(571, 267);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 19;
            label8.Text = "Qusestions";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(584, 19);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 18;
            label7.Text = "Exams";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(319, 303);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(596, 209);
            dataGridView3.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(66, 358);
            button1.Name = "button1";
            button1.Size = new Size(128, 50);
            button1.TabIndex = 15;
            button1.Text = "Add Question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 267);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 13;
            label6.Text = "Result";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 217);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 12;
            label5.Text = "Choice 4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 171);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 11;
            label4.Text = "Choice 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 129);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 10;
            label3.Text = "Choice 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 83);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 9;
            label2.Text = "Choice 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(143, 267);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 217);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 171);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(319, 56);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(596, 181);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(dataGridView5);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(dataGridView4);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(923, 555);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Resultes";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(482, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(445, 334);
            dataGridView5.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 24);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 23;
            label9.Text = "Results";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(8, 47);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(468, 334);
            dataGridView4.TabIndex = 21;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(643, 365);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(568, 368);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 26;
            label10.Text = "label10";
            // 
            // button2
            // 
            button2.Location = new Point(661, 443);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 27;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 588);
            Controls.Add(tabControl1);
            Name = "TeacherDashboard";
            Text = "Teacher Dashboard";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Button button1;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView3;
        private Label label9;
        private DataGridView dataGridView4;
        private Label label12;
        private Label label11;
        private DataGridView dataGridView5;
        private Button button2;
        private Label label10;
        private TextBox textBox7;
    }
}