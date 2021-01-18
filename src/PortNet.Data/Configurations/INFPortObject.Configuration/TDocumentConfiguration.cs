using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TDocumentConfiguration : IEntityTypeConfiguration<Tdocument>
    {
        public void Configure(EntityTypeBuilder<Tdocument> entity)
        {
            entity.ToTable("TDocument");

            entity.HasIndex(e => e.BranchId)
                .HasName("IX_TDocument_1");

            entity.HasIndex(e => e.Code)
                .HasName("IX_TDocument_4");

            entity.HasIndex(e => e.IsFile)
                .HasName("IX_TDocument_7");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_TDocument");

            entity.HasIndex(e => e.Name)
                .HasName("IX_TDocument_3");

            entity.HasIndex(e => e.StartDate)
                .HasName("IX_TDocument_6");

            entity.HasIndex(e => e.Status)
                .HasName("IX_TDocument_5");

            entity.HasIndex(e => new { e.LocationId, e.BranchId })
                .HasName("IX_TDocument_2");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId)
                .HasColumnName("BranchID")
                .HasComment("0: Là thuộc tất cả CN của vùng miền");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasComment("Ma cong văn");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(250);

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.Extension).HasComment("So lần gia han");

            entity.Property(e => e.IsFile).HasMaxLength(10);

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Danh muc don gia");

            entity.Property(e => e.NameBranch).HasMaxLength(50);

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.Property(e => e.Status).HasComment("1: Bình thường, 2: Đóng băng");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}