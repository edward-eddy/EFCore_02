using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course_Inst
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public int Evaluate { get; set; }
    }
}
