using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Configurations
{
    internal class EmpConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.Id);
            builder.Property(E => E.Id).UseIdentityColumn(10, 10);

            builder.Property(E => E.Name)
                                        .HasColumnName("EmployeeName")
                                        .HasColumnType("varchar")
                                        .HasMaxLength(50)
                                        .IsRequired();

            builder.Property(E => E.Age).IsRequired(false);

            builder.Property(E => E.Salary).HasColumnType("money");
        }
    }
}
