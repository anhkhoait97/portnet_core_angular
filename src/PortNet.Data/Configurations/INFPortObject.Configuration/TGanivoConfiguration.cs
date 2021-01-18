using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TGanivoConfiguration : IEntityTypeConfiguration<Tganivo>
    {
        public void Configure(EntityTypeBuilder<Tganivo> entity)
        {
            entity.ToTable("TGanivo");

            entity.HasIndex(e => e.BranchId)
                .HasName("IX_TGanivo_1");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_TGanivo");

            entity.HasIndex(e => e.Name)
                .HasName("IX_TGanivo_2");

            entity.HasIndex(e => e.TypeConnect)
                .HasName("IX_TGanivo_3");

            entity.HasIndex(e => new { e.LocationId, e.BranchId })
                .HasName("IX_TGanivo_4");

            entity.HasIndex(e => new { e.Name, e.LocationId, e.BranchId, e.Id, e.TacitId })
                .HasName("_dta_index_TGanivo_11_1344723843__K3_K4_K1_K5_2");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.DateUse).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(250);

            entity.Property(e => e.DifferentName)
                .HasMaxLength(50)
                .HasComment("Tên thay thế của ganivo");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OwnedId).HasColumnName("OwnedID");

            entity.Property(e => e.Plans)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PointConnectId).HasColumnName("PointConnectID");

            entity.Property(e => e.PointConnectName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ShapeGanivoId).HasColumnName("ShapeGanivoID");

            entity.Property(e => e.ShapeLidId).HasColumnName("ShapeLidID");

            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Street).HasMaxLength(250);

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

            entity.Property(e => e.TypeConnect).HasComment("2:  Bể,3 : Ganivo,4 Ngoi");

            entity.Property(e => e.TypeDevice).HasComment("1: Ganivo rẽ nhánh, 2: Ganivo thẳng, 3: Ganivo đầu tiên");

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