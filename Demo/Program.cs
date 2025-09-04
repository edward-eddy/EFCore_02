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

            #region Read - Select
            // Read - Select

            //var Result = context.Employees.Where(E => E.Id == 40).FirstOrDefault();
            //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);

            //var Result = context.Employees.Select(E => E.Name);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(Result ?. Name);
            //Console.WriteLine(Result ?. Id); 
            #endregion

            #region Update
            // Update

            //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);

            //Console.WriteLine(context.Entry(Result).State);

            //Result.Name = "Omar Mohamed";
            ////Console.WriteLine(context.Entry(Result).State);

            ////context.Update(Result);
            //Console.WriteLine(context.Entry(Result).State);

            //context.SaveChanges(); 
            //Console.WriteLine(context.Entry(Result).State);
            #endregion

            #region Delete
            // Delete

            //var Result = context.Employees.FirstOrDefault(E => E.Id == 30);

            //Console.WriteLine(context.Entry(Result).State); // Unchanged

            //context.Employees.Remove(Result);
            //Console.WriteLine(context.Entry(Result).State); // Deleted

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Result).State); // Detached 
            #endregion



        }
    }
}
