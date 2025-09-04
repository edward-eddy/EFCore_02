using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class StudentCourse
    {
        //public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public double Grade { get; set; }
        //public List<Student> Students { get; set; }
        //public List<Course> Courses { get; set; }
    }
}
