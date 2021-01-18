using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPort;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortNet.Data.Configurations.INFPort.Configuration
{
    public class INSFunctionsConfiguration : IEntityTypeConfiguration<INSFunctions>
    {
        public void Configure(EntityTypeBuilder<INSFunctions> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn(1, 1);
            builder.Property(e => e.Date).HasColumnType("DateTime").IsRequired();
            builder.Property(e => e.Description).HasColumnType("NVarChar").IsRequired().HasMaxLength(50);
            builder.Property(e => e.Visible).HasColumnType("Tinyint").IsRequired();
            builder.Property(e => e.RefPath).HasColumnType("Varchar").HasMaxLength(144);
            builder.Property(e => e.Parent).HasColumnType("Int").IsRequired();
            builder.Property(e => e.Type).HasColumnType("Tinyint").IsRequired();
            builder.Property(e => e.Level).HasColumnType("Smallint").IsRequired();
            builder.Property(e => e.Level_1).HasColumnType("Smallint").IsRequired();
            builder.Property(e => e.Param).HasColumnType("Varchar").HasMaxLength(255);
            builder.Property(e => e.IsType).HasColumnType("Int");
            builder.Property(e => e.RefPathNew).HasColumnType("Varchar").HasMaxLength(500);
        }
    }
}
