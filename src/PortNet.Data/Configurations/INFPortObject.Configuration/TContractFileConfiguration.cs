using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TContractFileConfiguration : IEntityTypeConfiguration<TcontractFile>
    {
        public void Configure(EntityTypeBuilder<TcontractFile> entity)
        {
            entity.ToTable("TContractFile");

            entity.HasIndex(e => e.Description)
                .HasName("IX_TContractFile_4");

            entity.HasIndex(e => e.FileName)
                .HasName("IX_TContractFile_1");

            entity.HasIndex(e => e.LinkFile)
                .HasName("IX_TContractFile_3");

            entity.HasIndex(e => e.TcontractId)
                .HasName("IX_TContractFile");

            entity.HasIndex(e => e.Type)
                .HasName("IX_TContractFile_2");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(100);

            entity.Property(e => e.FileName).HasMaxLength(100);

            entity.Property(e => e.LinkFile).HasMaxLength(200);

            entity.Property(e => e.TcontractId).HasColumnName("TContractID");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}