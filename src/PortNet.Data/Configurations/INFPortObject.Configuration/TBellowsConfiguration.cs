using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TBellowsConfiguration : IEntityTypeConfiguration<Tbellows>
    {
        public void Configure(EntityTypeBuilder<Tbellows> entity)
        {
            entity.ToTable("TBellows");

            entity.HasIndex(e => e.BranchId)
                .HasName("IX_TBellows_1");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_TBellows");

            entity.HasIndex(e => e.Name)
                .HasName("IX_TBellows_2");

            entity.HasIndex(e => e.Plans)
                .HasName("IX_TBellows_5");

            entity.HasIndex(e => e.TypeConnect)
                .HasName("IX_TBellows_3");

            entity.HasIndex(e => new { e.LocationId, e.BranchId, e.Name, e.TypeConnect })
                .HasName("IX_TBellows_4");

            entity.HasIndex(e => new { e.Name, e.TacitId, e.LocationId, e.BranchId })
                .HasName("_dta_index_TBellows_11_1312723729__K5_K3_K4_2");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.DateUse).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(350);

            entity.Property(e => e.DifferentName)
                .HasMaxLength(50)
                .HasComment("Tên thay thế của bể");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.MaterialId)
                .HasColumnName("MaterialID")
                .HasComment("Chất liệu");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Mã bể");

            entity.Property(e => e.OwnedId).HasColumnName("OwnedID");

            entity.Property(e => e.Plans).HasMaxLength(50);

            entity.Property(e => e.PointConnectId).HasColumnName("PointConnectID");

            entity.Property(e => e.PointConnectName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ShapeBellowsId).HasColumnName("ShapeBellowsID");

            entity.Property(e => e.ShapeLidId).HasColumnName("ShapeLidID");

            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Kích thước");

            entity.Property(e => e.Street).HasMaxLength(250);

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

            entity.Property(e => e.TypeConnect).HasComment("1: Công trình, 2: Bể , 3 Ganivo, 4 Ngoi");

            entity.Property(e => e.TypeDevice).HasComment("1: Bể rẽ nhánh, 2: Bể thẳng, 3: Bể đầu tiên");

            entity.Property(e => e.TypeObject).HasComment("1: Bình thường, 2: Ảo, 3: Trung gian");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.Property(e => e.Xcoordinate)
                .HasColumnName("XCoordinate")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Ycoordinate)
                .HasColumnName("YCoordinate")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}