using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Ins_Id { get; set; }
        public DateTime HiringDate { get; set; }

        public Instructor Manager { get; set; }

        public List<Instructor> Instructors { get; set; }

        [InverseProperty(nameof(Student.Department))]
        public List<Student> Students { get; set; }
    }
}
