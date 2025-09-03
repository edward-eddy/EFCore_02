using Demo.Contexts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        }
    }
}
