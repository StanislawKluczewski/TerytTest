using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.Models;

namespace Teryt.WebApi.Data
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration configuration;

        public DataContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
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
            var connectionString = configuration.GetConnectionString("TerrytDatabase");
            optionsBuilder.UseSqlServer(connectionString, builder =>{
                builder.EnableRetryOnFailure(5,TimeSpan.FromSeconds(10), null);
            });
            base.OnConfiguring(optionsBuilder);
        }
    }
}
