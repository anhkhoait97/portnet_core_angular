using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TPartnerConfiguration : IEntityTypeConfiguration<Tpartner>
    {
        public void Configure(EntityTypeBuilder<Tpartner> entity)
        {
            entity.ToTable("TPartner");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(1000);

            entity.Property(e => e.EmailKey1).HasMaxLength(50);

            entity.Property(e => e.EmailKey2).HasMaxLength(50);

            entity.Property(e => e.EmailManager).HasMaxLength(50);

            entity.Property(e => e.FullNameKey1).HasMaxLength(50);

            entity.Property(e => e.FullNameKey2).HasMaxLength(50);

            entity.Property(e => e.FullNameManager).HasMaxLength(50);

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.Name).HasMaxLength(200);

            entity.Property(e => e.OldId).HasColumnName("OldID");

            entity.Property(e => e.PhoneKey1).HasMaxLength(50);

            entity.Property(e => e.PhoneKey2).HasMaxLength(50);

            entity.Property(e => e.PhoneManager).HasMaxLength(50);

            entity.Property(e => e.PositionKey1).HasMaxLength(50);

            entity.Property(e => e.PositionKey2).HasMaxLength(50);

            entity.Property(e => e.PositionManager).HasMaxLength(50);

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}