using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configurations
{
    internal class DepartmentConfigs : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> department)
        {
            department.HasOne(D => D.Manager)
                      .WithOne(I => I.ManagedDepartment)
                      .HasForeignKey<Department>(D => D.Ins_Id);
        }
    }
}
