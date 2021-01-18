using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortNet.Model.Common;
using PortNet.Model.Entities.INFPort;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PortNet.Data.Migrations
{
    public abstract class ApplicationDbContext : IdentityDbContext<Users>
    {
        protected ApplicationDbContext(DbContextOptions options) : base(options) { }

        /// <summary>
        /// SaveChangesAsync
        /// Create New DateTime
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<AuditableEntity> entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreateDate = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.CreateDate = DateTime.Now;
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}