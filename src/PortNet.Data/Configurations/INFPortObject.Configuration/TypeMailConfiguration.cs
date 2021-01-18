using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TypeMailConfiguration : IEntityTypeConfiguration<TypeMail>
    {
        public void Configure(EntityTypeBuilder<TypeMail> entity)
        {
            entity.ToTable("TypeMail");

            entity.HasIndex(e => new { e.TypeCondition, e.RuleTime, e.Approved })
                    .HasName("IX_TypeMail");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Approved).HasComment("0: Chưa dùng.1 : Là dùng");

            entity.Property(e => e.BodyFirst).HasMaxLength(250);

            entity.Property(e => e.BodyFtn).HasColumnName("BodyFTN");

            entity.Property(e => e.BodyFts).HasColumnName("BodyFTS");

            entity.Property(e => e.Condition).HasMaxLength(50);

            entity.Property(e => e.Description).HasMaxLength(250);

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.Property(e => e.RuleTime).HasComment("1: Tháng. 2: Tuần, 3: Ngày");

            entity.Property(e => e.TitleMailEnd).HasMaxLength(250);

            entity.Property(e => e.TitleMailFirst).HasMaxLength(250);

            entity.Property(e => e.TypeCondition).HasComment("Định kỳ/ Accion");
        }
    }
}