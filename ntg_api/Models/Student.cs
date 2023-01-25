using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ntg_api.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public CourseTeacher CourseTeacher { get; set; }
        public int CourseTeacherId { get; set; }
       

    }
}
