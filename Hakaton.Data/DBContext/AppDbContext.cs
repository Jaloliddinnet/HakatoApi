using HakatoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HakatoApi.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<Doctor> doctor { get; set; }
        public DbSet<Patient> patient { get; set; }
        public DbSet<sickness> sickness { get; set; }
    }
}
