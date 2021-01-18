using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPort;
using System;

namespace PortNet.Data.Configurations.INFPort.Configuration
{
    public class GroupsConfiguration : IEntityTypeConfiguration<Groups>
    {
        public void Configure(EntityTypeBuilder<Groups> entity)
        {
            entity.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            entity.Property<DateTime>("Date")
                .HasColumnType("datetime2");

            entity.Property<byte>("Enabled")
                .HasColumnType("tinyint");

            entity.Property<string>("FullName")
                .HasColumnType("nvarchar(max)");

            entity.Property<string>("GroupName")
                .HasColumnType("nvarchar(max)");

            entity.Property<long?>("ID_GroupRight")
                .HasColumnType("bigint");

            entity.Property<short?>("LocationID")
                .HasColumnType("smallint");

            entity.HasKey("ID");

            entity.ToTable("Groups");
        }
    }
}