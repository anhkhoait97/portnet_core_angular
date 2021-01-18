using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TacitConfiguration : IEntityTypeConfiguration<Tacit>
    {
        public void Configure(EntityTypeBuilder<Tacit> entity)
        {
            entity.ToTable("Tacit");

            entity.HasIndex(e => e.BuildingId)
                   .HasName("IX_Tacit_9");

            entity.HasIndex(e => e.Code)
                .HasName("IX_Tacit_3");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_Tacit");

            entity.HasIndex(e => e.Name)
                .HasName("IX_Tacit_2");

            entity.HasIndex(e => e.Plans)
                .HasName("IX_Tacit_4");

            entity.HasIndex(e => e.Street)
                .HasName("IX_Tacit_5");

            entity.HasIndex(e => e.TypeBuilding)
                .HasName("IX_Tacit_8");

            entity.HasIndex(e => new { e.LocationId, e.BranchId })
                .HasName("IX_Tacit_1");

            entity.HasIndex(e => new { e.LocationId, e.Code })
                .HasName("IX_Tacit_7");

            entity.HasIndex(e => new { e.LocationId, e.Name })
                .HasName("IX_Tacit_6");

            entity.HasIndex(e => new { e.LocationId, e.BranchId, e.TypeBuilding, e.BuildingId })
                .HasName("IX_Tacit_10");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");

            entity.Property(e => e.BuildingName).HasMaxLength(250);

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasComment("Mã công trình");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(300);

            entity.Property(e => e.EndName).HasMaxLength(250);

            entity.Property(e => e.EndNameDistrict).HasColumnName("EndName_District");

            entity.Property(e => e.EndNameWard).HasColumnName("EndName_Ward");

            entity.Property(e => e.FinishQuarter).HasColumnName("Finish_Quarter");

            entity.Property(e => e.FinishYear).HasColumnName("Finish_Year");

            entity.Property(e => e.Flag).HasComment("< 2: cho upload file, =2 không thể upload file");

            entity.Property(e => e.Infmaintail)
                .HasColumnName("INFMaintail")
                .HasMaxLength(50);

            entity.Property(e => e.InvestCosts)
                .HasColumnName("Invest_Costs")
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("Chi phí đầu tư (trieu), duoc nhap so thap phân");

            entity.Property(e => e.InvestId).HasColumnName("InvestID");

            entity.Property(e => e.IsFile)
                .HasMaxLength(10)
                .HasComment("Có file, không có file");

            entity.Property(e => e.Length)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("Chiều dài (m), duoc nhap so thap phân");

            entity.Property(e => e.LinkDesign).HasMaxLength(250);

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.ManagerUnitId).HasColumnName("ManagerUnitID");

            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasComment("tên công trình");

            entity.Property(e => e.Plans).HasMaxLength(50);

            entity.Property(e => e.RentalCost)
                .HasColumnName("Rental_Cost")
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("Chi phí thuê hàng tháng (triệu), duoc nhap so thap phân");

            entity.Property(e => e.StartName).HasMaxLength(250);

            entity.Property(e => e.StartNameDistrict).HasColumnName("StartName_District");

            entity.Property(e => e.StartNameWard).HasColumnName("StartName_Ward");

            entity.Property(e => e.StartUpQuarter).HasColumnName("StartUp_Quarter");

            entity.Property(e => e.StartUpYear).HasColumnName("StartUp_Year");

            entity.Property(e => e.Street)
                .HasMaxLength(350)
                .HasComment("Tuyến đường");

            entity.Property(e => e.StreetDistrict).HasColumnName("Street_District");

            entity.Property(e => e.StreetWard).HasColumnName("Street_Ward");

            entity.Property(e => e.TypeBuilding).HasComment("1: Thuoc building, 0: Khong thuoc building");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}