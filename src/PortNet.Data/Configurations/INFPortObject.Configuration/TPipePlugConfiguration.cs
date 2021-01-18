using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TPipePlugConfiguration : IEntityTypeConfiguration<TpipePlug>
    {
        public void Configure(EntityTypeBuilder<TpipePlug> entity)
        {
            entity.ToTable("TPipePlug");

            entity.HasIndex(e => e.BranchId)
                .HasName("IX_TPipePlug_1");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_TPipePlug");

            entity.HasIndex(e => e.Name)
                .HasName("IX_TPipePlug_3");

            entity.HasIndex(e => e.StartDeviceId)
                .HasName("IX_TPipePlug_4");

            entity.HasIndex(e => e.TacitId)
                .HasName("IX_TPipePlug_2");

            entity.HasIndex(e => new { e.Length, e.Id })
                .HasName("_dta_index_TPipePlug_11_1408724071__K1_11");

            entity.HasIndex(e => new { e.Name, e.Length, e.TacitId, e.LocationId, e.BranchId, e.Id })
                .HasName("_dta_index_TPipePlug_11_1408724071__K5_K3_K4_K1_2_11");

            entity.HasIndex(e => new { e.TacitId, e.LocationId, e.BranchId, e.Id, e.OwnedId, e.District, e.Ward, e.StartDeviceName, e.Length, e.Plans, e.Street, e.DateUse })
                .HasName("_dta_index_TPipePlug_11_1408724071__K5_K3_K4_K1_K13_K17_K18_K9_K11_K6_K16_K20");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.DateUse).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(250);

            entity.Property(e => e.EndBranchId).HasColumnName("EndBranchID");

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

            entity.Property(e => e.StartConnectType).HasComment("2:Bể, 3 Ganivo, 4 Ngoi");

            entity.Property(e => e.StartDeviceId).HasColumnName("StartDeviceID");

            entity.Property(e => e.StartDeviceName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StartFaceId).HasColumnName("StartFaceID");

            entity.Property(e => e.Street).HasMaxLength(250);

            entity.Property(e => e.TacitId).HasColumnName("TacitID");

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