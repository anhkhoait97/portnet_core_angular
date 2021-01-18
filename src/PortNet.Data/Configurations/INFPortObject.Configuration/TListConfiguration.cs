using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TListConfiguration : IEntityTypeConfiguration<Tlist>
    {
        public void Configure(EntityTypeBuilder<Tlist> entity)
        {
            entity.ToTable("TList");

            entity.HasIndex(e => e.Name)
                .HasName("IX_TTypeList_1");

            entity.HasIndex(e => e.Type)
                .HasName("IX_TTypeList");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(500);

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.Property(e => e.Type).HasComment("1 : Hình dạng bể , 2 : Hình dạng nấp đang , 3 : Chất liệu , 4 : Tình trạng");
        }
    }
}