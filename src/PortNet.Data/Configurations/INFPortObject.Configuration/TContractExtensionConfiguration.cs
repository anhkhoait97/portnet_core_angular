using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TContractExtensionConfiguration : IEntityTypeConfiguration<TcontractExtension>
    {
        public void Configure(EntityTypeBuilder<TcontractExtension> entity)
        {
            entity.ToTable("TContractExtension");

            entity.HasIndex(e => e.EndDate)
                .HasName("IX_TContractExtension_3");

            entity.HasIndex(e => e.Extension)
                .HasName("IX_TContractExtension_1");

            entity.HasIndex(e => e.SignDate)
                .HasName("IX_TContractExtension_2");

            entity.HasIndex(e => e.TcontractId)
                .HasName("IX_TContractExtension");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.SignDate).HasColumnType("datetime");

            entity.Property(e => e.TcontractId).HasColumnName("TContractID");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}