using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TacitFileConfiguration : IEntityTypeConfiguration<TacitFile>
    {
        public void Configure(EntityTypeBuilder<TacitFile> entity)
        {
            entity.ToTable("TacitFile");

            entity.HasNoKey();

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.FileName).HasMaxLength(100);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LinkFile).HasMaxLength(200);

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}