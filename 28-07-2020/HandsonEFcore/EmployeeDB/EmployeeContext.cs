using Employe;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDB
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BJD6RLT\SQLEXPRESS;Initial Catalog=CompanyDB;Persist Security Info=True;User ID=sa;Password=password@123");

        }

    }
}
