using Microsoft.EntityFrameworkCore;
using PortNet.Data.Migrations.INFPortObjectDbContext;

namespace Web.BackendServer.UnitTest.INFPortObject
{
    public class InMemoryDbContextFactory
    {
        public INFPortObjectDbContext GetApplicationDbContext()
        {
            var options = new DbContextOptionsBuilder<INFPortObjectDbContext>()
                       .UseInMemoryDatabase(databaseName: "INFPortObject")
                       .Options;
            var dbContext = new INFPortObjectDbContext(options);
            if (dbContext != null)
            {
                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
            }
            return dbContext;
        }
    }
}
