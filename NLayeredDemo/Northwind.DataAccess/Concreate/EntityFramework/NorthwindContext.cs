using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess.Concreate.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Northwind;Integrated Security=True");
        }
    }
}
