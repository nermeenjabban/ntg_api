using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ntg_api.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Price { get; set; }
        public ICollection<CourseTeacher> CourseTeachers { get; set; }
    }
}
