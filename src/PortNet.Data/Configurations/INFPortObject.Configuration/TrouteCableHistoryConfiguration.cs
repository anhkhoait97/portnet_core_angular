using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TrouteCableHistoryConfiguration : IEntityTypeConfiguration<TrouteCableHistory>
    {
        public void Configure(EntityTypeBuilder<TrouteCableHistory> entity)
        {
            entity.ToTable("TRouteCableHistory");

            entity.HasIndex(e => e.BranchId)
                .HasName("IX_TRouteCableHistory_1");

            entity.HasIndex(e => e.CableName)
                .HasName("IX_TRouteCableHistory_4");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_TRouteCableHistory");

            entity.HasIndex(e => e.Type)
                .HasName("IX_TRouteCableHistory_3");

            entity.HasIndex(e => new { e.TacitId, e.TacitName })
                .HasName("IX_TRouteCableHistory_5");

            entity.HasIndex(e => new { e.TypeDevice, e.DeviceName })
                .HasName("IX_TRouteCableHistory_2");

            entity.HasIndex(e => new { e.TypeObject, e.NameObject })
                .HasName("IX_TRouteCableHistory_6");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.CableId).HasColumnName("CableID");

            entity.Property(e => e.CableLength)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CableName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContractId).HasColumnName("ContractID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.DeletedDate).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(250);

            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

            entity.Property(e => e.DeviceName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EndName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.NameObject)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OdccableType)
                .HasColumnName("ODCCableType")
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.PartnerNameId).HasColumnName("PartnerNameID");

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

            entity.Property(e => e.TacitName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TrouteCableId).HasColumnName("TRouteCableID");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}