using System.Collections.Generic;

namespace ntg_api.Models
{
    public class CourseTeacher
    {
        public int Id { get; set; }
        public Course Course { get; set; }    
       public int CourseId { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
