using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TBellowsFaceConfiguration : IEntityTypeConfiguration<TbellowsFace>
    {
        public void Configure(EntityTypeBuilder<TbellowsFace> entity)
        {
            entity.ToTable("TBellowsFace");

            entity.HasIndex(e => e.BellowsId)
                .HasName("IX_TBellowsFace");

            entity.HasIndex(e => e.NameFace)
                .HasName("IX_TBellowsFace_1");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BellowsId).HasColumnName("BellowsID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasComment("Nhập ghi chú mặt đó đang hướng về vị trí nào");

            entity.Property(e => e.FaceId).HasColumnName("FaceID");

            entity.Property(e => e.NameFace)
                .HasMaxLength(10)
                .HasComment("Măt của bể");

            entity.Property(e => e.Size).HasComment("Kích thước ma trận mỗi mặt");

            entity.Property(e => e.Type).HasComment("2: Bellow, 3: Ganivo");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}