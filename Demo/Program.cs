using Azure;
using Demo.Contexts;
using Demo.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision
            // EF Core: ORM in .NET
            // ORM

            // 1. Mapping
            //      Code First[Generate Table Per Class]
            //      DB First[Generate Class Per Table]
            // 2. L2E [C# Code (LINQ) --- > EF Core -- > SQL DB]

            // 3 Ways Generate
            // 1. TPC : Table Per Class
            // 2. TPH : Table Per Hierarichy
            // 3. TPCC : Table Per Concret Class

            // Code 
            #endregion

            // CRUD Operation
            // Create - Read - Update- Delete

            //AppDbContext context = new AppDbContext();

            //try
            //{
            //   Code
            //}
            //finally
            //{
            //   context.Dispose();
            //}


            //using (AppDbContext context = new AppDbContext())
            //{
            //  // CRUD
            // }

            using AppDbContext context = new AppDbContext();


            #region Create - Insert
            // Create - Insert


            //var employee = new Employee()
            //{
            //    Name = "Ahmed Ali",
            //    Salary = 12000,
            //    Address = "Cairo",
            //    Age = 25
            //};


            //Console.WriteLine(context.Entry(employee).State); // Detached

            //employee.Name = "Khaled";

            //Console.WriteLine(context.Entry(employee).State); // Detached
            ////context.Add(employee);
            //context.Employees.Add(employee);

            //Console.WriteLine(context.Entry(employee).State); // Added

            //var Result = context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State); // Unchanged

            //employee.Name = "Omar";

            //Console.WriteLine(context.Entry(employee).State); // Modified

            //Console.WriteLine(Result);

            //context.Employees.Add(employee);
            //context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State);

            //context.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Added;

            //Console.WriteLine(context.Entry(employee).State);

            //context.SaveChanges(); 
            #endregion



        }
    }
}
