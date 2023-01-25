using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ntg_api.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public string TeacherType { get; set; }
        
        public ICollection<CourseTeacher> CourseTeachers { get; set; }
    }
}
