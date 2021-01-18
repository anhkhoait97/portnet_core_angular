using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TTubeDetailConfiguration : IEntityTypeConfiguration<TtubeDetail>
    {
        public void Configure(EntityTypeBuilder<TtubeDetail> entity)
        {
            entity.ToTable("TTubeDetail");

            entity.HasIndex(e => e.DeviceId)
                .HasName("IX_TTubeDetail");

            entity.HasIndex(e => e.Status)
                .HasName("IX_TTubeDetail_2");

            entity.HasIndex(e => new { e.DeviceId, e.Number })
                .HasName("IX_TTubeDetail_1");

            entity.HasIndex(e => new { e.Name, e.DeviceId, e.Type })
                .HasName("_dta_index_TTubeDetail_11_1536724527__K2_3_4");

            entity.HasIndex(e => new { e.DeviceId, e.Id, e.Type, e.MaterialId, e.ColorId, e.TypeTube, e.SiteId, e.Name, e.Description, e.CreateDate, e.CreateBy })
                .HasName("_dta_index_TTubeDetail_11_1536724527__K4_K1_K2_K10_K11_K8_K7_K3_K12_K13_K14");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.ColorId).HasColumnName("ColorID");

            entity.Property(e => e.CoordinatesXsectionEnd)
                .HasColumnName("CoordinatesXSectionEnd")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.CoordinatesXsectionStart)
                .HasColumnName("CoordinatesXSectionStart")
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComment("Tọa độ X điểm Pi trên mặt bể");

            entity.Property(e => e.CoordinatesYsectionEnd)
                .HasColumnName("CoordinatesYSectionEnd")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.CoordinatesYsectionStart)
                .HasColumnName("CoordinatesYSectionStart")
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComment("Tọa độ Y điểm Pi trên mặt bể");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(250);

            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SiteId).HasColumnName("SiteID");

            entity.Property(e => e.Type).HasComment("1: Đoạn ống, 2: Ống ngoi");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}