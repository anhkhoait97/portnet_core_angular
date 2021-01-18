using Microsoft.EntityFrameworkCore;
using PortNet.Data.Configurations.INFPort.Configuration;
using PortNet.Model.Entities.INFPort;

namespace PortNet.Data.Migrations.INFPortDbContext
{
    public class INFPortDbContext : ApplicationDbContext
    {
        public INFPortDbContext(DbContextOptions<INFPortDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region INFPort

            modelBuilder.ApplyConfiguration(new UserGroupUpdateStatusPortConfiguration());

            modelBuilder.ApplyConfiguration(new UserGroupsConfiguration());

            modelBuilder.ApplyConfiguration(new UserLocationBranchConfiguration());

            modelBuilder.ApplyConfiguration(new GroupsConfiguration());

            modelBuilder.ApplyConfiguration(new RulesConfiguration());

            modelBuilder.ApplyConfiguration(new INSFunctionsConfiguration());

            #endregion INFPort
        }

        #region INFPort
     
        public DbSet<UserGroupUpdateStatusPort> UserGroupUpdateStatusPort { get; set; }
        public DbSet<UserGroups> UserGroups { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Rules> Rules { get; set; }
        public DbSet<INSFunctions> INSFunctions { get; set; }
        public DbSet<UserLocationBranch> UserLocationBranch { get; set; }

        #endregion INFPort
    }
}