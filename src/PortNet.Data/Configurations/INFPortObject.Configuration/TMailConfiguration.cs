using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TMailConfiguration : IEntityTypeConfiguration<Tmail>
    {
        public void Configure(EntityTypeBuilder<Tmail> entity)
        {
            entity.ToTable("TMail");

            entity.HasIndex(e => e.BranchId)
                .HasName("IX_TMail_2");

            entity.HasIndex(e => e.LocationId)
                .HasName("IX_TMail_3");

            entity.HasIndex(e => e.Type)
                .HasName("IX_TMail_1");

            entity.HasIndex(e => e.TypeMail)
                .HasName("IX_TMail");

            entity.HasIndex(e => new { e.LocationId, e.BranchId, e.Type, e.TypeMail })
                .HasName("IX_TMail_4");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.Note).HasMaxLength(200);

            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.Property(e => e.Type).HasComment("1: MailTo | 2: MailCC");
        }
    }
}