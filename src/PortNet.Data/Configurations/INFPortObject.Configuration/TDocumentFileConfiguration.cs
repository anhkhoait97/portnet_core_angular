using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TDocumentFileConfiguration : IEntityTypeConfiguration<TdocumentFile>
    {
        public void Configure(EntityTypeBuilder<TdocumentFile> entity)
        {
            entity.ToTable("TDocumentFile");

            entity.HasIndex(e => e.FileName)
                .HasName("IX_TDocumentFile_1");

            entity.HasIndex(e => e.LinkFile)
                .HasName("IX_TDocumentFile_2");

            entity.HasIndex(e => e.TdocumentId)
                .HasName("IX_TDocumentFile");

            entity.HasIndex(e => new { e.TdocumentId, e.FileName, e.LinkFile })
                .HasName("IX_TDocumentFile_3");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.FileName).HasMaxLength(100);

            entity.Property(e => e.LinkFile).HasMaxLength(200);

            entity.Property(e => e.TdocumentId).HasColumnName("TDocumentID");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}