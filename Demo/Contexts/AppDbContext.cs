using Demo.Configurations;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Demo.Contexts
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpConfig());
            modelBuilder.ApplyConfiguration(new DeptConfig());

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            //modelBuilder.Entity<Employee>()
            //            .HasOne(E => E.Department)
            //            .WithOne(D => D.Manager)
            //            .HasForeignKey<Department>(D => D.EmpId);

            modelBuilder.Entity<Department>()
                        .HasOne(D => D.Manager)
                        .WithOne(E => E.Department)
                        .HasForeignKey<Department>(D => D.EmpId);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EFCore02; Trusted_Connection = True; TrustServerCertificate = True; ");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
