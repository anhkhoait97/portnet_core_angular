using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TLogHistoryFileConfiguration : IEntityTypeConfiguration<TlogHistoryFile>
    {
        public void Configure(EntityTypeBuilder<TlogHistoryFile> entity)
        {
            entity.ToTable("TLogHistoryFile");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Description).HasMaxLength(250);

            entity.Property(e => e.NameFile)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}