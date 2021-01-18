using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TContractConfiguration : IEntityTypeConfiguration<Tcontract>
    {
        public void Configure(EntityTypeBuilder<Tcontract> entity)
        {
            entity.ToTable("TContract");

            entity.HasIndex(e => e.BranchId)
                .HasName("IX_TContract_2");

            entity.HasIndex(e => e.ContractName)
                .HasName("IX_TContract");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_TContract_1");

            entity.HasIndex(e => e.SignDate)
                .HasName("IX_TContract_4");

            entity.HasIndex(e => e.TacitId)
                .HasName("IX_TContract_3");

            entity.HasIndex(e => e.Type)
                .HasName("IX_TContract_5");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Appendices)
                .HasMaxLength(50)
                .HasComment("Phu luc hop dong");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.CommandEndDate).HasColumnType("datetime");

            entity.Property(e => e.CommandStartDate).HasColumnType("datetime");

            entity.Property(e => e.ContractName)
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.CyclePay).HasColumnName("Cycle_Pay");

            entity.Property(e => e.Description).HasMaxLength(250);

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasComment("Ngày kết thúc");

            entity.Property(e => e.Infmaintain)
                .HasColumnName("INFMaintain")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.IsFile).HasMaxLength(10);

            entity.Property(e => e.IsSpecial).HasComment("0: Hop dong bình thường, 1: Hợp đồng đặc biệt");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.NameBranch).HasMaxLength(50);

            entity.Property(e => e.NumberPay).HasColumnName("Number_Pay");

            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.Property(e => e.SignDate)
                .HasColumnType("datetime")
                .HasComment("Ngày ký HD");

            entity.Property(e => e.StatusPay).HasComment("Tình trạng thanh toán");

            entity.Property(e => e.SumValuesReal)
                .HasColumnName("Sum_Values_Real")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SumValuesRefer)
                .HasColumnName("Sum_Values_Refer")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

            entity.Property(e => e.Type).HasComment("Loại HD");

            entity.Property(e => e.TypeContract).HasComment("0: HĐ Cho Thuê;  1: HĐ Đi Thuê");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.Property(e => e.Vat).HasColumnName("VAT");
        }
    }
}