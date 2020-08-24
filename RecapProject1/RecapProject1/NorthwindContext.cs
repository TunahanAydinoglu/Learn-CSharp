using Microsoft.EntityFrameworkCore;
using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject1
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
