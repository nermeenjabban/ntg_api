using Microsoft.EntityFrameworkCore;
using ntg_api.Models;

namespace ntg_api.Data
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {

        }
        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<CourseTeacher> courseTeachers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Course>().HasData
               (new Course { Id = 1, CourseName = "English", Price = 20000 },
               new Course { Id = 2, CourseName = "French", Price = 90000 },
               new Course { Id = 3, CourseName = "Business Administration", Price = 90000 },
               new Course { Id = 4, CourseName = "ICDL", Price = 70000 },
               new Course { Id = 5, CourseName = "Communication skills", Price = 50000 });


            modelBuilder.Entity<Teacher>().HasData(
               new Teacher { Id = 1, TeacherName = "Gary Cabrera", TeacherType = "male" },
               new Teacher { Id = 2, TeacherName = "Stacy Logan", TeacherType = "male" },
               new Teacher { Id = 3, TeacherName = "Priscilla Phelps", TeacherType = "male" },
               new Teacher { Id = 4, TeacherName = "Aliza Vance", TeacherType = "female" },
               new Teacher { Id = 5, TeacherName = "Averie Carter", TeacherType = "female" },
               new Teacher { Id = 6, TeacherName = "Savannah Brooks", TeacherType = "female" },
               new Teacher { Id = 7, TeacherName = "Belen Fox", TeacherType = "female" },
               new Teacher { Id = 8, TeacherName = "Yadira Mcintyre", TeacherType = "female" },
               new Teacher { Id = 9, TeacherName = "Grayson Stout", TeacherType = "female" }

                );
            modelBuilder.Entity<CourseTeacher>().HasData(

                new CourseTeacher { Id = 1, CourseId = 1, TeacherId = 1 },
                new CourseTeacher { Id = 2, CourseId = 1, TeacherId = 2 },
                new CourseTeacher { Id = 3, CourseId = 1, TeacherId = 3 },
                new CourseTeacher { Id = 4, CourseId = 2, TeacherId = 4 },
                new CourseTeacher { Id = 5, CourseId = 2, TeacherId = 3 },
                new CourseTeacher { Id = 6, CourseId = 3, TeacherId = 5 },
                new CourseTeacher { Id = 7, CourseId = 3, TeacherId = 6 },
                new CourseTeacher { Id = 8, CourseId = 4, TeacherId = 7 },
                new CourseTeacher { Id = 9, CourseId = 4, TeacherId = 8 },
                new CourseTeacher { Id = 10, CourseId = 5, TeacherId = 9 },
                new CourseTeacher { Id = 11, CourseId = 5, TeacherId = 8 }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student {Id=1,Name="Nermeen Jabban",Age=23,Phonenumber="+9636987654",Address="Damascus",CourseTeacherId=1 },
                 new Student { Id = 2, Name = "Ahmad Ali", Age = 23, Phonenumber = "+963458722", Address = "Damascus", CourseTeacherId = 2 }
                );
        }
    }
}
