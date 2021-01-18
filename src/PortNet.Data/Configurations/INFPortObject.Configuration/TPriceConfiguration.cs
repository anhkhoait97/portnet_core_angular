using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TPriceConfiguration : IEntityTypeConfiguration<Tprice>
    {
        public void Configure(EntityTypeBuilder<Tprice> entity)
        {
            entity.ToTable("TPrice");

            entity.HasIndex(e => e.BranchId)
                .HasName("IX_TPrice_1");

            entity.HasIndex(e => e.FormalityRent)
                .HasName("IX_TPrice_4");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_TPrice");

            entity.HasIndex(e => e.Size)
                .HasName("IX_TPrice_5");

            entity.HasIndex(e => e.TdocumentId)
                .HasName("IX_TPrice_2");

            entity.HasIndex(e => e.Type)
                .HasName("IX_TPrice_3");

            entity.HasIndex(e => new { e.LocationId, e.BranchId })
                .HasName("IX_TPrice_6");

            entity.HasIndex(e => new { e.LocationId, e.BranchId, e.TdocumentId })
                .HasName("IX_TPrice_7");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(150);

            entity.Property(e => e.Diameter)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Đường kính");

            entity.Property(e => e.FormalityRent)
                .HasColumnName("Formality_Rent")
                .HasComment("Hình thức thuê.  ( 1: Thuê full ống / 2: Thuê nguyên hầm / 3:Thuê theo cáp/ 4:Thuê ống ngoi toàn tuyến)");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NameBranch).HasMaxLength(50);

            entity.Property(e => e.PenaltPrice)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Position).HasComment("Vị trí");

            entity.Property(e => e.Price)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Kich thước");

            entity.Property(e => e.TdocumentId).HasColumnName("TDocumentID");

            entity.Property(e => e.Type).HasComment("Loại hình: ");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}