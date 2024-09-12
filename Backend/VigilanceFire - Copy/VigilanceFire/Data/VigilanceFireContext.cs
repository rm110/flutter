using Microsoft.EntityFrameworkCore;
using VigilanceFire.Models;

namespace VigilanceFire.Data
{
    public class VigilanceFireContext : DbContext
    {
        public DbSet<User> Users {  get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Main_Dashboard> mainDasboard { get; set; }
        public DbSet<Cameras> CameraControls { get; set; }
        public DbSet<GasController> gasControllers { get; set; }
        public DbSet<Evacuation_Instructions> Instructions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = .;Initial Catalog = VigilanceFire;Integrated Security = true;Trust Server Certificate = true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ربط الـ model بالجدول الموجود في قاعدة البيانات
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Administrator>().ToTable("Administrator");
            modelBuilder.Entity<Alert>().ToTable("Alert");
            modelBuilder.Entity<Main_Dashboard>().ToTable("Main_Dashboard");
            modelBuilder.Entity<Cameras>().ToTable("Cameras");
            modelBuilder.Entity<GasController>().ToTable("GasController");
            modelBuilder.Entity<Evacuation_Instructions>().ToTable("Evacuation_Instructions");

        }
    }
}
