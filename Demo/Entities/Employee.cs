using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    // Model - Entity
    internal class Employee
    {
        public int Id { get; set; } // PK --> Identity(1, 1)
        public string Name { get; set; } // nvarchar(max)
        public double Salary { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }

        #region One To One
        //[InverseProperty(nameof(Department.Manager))]
        public Department Department { get; set; }
        #endregion
        //public int? WorkForId { get; set; }
        [InverseProperty(nameof(Department.Employees))]
        public Department? WorkFor { get; set; }
    }
}
