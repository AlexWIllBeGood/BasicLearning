using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestDotNetCore.Entities;

namespace TestDotNetCore
{
    public class TestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //注入SQL字符串
            optionsBuilder.UseSqlServer("Server=.;Database=Test;Trusted_Connection=True;");
        }
        public DbSet<Student> Student { get; set; }
    }
}
