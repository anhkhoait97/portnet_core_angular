using Microsoft.EntityFrameworkCore;
using PortNet.Data.Configurations.INFPortObject.Configuration;
using PortNet.Model.Entities.INFPortObject;

namespace PortNet.Data.Migrations.INFPortObjectDbContext
{
    public class INFPortObjectDbContext : ApplicationDbContext
    {
        public INFPortObjectDbContext(DbContextOptions<INFPortObjectDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region INFPortObject

            modelBuilder.ApplyConfiguration(new TacitConfiguration());
            modelBuilder.ApplyConfiguration(new CmListConfiguration());
            modelBuilder.ApplyConfiguration(new TacitFileConfiguration());
            modelBuilder.ApplyConfiguration(new TacitLogConfiguration());
            modelBuilder.ApplyConfiguration(new TarrayConfiguration());
            modelBuilder.ApplyConfiguration(new TBellowsConfiguration());
            modelBuilder.ApplyConfiguration(new TBellowsFaceConfiguration());
            modelBuilder.ApplyConfiguration(new TContractConfiguration());
            modelBuilder.ApplyConfiguration(new TContractAppendicesConfiguration());
            modelBuilder.ApplyConfiguration(new TContractDetailConfiguration());
            modelBuilder.ApplyConfiguration(new TContractExtensionConfiguration());
            modelBuilder.ApplyConfiguration(new TContractFileConfiguration());
            modelBuilder.ApplyConfiguration(new TContractHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new TDocumentConfiguration());
            modelBuilder.ApplyConfiguration(new TDocumentFileConfiguration());
            modelBuilder.ApplyConfiguration(new TGanivoConfiguration());
            modelBuilder.ApplyConfiguration(new TListConfiguration());
            modelBuilder.ApplyConfiguration(new TMailConfiguration());
            modelBuilder.ApplyConfiguration(new TManuaBilldingConfiguration());
            modelBuilder.ApplyConfiguration(new TNumberPayConfiguration());
            modelBuilder.ApplyConfiguration(new TNumberPayHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new TPartnerConfiguration());
            modelBuilder.ApplyConfiguration(new TPipePlugConfiguration());
            modelBuilder.ApplyConfiguration(new TPriceConfiguration());
            modelBuilder.ApplyConfiguration(new TrouteCableConfiguration());
            modelBuilder.ApplyConfiguration(new TrouteCableDetailConfiguration());
            modelBuilder.ApplyConfiguration(new TrouteCableHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new TrouteCableLinkConfiguration());
            modelBuilder.ApplyConfiguration(new TTubeConfiguration());
            modelBuilder.ApplyConfiguration(new TTubeDetailConfiguration());
            modelBuilder.ApplyConfiguration(new TypeMailConfiguration());

            #endregion INFPortObject

            base.OnModelCreating(modelBuilder);
        }

        #region INFPortObject

        public DbSet<Cmlist> Cmlist { get; set; }
        public DbSet<Tacit> Tacit { get; set; }
        public DbSet<TacitFile> TacitFile { get; set; }
        public DbSet<TacitLog> TacitLog { get; set; }
        public DbSet<Tarray> Tarray { get; set; }
        public DbSet<Tbellows> Tbellows { get; set; }
        public DbSet<TbellowsFace> TbellowsFace { get; set; }
        public DbSet<Tcontract> Tcontract { get; set; }
        public DbSet<TcontractAppendices> TcontractAppendices { get; set; }
        public DbSet<TcontractDetail> TcontractDetail { get; set; }
        public DbSet<TcontractExtension> TcontractExtension { get; set; }
        public DbSet<TcontractFile> TcontractFile { get; set; }
        public DbSet<TcontractHistory> TcontractHistory { get; set; }
        public DbSet<Tdocument> Tdocument { get; set; }
        public DbSet<TdocumentFile> TdocumentFile { get; set; }
        public DbSet<Tganivo> Tganivo { get; set; }
        public DbSet<Tlist> Tlist { get; set; }
        public DbSet<Tmail> Tmail { get; set; }
        public DbSet<TmanuaBillding> TmanuaBillding { get; set; }
        public DbSet<TnumberPay> TnumberPay { get; set; }
        public DbSet<TnumberPayHistory> TnumberPayHistory { get; set; }
        public DbSet<Tpartner> Tpartner { get; set; }
        public DbSet<TpipePlug> TpipePlug { get; set; }
        public DbSet<Tprice> Tprice { get; set; }
        public DbSet<TrouteCable> TrouteCable { get; set; }
        public DbSet<TrouteCableDetail> TrouteCableDetail { get; set; }
        public DbSet<TrouteCableHistory> TrouteCableHistory { get; set; }
        public DbSet<TrouteCableLink> TrouteCableLink { get; set; }
        public DbSet<Ttube> Ttube { get; set; }
        public DbSet<TtubeDetail> TtubeDetail { get; set; }
        public DbSet<TypeMail> TypeMail { get; set; }

        #endregion INFPortObject
    }
}