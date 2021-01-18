using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class CmListConfiguration : IEntityTypeConfiguration<Cmlist>
    {
        public void Configure(EntityTypeBuilder<Cmlist> entity)
        {
            entity.ToTable("CMList");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.IndexR).HasColumnName("indexR");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.Property(e => e.Type).HasComment("1: Tình Trạng, 2: ServiceIT");
        }
    }
}