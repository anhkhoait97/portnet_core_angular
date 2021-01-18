using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TrouteCableDetailConfiguration : IEntityTypeConfiguration<TrouteCableDetail>
    {
        public void Configure(EntityTypeBuilder<TrouteCableDetail> entity)
        {
            entity.ToTable("TRouteCableDetail");

            entity.HasIndex(e => e.CableName)
                .HasName("IX_TRouteCableDetail");

            entity.HasIndex(e => e.TubeName)
                .HasName("IX_TRouteCableDetail_1");

            entity.HasIndex(e => new { e.CableName, e.TubeName })
                .HasName("IX_TRouteCableDetail_2");

            entity.HasIndex(e => new { e.TubeName, e.CableName })
                .HasName("_dta_index_TRouteCableDetail_11_1472724299__K3_K2");

            entity.HasIndex(e => new { e.TubeName, e.Id, e.CableName })
                .HasName("_dta_index_TRouteCableDetail_11_1472724299__K3_K1_K2");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CableId).HasColumnName("CableID");

            entity.Property(e => e.CableName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContractId).HasColumnName("ContractID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Length)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TubeName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}