using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TrainingTrack.Models;

namespace TrainingTrack.data
{
    public class TRContext: IdentityDbContext<ApplicationUser>
    {
        IConfiguration configuration;
        public TRContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public DbSet<DailyReport> dailyReports { get; set; }
        public DbSet<Governorate> governorates { get; set; }
        public DbSet<Hall> halls { get; set; }
        public DbSet<Nationality> nationalities { get; set; }
        public DbSet<Trainer> trainers { get; set; }
        public DbSet<Training> trainings { get; set; }
        public DbSet<Manager> managers { get; set; }
        public DbSet<Trainee> trainees { get; set; }
        public DbSet<Attendance> attendances { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<BookDistribution> bookDistributions { get; set; }
        
         
        public DbSet<Enrollment> enrollments { get; set; }
        public DbSet<Survey> surveys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("cont"));


            base.OnConfiguring(optionsBuilder);

        }

    }


}




    

