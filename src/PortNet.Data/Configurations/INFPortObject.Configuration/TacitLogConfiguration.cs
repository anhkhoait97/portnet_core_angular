using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TacitLogConfiguration : IEntityTypeConfiguration<TacitLog>
    {
        public void Configure(EntityTypeBuilder<TacitLog> entity)
        {
            entity.ToTable("TacitLog");

            entity.HasIndex(e => e.Code)
                    .HasName("IX_TacitLog_1");

            entity.HasIndex(e => e.FileName)
                .HasName("IX_TacitLog_3");

            entity.HasIndex(e => e.Name)
                .HasName("IX_TacitLog_2");

            entity.HasIndex(e => e.TacitId)
                .HasName("IX_TacitLog");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Code).HasMaxLength(50);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(50);

            entity.Property(e => e.FileName).HasMaxLength(350);

            entity.Property(e => e.Name).HasMaxLength(250);

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}