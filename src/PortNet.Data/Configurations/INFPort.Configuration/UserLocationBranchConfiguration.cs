using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPort;

namespace PortNet.Data.Configurations.INFPort.Configuration
{
    public class UserLocationBranchConfiguration : IEntityTypeConfiguration<UserLocationBranch>
    {
        public void Configure(EntityTypeBuilder<UserLocationBranch> entity)
        {
            entity.HasIndex(e => e.BranchId);

            entity.HasIndex(e => e.LocationId);

            entity.HasIndex(e => new { e.UserId, e.BranchId })
                .HasName("_dta_index_UserLocationBranch_7_194099732__K2_K4");

            entity.HasIndex(e => new { e.UserId, e.LocationId })
                .HasName("_dta_index_UserLocationBranch_5_843254159__K2_K3");

            entity.HasIndex(e => new { e.UserId, e.LocationId, e.BranchId })
                .HasName("_dta_index_UserLocationBranch_5_843254159__K2_K3_K4");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.UserId).HasMaxLength(50);
        }
    }
}