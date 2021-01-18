using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TarrayConfiguration : IEntityTypeConfiguration<Tarray>
    {
        public void Configure(EntityTypeBuilder<Tarray> entity)
        {
            entity.ToTable("TArray");

            entity.HasIndex(e => e.Parent)
                .HasName("IX_TArray_3");

            entity.HasIndex(e => e.Type)
                .HasName("IX_TArray_1");

            entity.HasIndex(e => e.ValuesId)
                .HasName("IX_TArray");

            entity.HasIndex(e => new { e.ValuesId, e.Type })
                .HasName("IX_TArray_2");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(100);

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.Property(e => e.Parent).HasDefaultValueSql("((0))");

            entity.Property(e => e.ValuesId).HasColumnName("ValuesID");
        }
    }
}