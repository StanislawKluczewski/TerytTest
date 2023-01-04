using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.Models;

namespace Teryt.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TERC> TERCs { get; set; }
        public DbSet<SIMC> SIMCs { get; set; }
        public DbSet<ULIC> ULICs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TERC>().HasNoKey();
            modelBuilder.Entity<SIMC>().HasNoKey();
            modelBuilder.Entity<ULIC>().HasNoKey();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Teryt;user=sa;password=Studenci2022;TrustServerCertificate=true;");
        }
    }
}
