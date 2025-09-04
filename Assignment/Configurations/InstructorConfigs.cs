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
    internal class InstructorConfigs : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> Instructor)
        {
            Instructor.HasKey(I => I.Id);

            Instructor.Property(I => I.Name)
                       .IsRequired()
                       .HasColumnType("varchar");

            Instructor.Property(I => I.Bouns)
                      .HasColumnType("money");

            Instructor.Property(I => I.Bouns).IsRequired();

            Instructor.HasOne(I => I.WorkFor)
                      .WithMany(D => D.Instructors)
                      .HasForeignKey(I => I.Dept_ID);
        }
    }
}
