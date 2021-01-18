using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPort;

namespace PortNet.Data.Configurations.INFPort.Configuration
{
    public class UserGroupUpdateStatusPortConfiguration : IEntityTypeConfiguration<UserGroupUpdateStatusPort>
    {
        public void Configure(EntityTypeBuilder<UserGroupUpdateStatusPort> entity)
        {
            entity.HasIndex(e => e.GroupId)
                   .HasName("IX_UserGroupUpdateStatusPort");

            entity.HasIndex(e => e.UserName)
                .HasName("IX_UserGroupUpdateStatusPort_1");

            entity.HasIndex(e => new { e.GroupId, e.UserName })
                .HasName("IX_UserGroupUpdateStatusPort_2");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");

            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}