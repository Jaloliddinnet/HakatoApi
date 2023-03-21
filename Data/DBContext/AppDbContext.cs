using HakatoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HakatoApi.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { 
        }
        public DbSet<Doctor> doctor { get; set; }
        public DbSet<Patient> patient { get; set; }
        public DbSet<sickness> sickness { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>(p => p
            .HasMany(p => p.sicknesses)
            .WithMany(p => p.doctors));

            modelBuilder.Entity<Patient>(p => p
            .HasMany(p => p.sickness)
            .WithOne(p => p.patient)
            .HasForeignKey(p => p.patient_id));

            base.OnModelCreating(modelBuilder);
        }
    }
}
