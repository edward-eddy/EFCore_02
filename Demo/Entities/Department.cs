using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region One To One
        //public int ManagerId { get; set; } // FK

        //[ForeignKey("Manager")]
        //[ForeignKey(nameof(Manager))]
        public int EmpId { get; set; } // FK
        public Employee Manager { get; set; } // Navigational Property 
        #endregion

        public List<Employee> Employees { get; set; }
    }
}
