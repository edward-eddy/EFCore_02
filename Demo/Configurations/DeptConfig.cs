using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Configurations
{
    internal class DeptConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(E => E.Id);
            builder.Property(E => E.Id)
                    .UseIdentityColumn(100, 100);
            builder.Property(E => E.Name)
                    .HasColumnName("DepartmentName")
                    .HasColumnType("varchar")
                    .HasMaxLength(50)
                    .IsRequired();

        }
    }
}
