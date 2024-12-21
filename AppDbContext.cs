using Microsoft.EntityFrameworkCore;
using StudentExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystem
{
    public class AppDbContext: DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=N;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Inheritance
            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Student>("Student")
                .HasValue<Teacher>("Teacher");

            // Configure many-to-many: Student <-> Course using StudentCourse
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentID, sc.CourseID }); // Composite Key

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Configure Many-to-Many: Student <-> Exam
            modelBuilder.Entity<StudentExam>()
                .HasKey(se => new { se.StudentID, se.ExamID });

            modelBuilder.Entity<StudentExam>()
                .HasOne(se => se.Student)
                .WithMany(s => s.StudentExams)
                .HasForeignKey(se => se.StudentID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<StudentExam>()
                .HasOne(se => se.Exam)
                .WithMany(e => e.StudentExams)
                .HasForeignKey(se => se.ExamID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Configure One-to-Many: Teacher <-> Course
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Configure One-to-Many: Course <-> Exam
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Exams)
                .HasForeignKey(e => e.CourseID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Configure One-to-Many: Exam <-> Question
            modelBuilder.Entity<Question>()
                .HasOne(q => q.Exam)
                .WithMany(e => e.Questions)
                .HasForeignKey(q => q.ExamID)
                .OnDelete(DeleteBehavior.Cascade); // Allow cascade delete for questions

            base.OnModelCreating(modelBuilder);
        }

    }
}

