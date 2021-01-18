using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TrouteCableConfiguration : IEntityTypeConfiguration<TrouteCable>
    {
        public void Configure(EntityTypeBuilder<TrouteCable> entity)
        {
            entity.ToTable("TRouteCable");

            entity.HasIndex(e => e.BranchId)
                .HasName("IX_TRouteCable_2");

            entity.HasIndex(e => e.DeviceId)
                .HasName("IX_TRouteCable_6");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_TRouteCable_1");

            entity.HasIndex(e => e.TacitId)
                .HasName("IX_TRouteCable_4");

            entity.HasIndex(e => e.Type)
                .HasName("IX_TRouteCable");

            entity.HasIndex(e => e.TypeCable)
                .HasName("IX_TRouteCable_7");

            entity.HasIndex(e => e.TypeDevice)
                .HasName("IX_TRouteCable_3");

            entity.HasIndex(e => e.TypeObject)
                .HasName("IX_TRouteCable_5");

            entity.HasIndex(e => new { e.Type, e.TacitId, e.Id, e.CableName })
                .HasName("_dta_index_TRouteCable_11_1440724185__K4_K14_K1_K11");

            entity.HasIndex(e => new { e.LocationId, e.Type, e.TacitId, e.BranchId, e.Id, e.CableName })
                .HasName("_dta_index_TRouteCable_11_1440724185__K2_K4_K14_K3_K1_K11");

            entity.HasIndex(e => new { e.Type, e.PartnerNameId, e.OdccableType, e.CableName, e.LocationId, e.BranchId })
                .HasName("_dta_index_TRouteCable_11_1440724185__K11_K2_K3_4_5_19");

            entity.HasIndex(e => new { e.Id, e.Type, e.PartnerNameId, e.TypeCable, e.Capacity, e.LocationId, e.BranchId, e.CableName })
                .HasName("_dta_index_TRouteCable_11_1440724185__K2_K3_K11_1_4_5_6_7");

            entity.HasIndex(e => new { e.TypeCable, e.CableName, e.LocationId, e.Id, e.PartnerNameId, e.BranchId, e.Type, e.Capacity })
                .HasName("_dta_index_TRouteCable_11_1440724185__K11_K2_K1_K5_K3_K4_K7_6");

            entity.HasIndex(e => new { e.CreateDate, e.CreateBy, e.TypeCable, e.NameObject, e.EndName, e.OdccableType, e.TacitId, e.LocationId, e.Type, e.BranchId, e.Id, e.CableName, e.Capacity, e.PartnerNameId })
                .HasName("_dta_index_TRouteCable_11_1440724185__K14_K2_K4_K3_K1_K11_K7_K5_6_17_18_19_22_23");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.CableId).HasColumnName("CableID");

            entity.Property(e => e.CableLength)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CableName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContractId).HasColumnName("ContractID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.DateUse).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(250);

            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

            entity.Property(e => e.DeviceName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Direction).HasComment("1: chiều xuôi (đầu -> cuối) , 2:chiều ngược (cuối -> đầu)");

            entity.Property(e => e.EndName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FullPiSize).HasComment("Đường kính lấy từ TList(Type =7)");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.NameObject)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OdccableType)
                .HasColumnName("ODCCableType")
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.PartnerNameId).HasColumnName("PartnerNameID");

            entity.Property(e => e.PiFullFlag).HasComment("1: FullPi, 0: Cáp");

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

            entity.Property(e => e.TacitName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Type).HasComment("1: FTEL, 2: Đối tác");

            entity.Property(e => e.TypeCable).HasComment("1: Đồng, 2: Quang, 3: Đồng trục");

            entity.Property(e => e.TypeCount).HasComment("0 : Bình thường, 1: Phạt");

            entity.Property(e => e.TypeDevice).HasComment("1: Pop, 2: Ring");

            entity.Property(e => e.TypeObject).HasComment("1: Bể, 2: Ganivo");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}