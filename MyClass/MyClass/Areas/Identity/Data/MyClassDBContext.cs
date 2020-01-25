using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyClass.Models;

namespace MyClass.Data
{
    public class MyClassDBContext : IdentityDbContext<IdentityUser>
    {
        public MyClassDBContext(DbContextOptions<MyClassDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<School> Schools { get; set; }

        public virtual DbSet<Class> Classes { get; set; }

        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<Homework> Homeworks { get; set; }

        public virtual DbSet<WeeklySchedule> WeeklySchedules { get; set; }
    }
}
