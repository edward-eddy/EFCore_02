using Assignment.Configurations;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Contexts
{
    internal class AppDbContext : DbContext
    {
        // 3. Fluent APIs
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentConfigs());
            modelBuilder.ApplyConfiguration(new InstructorConfigs());
            modelBuilder.ApplyConfiguration(new Stud_CourseConfigs());
            modelBuilder.ApplyConfiguration(new TopicConfigs());

            modelBuilder.Entity<Course_Inst>()
                        .HasKey(CI => new { CI.CourseId, CI.InstructorId });


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EF02DB; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public DbSet<Course> Courses { get; set; }
        ////public DbSet<Course_Inst> Course_Inst { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        //public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Student> Students { get; set; }
        //public DbSet<Topic> Topics { get; set; }
    }
}
