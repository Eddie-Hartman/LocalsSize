using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace DataProject.Data
{
    public class BridgeDbContextFactory : IDesignTimeDbContextFactory<BridgeDbContext>
    {
        public BridgeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BridgeDbContext>();
            optionsBuilder.UseSqlite("Data Source=bridge.db");

            return new BridgeDbContext(optionsBuilder.Options);
        }
    }
}