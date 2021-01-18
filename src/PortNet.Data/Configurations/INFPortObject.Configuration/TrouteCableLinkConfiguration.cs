using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TrouteCableLinkConfiguration : IEntityTypeConfiguration<TrouteCableLink>
    {
        public void Configure(EntityTypeBuilder<TrouteCableLink> entity)
        {
            entity.HasNoKey();

            entity.ToTable("TRouteCableLink");

            entity.HasIndex(e => e.BellowId)
                .HasName("idx_TRouteCableLink_BellowID");

            entity.HasIndex(e => e.Id)
                .HasName("idx_TRouteCableLink_ID");

            entity.Property(e => e.BellowId).HasColumnName("BellowID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}