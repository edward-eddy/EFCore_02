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

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EFCore02; Trusted_Connection = True; TrustServerCertificate = True; ");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
