using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TTubeConfiguration : IEntityTypeConfiguration<Ttube>
    {
        public void Configure(EntityTypeBuilder<Ttube> entity)
        {
            entity.ToTable("TTube");

            entity.HasIndex(e => e.BranchId)
                .HasName("IX_TTube_1");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_TTube");

            entity.HasIndex(e => e.Name)
                .HasName("IX_TTube_2");

            entity.HasIndex(e => e.StartDeviceId)
                .HasName("IX_TTube_4");

            entity.HasIndex(e => e.TacitId)
                .HasName("IX_TTube_3");

            entity.HasIndex(e => new { e.Length, e.Id })
                .HasName("_dta_index_TTube_11_1504724413__K1_14");

            entity.HasIndex(e => new { e.LocationId, e.BranchId, e.TacitId })
                .HasName("_dta_index_TTube_11_1504724413__K3_K4_K5");

            entity.HasIndex(e => new { e.Name, e.Length, e.TacitId, e.LocationId, e.BranchId })
                .HasName("_dta_index_TTube_11_1504724413__K5_K3_K4_2_14");

            entity.HasIndex(e => new { e.TacitId, e.LocationId, e.BranchId, e.Id, e.OwnedId, e.StartDeviceName, e.EndDeviceName, e.Length, e.Plans, e.DateUse })
                .HasName("_dta_index_TTube_11_1504724413__K5_K3_K4_K1_K15_K9_K12_K14_K6_K16");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.DateUse).HasColumnType("datetime");

            entity.Property(e => e.EndBranchId).HasColumnName("EndBranchID");

            entity.Property(e => e.EndDeviceId).HasColumnName("EndDeviceID");

            entity.Property(e => e.EndDeviceName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EndFaceId).HasColumnName("EndFaceID");

            entity.Property(e => e.EndTacitId).HasColumnName("EndTacitID");

            entity.Property(e => e.Length)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OwnedId).HasColumnName("OwnedID");

            entity.Property(e => e.Plans)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PopName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDeviceId).HasColumnName("StartDeviceID");

            entity.Property(e => e.StartDeviceName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StartFaceId).HasColumnName("StartFaceID");

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

            entity.Property(e => e.TubeType).HasComment("1: Bình thường, 2: Ống bổ sung");

            entity.Property(e => e.Type).HasComment("1: Đơn công trình, 2: Liên công trình");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}