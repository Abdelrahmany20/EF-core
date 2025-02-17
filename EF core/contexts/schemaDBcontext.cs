using EF_core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core.contexts
{
    class schemaDBcontext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;DataBase=EFcore_ITI;Trusted_Connection=true;TrustServerCertificate=true");
                
                
        }

        public DbSet<Students> Students { get; set; } 
        public DbSet<courses> courses { get; set; } 
        public DbSet<Instractor> Instractors { get; set; } 
        public DbSet<topic> topics { get; set; }
        public DbSet<course_instractor> course_instractor { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Student_Course> Student_Course { get; set; }




    }
}
