using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPort;

namespace PortNet.Data.Configurations.INFPort.Configuration
{
    public class UserGroupsConfiguration : IEntityTypeConfiguration<UserGroups>
    {
        public void Configure(EntityTypeBuilder<UserGroups> entity)
        {
            entity.HasIndex(e => e.GroupId)
                  .HasName("IX_UserGroups_1");

            entity.HasIndex(e => e.UserId)
                .HasName("IX_UserGroups");

            entity.HasIndex(e => new { e.GroupId, e.UserId })
                .HasName("IX_UserGroups_2");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");

            entity.Property(e => e.UserId)
                .IsRequired()
                .HasColumnName("UserID")
                .HasMaxLength(50);
        }
    }
}