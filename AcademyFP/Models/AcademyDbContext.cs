using Microsoft.EntityFrameworkCore;

namespace AcademyFP.Models
{
    public class AcademyDbContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<TraineeFinancialTranscations> TraineeFinancialTranscations  { get; set; }
        public DbSet<TraineeHasCourse> TraineeHasCourses { get; set; }
        public DbSet<User> Users { get; set; }

        public AcademyDbContext():base() {
        
        
        }
        public AcademyDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Branch)
                .WithMany(b => b.Users)
                .HasForeignKey(u => u.Branch_ID);

            //trainee has courses
            modelBuilder.Entity<TraineeHasCourse>()
                    .HasKey(t => new { t.TraineeNational_ID, t.Course_ID });

            modelBuilder.Entity<TraineeHasCourse>()
                .HasOne(t => t.Trainee)
                .WithMany(t => t.TraineeHasCourses)
                .HasForeignKey(t => t.TraineeNational_ID);

            modelBuilder.Entity<TraineeHasCourse>()
                .HasOne(t => t.Course)
                .WithMany(c => c.TraineeHasCourses)
                .HasForeignKey(t => t.Course_ID);

            //is Supervised
        }
    }
}
