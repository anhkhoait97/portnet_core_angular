using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TContractAppendicesConfiguration : IEntityTypeConfiguration<TcontractAppendices>
    {
        public void Configure(EntityTypeBuilder<TcontractAppendices> entity)
        {
            entity.ToTable("TContractAppendices");

            entity.HasIndex(e => e.Name)
                .HasName("IX_TContractAppendices_2");

            entity.HasIndex(e => e.PartnerId)
                .HasName("IX_TContractAppendices_1");

            entity.HasIndex(e => e.TcontractId)
                .HasName("IX_TContractAppendices");

            entity.HasIndex(e => new { e.Name, e.TcontractId })
                .HasName("IX_TContractAppendices_3");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.CyclePay).HasColumnName("Cycle_Pay");

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NumberPay).HasColumnName("Number_Pay");

            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.Property(e => e.StatusPay).HasComment("1: Chưa thanh toán, 2: Đã thanh toán");

            entity.Property(e => e.TcontractId).HasColumnName("TContractID");

            entity.Property(e => e.TotalReal)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}