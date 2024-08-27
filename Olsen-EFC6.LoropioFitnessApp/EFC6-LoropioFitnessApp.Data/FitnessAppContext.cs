using Microsoft.EntityFrameworkCore;

namespace EFC6.Loropio_Fitness.Console
{
    public class FitnessAppContext : DbContext
    {

        public DbSet<RunActivity> RunActivities { get; set; }

        public FitnessAppContext(DbContextOptions<FitnessAppContext> options)
            : base(options)
        {
        }

        public FitnessAppContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost\\SQLEXPRESS;Database=FitnessDb;Encrypt=False;Trusted_Connection=True;"
                );
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RunActivity>().ToTable("RunActivities");
        }

    }

}
