using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DataProject.Data
{
    public class BridgeDbContext : DbContext
    {
        public BridgeDbContext(DbContextOptions<BridgeDbContext> opts) : base(opts)
        {
        }

        public DbSet<CountyLookup> CountyLookup { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CountyLookup>().HasData(Parameters.BL02);
        }

#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
        public override int SaveChanges()
#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
        {
            throw new InvalidOperationException("SaveChanges should not be used with this context because it will not cause changes to propagate properly with SQLiteWASMHelper.");
        }
    }
}