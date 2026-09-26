using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CleanArchDomain.Models;
    

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options)
        {
        }



        public DbSet<Course> Courses { get; set; }   
    }
}
