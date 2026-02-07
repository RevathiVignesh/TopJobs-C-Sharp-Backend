using Microsoft.EntityFrameworkCore;
using TopJobs.Models;

namespace TopJobs.Models
{
    public class TopJobsDbContext : DbContext
    {
        public TopJobsDbContext()
        {

        }
        public TopJobsDbContext(DbContextOptions<TopJobsDbContext> options) : base(options)
        {

        }
        public DbSet<Employerdetails>Empdetails{ get; set; }
        public DbSet<JobSeekerDetails> Jsdetails { get; set; }
        public DbSet<Login>Logins { get; set; }
        public DbSet<Payment>Payments { get; set; }
        public DbSet<Job>Jobs { get; set; }
        public DbSet<Skill>Skills { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationForm> ApplicationForms { get; set;}

    }
}
