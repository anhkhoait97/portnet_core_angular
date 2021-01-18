using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class THistoryWithDrawConfiguration : IEntityTypeConfiguration<ThistoryWithDraw>
    {
        public void Configure(EntityTypeBuilder<ThistoryWithDraw> entity)
        {
            entity.ToTable("THistoryWithDraw");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId)
                .HasColumnName("BranchID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.DeviceName)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Ip)
                .HasColumnName("IP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.TacitName)
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}