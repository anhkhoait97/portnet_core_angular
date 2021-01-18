using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TNumberPayConfiguration : IEntityTypeConfiguration<TnumberPay>
    {
        public void Configure(EntityTypeBuilder<TnumberPay> entity)
        {
            entity.ToTable("TNumberPay");

            entity.HasIndex(e => e.PayDate)
                .HasName("IX_TNumberPay_2");

            entity.HasIndex(e => e.TcontractId)
                .HasName("IX_TNumberPay");

            entity.HasIndex(e => new { e.TcontractId, e.NumberPay, e.PayDate })
                .HasName("IX_TNumberPay_1");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.AppendicesId).HasColumnName("AppendicesID");

            entity.Property(e => e.AppendicesName)
                .HasColumnName("Appendices_Name")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.DateConfim).HasColumnType("datetime");

            entity.Property(e => e.NumberPay)
                .HasColumnName("Number_Pay")
                .HasComment("Số đợt thanh toan theo chu kỳ");

            entity.Property(e => e.PayDate)
                .HasColumnType("datetime")
                .HasComment("Ngày thanh toán");

            entity.Property(e => e.StatusString).HasMaxLength(20);

            entity.Property(e => e.TcontractId).HasColumnName("TContractID");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.Property(e => e.UserConfim)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}