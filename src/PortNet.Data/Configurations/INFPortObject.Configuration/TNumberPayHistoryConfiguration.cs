using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Configurations.INFPortObject.Configuration
{
    public class TNumberPayHistoryConfiguration : IEntityTypeConfiguration<TnumberPayHistory>
    {
        public void Configure(EntityTypeBuilder<TnumberPayHistory> entity)
        {
            entity.HasNoKey();

            entity.ToTable("TNumberPayHistory");

            entity.Property(e => e.ContractName).HasMaxLength(100);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NumberPayId).HasColumnName("NumberPayID");

            entity.Property(e => e.PayDate).HasColumnType("datetime");

            entity.Property(e => e.StatusString).HasMaxLength(100);

            entity.Property(e => e.TcontractId).HasColumnName("TContractID");

            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        }
    }
}