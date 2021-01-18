using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TManuaBilldingConfiguration : IEntityTypeConfiguration<TmanuaBillding>
    {
        public void Configure(EntityTypeBuilder<TmanuaBillding> entity)
        {
            entity.ToTable("TManuaBillding");

            entity.HasIndex(e => e.ContractId)
                .HasName("idx_contractID");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CableLength)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CableName).HasMaxLength(50);

            entity.Property(e => e.Capacity)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ContractId).HasColumnName("ContractID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.EndName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Formality).HasMaxLength(50);

            entity.Property(e => e.NameObject)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameTacit).HasMaxLength(100);

            entity.Property(e => e.OdccableType)
                .HasColumnName("ODCCableType")
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TacitCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeCable).HasMaxLength(50);

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}