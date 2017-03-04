using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResumeProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ResumeProject.Data
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> options) :base(options)
        {
        }
        public DbSet <WorkExperience> WorkExperiences { get; set; }
        public DbSet<WorkExperience> Education { get; set; }
        public DbSet<WorkExperience> Certification { get; set; }
        public DbSet<WorkExperience> VolunteerExperiences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkExperience>().ToTable("WorkExperience");
            modelBuilder.Entity<Education>().ToTable("Education");
            modelBuilder.Entity<Certifications>().ToTable("Certifications");
            modelBuilder.Entity<VolunteerExperience>().ToTable("VolunteerExperience");
        }
    }
}
