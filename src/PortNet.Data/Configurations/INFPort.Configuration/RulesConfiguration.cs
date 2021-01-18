using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPort;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortNet.Data.Configurations.INFPort.Configuration
{
    public class RulesConfiguration : IEntityTypeConfiguration<Rules>
    {
        public void Configure(EntityTypeBuilder<Rules> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn(2, 10);
            builder.Property(e => e.FunctionId).HasColumnType("Int").IsRequired();
            builder.Property(e => e.GroupId).HasColumnType("Int").IsRequired();
            builder.Property(e => e.AUpdate).HasColumnType("Tinyint").IsRequired();
            builder.Property(e => e.AInsert).HasColumnType("Tinyint").IsRequired();
            builder.Property(e => e.ARemove).HasColumnType("Tinyint").IsRequired();
            builder.Property(e => e.ADetail).HasColumnType("Tinyint").IsRequired();
        }
    }
}
