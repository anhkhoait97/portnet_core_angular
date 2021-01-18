using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TContractDetailConfiguration : IEntityTypeConfiguration<TcontractDetail>
    {
        public void Configure(EntityTypeBuilder<TcontractDetail> entity)
        {
            entity.ToTable("TContractDetail");

            entity.HasIndex(e => e.CodeTacit)
                .HasName("IX_TContractDetail_2");

            entity.HasIndex(e => e.TacitId)
                .HasName("IX_TContractDetail_1");

            entity.HasIndex(e => e.TcontractId)
                .HasName("IX_TContractDetail");

            entity.HasIndex(e => new { e.TacitId, e.TcontractId })
                .HasName("IX_TContractDetail_3");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CodeTacit)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

            entity.Property(e => e.TcontractId).HasColumnName("TContractID");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}