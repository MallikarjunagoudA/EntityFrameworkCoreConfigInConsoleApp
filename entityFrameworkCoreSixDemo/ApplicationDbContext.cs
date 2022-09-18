using entityFrameworkCoreSixDemo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkCoreSixDemo
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; Database=EntityFrameworkcoreDemo;integrated security=true");
        }

        public DbSet<Student> student {get; set;}
    }
}
