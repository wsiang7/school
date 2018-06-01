using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace school.Model
{
    public partial class lhContext : DbContext
    {
        public virtual DbSet<AdditionalInfo> AdditionalInfo { get; set; }
        public virtual DbSet<AggDist> AggDist { get; set; }
        public virtual DbSet<AggSalesExternal> AggSalesExternal { get; set; }
        public virtual DbSet<AggSalesInternal> AggSalesInternal { get; set; }
        public virtual DbSet<BatchingPlantMaster> BatchingPlantMaster { get; set; }
        public virtual DbSet<BudgetJobDetail> BudgetJobDetail { get; set; }
        public virtual DbSet<BudgetJobDetail2017> BudgetJobDetail2017 { get; set; }
        public virtual DbSet<BudgetJobDetail2018> BudgetJobDetail2018 { get; set; }
        public virtual DbSet<BudgetJobDetailFte> BudgetJobDetailFte { get; set; }
        public virtual DbSet<BudgetJobDetailFte2017> BudgetJobDetailFte2017 { get; set; }
        public virtual DbSet<BudgetJobDetailFte2018> BudgetJobDetailFte2018 { get; set; }
        public virtual DbSet<BudgetJobDetailNotes> BudgetJobDetailNotes { get; set; }
        public virtual DbSet<BudgetJobDetailNotes2017> BudgetJobDetailNotes2017 { get; set; }
        public virtual DbSet<BudgetJobDetailNotes2018> BudgetJobDetailNotes2018 { get; set; }
        public virtual DbSet<BudgetJobHeader> BudgetJobHeader { get; set; }
        public virtual DbSet<BudgetJobMaster> BudgetJobMaster { get; set; }
        public virtual DbSet<BudgetJobUpload> BudgetJobUpload { get; set; }
        public virtual DbSet<CategoryCode> CategoryCode { get; set; }
        public virtual DbSet<CementMaster> CementMaster { get; set; }
        public virtual DbSet<CementRegionMaster> CementRegionMaster { get; set; }
        public virtual DbSet<ClcPrice> ClcPrice { get; set; }
        public virtual DbSet<CopBom> CopBom { get; set; }
        public virtual DbSet<CopProduction> CopProduction { get; set; }
        public virtual DbSet<CopSales> CopSales { get; set; }
        public virtual DbSet<CostCenterDetail> CostCenterDetail { get; set; }
        public virtual DbSet<CostCenterMaster> CostCenterMaster { get; set; }
        public virtual DbSet<CostElementGroupMaster> CostElementGroupMaster { get; set; }
        public virtual DbSet<CostElementMaster> CostElementMaster { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<FunctionMaster> FunctionMaster { get; set; }
        public virtual DbSet<IncomeStatementConfigDetail> IncomeStatementConfigDetail { get; set; }
        public virtual DbSet<IncomeStatementConfigHeader> IncomeStatementConfigHeader { get; set; }
        public virtual DbSet<ItemMaster> ItemMaster { get; set; }
        public virtual DbSet<ItemPrice> ItemPrice { get; set; }
        public virtual DbSet<QuarryMaster> QuarryMaster { get; set; }
        public virtual DbSet<RegionMaster> RegionMaster { get; set; }
        public virtual DbSet<RmxCement> RmxCement { get; set; }
        public virtual DbSet<RmxComponent> RmxComponent { get; set; }
        public virtual DbSet<RmxComponentMaster> RmxComponentMaster { get; set; }
        public virtual DbSet<RmxDist> RmxDist { get; set; }
        public virtual DbSet<RmxRawMaterial> RmxRawMaterial { get; set; }
        public virtual DbSet<RmxSales> RmxSales { get; set; }
        public virtual DbSet<SpcAllocation> SpcAllocation { get; set; }
        public virtual DbSet<TransportationTypeMaster> TransportationTypeMaster { get; set; }
        public virtual DbSet<UserReserved> UserReserved { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersDetail> UsersDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=192.168.100.17;Database=lh_budgeting_system_qos;User Id=kenny;Password=Holcim123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdditionalInfo>(entity =>
            {
                entity.HasKey(e => e.Filename);

                entity.ToTable("additional_info");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AggDist>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Quarryid, e.Salestype, e.Batchingplantid });

                entity.ToTable("agg_dist");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Quarryid).HasColumnName("quarryid");

                entity.Property(e => e.Salestype)
                    .HasColumnName("salestype")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplantid)
                    .HasColumnName("batchingplantid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplantdesc)
                    .HasColumnName("batchingplantdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Quarrydesc)
                    .HasColumnName("quarrydesc")
                    .IsUnicode(false);

                entity.Property(e => e.RateApr1)
                    .HasColumnName("rate_apr_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateApr2)
                    .HasColumnName("rate_apr_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateApr3)
                    .HasColumnName("rate_apr_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateAug1)
                    .HasColumnName("rate_aug_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateAug2)
                    .HasColumnName("rate_aug_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateAug3)
                    .HasColumnName("rate_aug_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateDec1)
                    .HasColumnName("rate_dec_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateDec2)
                    .HasColumnName("rate_dec_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateDec3)
                    .HasColumnName("rate_dec_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateFeb1)
                    .HasColumnName("rate_feb_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateFeb2)
                    .HasColumnName("rate_feb_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateFeb3)
                    .HasColumnName("rate_feb_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateJan1)
                    .HasColumnName("rate_jan_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateJan2)
                    .HasColumnName("rate_jan_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateJan3)
                    .HasColumnName("rate_jan_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateJul1)
                    .HasColumnName("rate_jul_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateJul2)
                    .HasColumnName("rate_jul_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateJul3)
                    .HasColumnName("rate_jul_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateJun1)
                    .HasColumnName("rate_jun_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateJun2)
                    .HasColumnName("rate_jun_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateJun3)
                    .HasColumnName("rate_jun_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateMar1)
                    .HasColumnName("rate_mar_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateMar2)
                    .HasColumnName("rate_mar_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateMar3)
                    .HasColumnName("rate_mar_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateMay1)
                    .HasColumnName("rate_may_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateMay2)
                    .HasColumnName("rate_may_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateMay3)
                    .HasColumnName("rate_may_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateMtp1)
                    .HasColumnName("rate_mtp_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateMtp2)
                    .HasColumnName("rate_mtp_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateMtp3)
                    .HasColumnName("rate_mtp_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateNov1)
                    .HasColumnName("rate_nov_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateNov2)
                    .HasColumnName("rate_nov_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateNov3)
                    .HasColumnName("rate_nov_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateOct1)
                    .HasColumnName("rate_oct_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateOct2)
                    .HasColumnName("rate_oct_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateOct3)
                    .HasColumnName("rate_oct_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateSep1)
                    .HasColumnName("rate_sep_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateSep2)
                    .HasColumnName("rate_sep_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateSep3)
                    .HasColumnName("rate_sep_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Regiondesc)
                    .HasColumnName("regiondesc")
                    .IsUnicode(false);

                entity.Property(e => e.Regionid).HasColumnName("regionid");
            });

            modelBuilder.Entity<AggSalesExternal>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Quarryid, e.Itemid, e.Delivery });

                entity.ToTable("agg_sales_external");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Quarryid).HasColumnName("quarryid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Delivery)
                    .HasColumnName("delivery")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AspApr1)
                    .HasColumnName("asp_apr_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspApr2)
                    .HasColumnName("asp_apr_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspApr3)
                    .HasColumnName("asp_apr_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspAug1)
                    .HasColumnName("asp_aug_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspAug2)
                    .HasColumnName("asp_aug_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspAug3)
                    .HasColumnName("asp_aug_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspDec1)
                    .HasColumnName("asp_dec_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspDec2)
                    .HasColumnName("asp_dec_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspDec3)
                    .HasColumnName("asp_dec_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspFeb1)
                    .HasColumnName("asp_feb_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspFeb2)
                    .HasColumnName("asp_feb_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspFeb3)
                    .HasColumnName("asp_feb_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJan1)
                    .HasColumnName("asp_jan_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJan2)
                    .HasColumnName("asp_jan_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJan3)
                    .HasColumnName("asp_jan_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJul1)
                    .HasColumnName("asp_jul_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJul2)
                    .HasColumnName("asp_jul_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJul3)
                    .HasColumnName("asp_jul_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJun1)
                    .HasColumnName("asp_jun_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJun2)
                    .HasColumnName("asp_jun_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJun3)
                    .HasColumnName("asp_jun_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMar1)
                    .HasColumnName("asp_mar_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMar2)
                    .HasColumnName("asp_mar_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMar3)
                    .HasColumnName("asp_mar_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMay1)
                    .HasColumnName("asp_may_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMay2)
                    .HasColumnName("asp_may_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMay3)
                    .HasColumnName("asp_may_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMtp1)
                    .HasColumnName("asp_mtp_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMtp2)
                    .HasColumnName("asp_mtp_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMtp3)
                    .HasColumnName("asp_mtp_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspNov1)
                    .HasColumnName("asp_nov_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspNov2)
                    .HasColumnName("asp_nov_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspNov3)
                    .HasColumnName("asp_nov_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspOct1)
                    .HasColumnName("asp_oct_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspOct2)
                    .HasColumnName("asp_oct_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspOct3)
                    .HasColumnName("asp_oct_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspSep1)
                    .HasColumnName("asp_sep_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspSep2)
                    .HasColumnName("asp_sep_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspSep3)
                    .HasColumnName("asp_sep_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Itemdesc)
                    .HasColumnName("itemdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Itemtype)
                    .HasColumnName("itemtype")
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.NetApr1)
                    .HasColumnName("net_apr_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetApr2)
                    .HasColumnName("net_apr_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetApr3)
                    .HasColumnName("net_apr_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAug1)
                    .HasColumnName("net_aug_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAug2)
                    .HasColumnName("net_aug_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAug3)
                    .HasColumnName("net_aug_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetDec1)
                    .HasColumnName("net_dec_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetDec2)
                    .HasColumnName("net_dec_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetDec3)
                    .HasColumnName("net_dec_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFeb1)
                    .HasColumnName("net_feb_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFeb2)
                    .HasColumnName("net_feb_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFeb3)
                    .HasColumnName("net_feb_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJan1)
                    .HasColumnName("net_jan_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJan2)
                    .HasColumnName("net_jan_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJan3)
                    .HasColumnName("net_jan_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJul1)
                    .HasColumnName("net_jul_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJul2)
                    .HasColumnName("net_jul_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJul3)
                    .HasColumnName("net_jul_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJun1)
                    .HasColumnName("net_jun_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJun2)
                    .HasColumnName("net_jun_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJun3)
                    .HasColumnName("net_jun_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMar1)
                    .HasColumnName("net_mar_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMar2)
                    .HasColumnName("net_mar_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMar3)
                    .HasColumnName("net_mar_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMay1)
                    .HasColumnName("net_may_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMay2)
                    .HasColumnName("net_may_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMay3)
                    .HasColumnName("net_may_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMtp1)
                    .HasColumnName("net_mtp_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMtp2)
                    .HasColumnName("net_mtp_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMtp3)
                    .HasColumnName("net_mtp_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetNov1)
                    .HasColumnName("net_nov_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetNov2)
                    .HasColumnName("net_nov_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetNov3)
                    .HasColumnName("net_nov_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetOct1)
                    .HasColumnName("net_oct_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetOct2)
                    .HasColumnName("net_oct_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetOct3)
                    .HasColumnName("net_oct_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetSep1)
                    .HasColumnName("net_sep_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetSep2)
                    .HasColumnName("net_sep_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetSep3)
                    .HasColumnName("net_sep_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quarrydesc)
                    .HasColumnName("quarrydesc")
                    .IsUnicode(false);

                entity.Property(e => e.VolApr1)
                    .HasColumnName("vol_apr_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolApr2)
                    .HasColumnName("vol_apr_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolApr3)
                    .HasColumnName("vol_apr_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolAug1)
                    .HasColumnName("vol_aug_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolAug2)
                    .HasColumnName("vol_aug_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolAug3)
                    .HasColumnName("vol_aug_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolDec1)
                    .HasColumnName("vol_dec_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolDec2)
                    .HasColumnName("vol_dec_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolDec3)
                    .HasColumnName("vol_dec_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolFeb1)
                    .HasColumnName("vol_feb_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolFeb2)
                    .HasColumnName("vol_feb_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolFeb3)
                    .HasColumnName("vol_feb_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJan1)
                    .HasColumnName("vol_jan_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJan2)
                    .HasColumnName("vol_jan_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJan3)
                    .HasColumnName("vol_jan_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJul1)
                    .HasColumnName("vol_jul_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJul2)
                    .HasColumnName("vol_jul_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJul3)
                    .HasColumnName("vol_jul_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJun1)
                    .HasColumnName("vol_jun_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJun2)
                    .HasColumnName("vol_jun_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJun3)
                    .HasColumnName("vol_jun_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMar1)
                    .HasColumnName("vol_mar_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMar2)
                    .HasColumnName("vol_mar_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMar3)
                    .HasColumnName("vol_mar_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMay1)
                    .HasColumnName("vol_may_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMay2)
                    .HasColumnName("vol_may_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMay3)
                    .HasColumnName("vol_may_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMtp1)
                    .HasColumnName("vol_mtp_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMtp2)
                    .HasColumnName("vol_mtp_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMtp3)
                    .HasColumnName("vol_mtp_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolNov1)
                    .HasColumnName("vol_nov_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolNov2)
                    .HasColumnName("vol_nov_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolNov3)
                    .HasColumnName("vol_nov_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolOct1)
                    .HasColumnName("vol_oct_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolOct2)
                    .HasColumnName("vol_oct_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolOct3)
                    .HasColumnName("vol_oct_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolSep1)
                    .HasColumnName("vol_sep_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolSep2)
                    .HasColumnName("vol_sep_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolSep3)
                    .HasColumnName("vol_sep_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AggSalesInternal>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Quarryid, e.Batchingplantid });

                entity.ToTable("agg_sales_internal");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Quarryid).HasColumnName("quarryid");

                entity.Property(e => e.Batchingplantid)
                    .HasColumnName("batchingplantid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplantdesc)
                    .HasColumnName("batchingplantdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Portiondelivered)
                    .HasColumnName("portiondelivered")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Portionpickedup)
                    .HasColumnName("portionpickedup")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quarrydesc)
                    .HasColumnName("quarrydesc")
                    .IsUnicode(false);

                entity.Property(e => e.Regiondesc)
                    .HasColumnName("regiondesc")
                    .IsUnicode(false);

                entity.Property(e => e.Regionid).HasColumnName("regionid");
            });

            modelBuilder.Entity<BatchingPlantMaster>(entity =>
            {
                entity.ToTable("batching_plant_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cementregionid)
                    .HasColumnName("cementregionid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Distcostcenterid)
                    .HasColumnName("distcostcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Prodcostcenterid)
                    .HasColumnName("prodcostcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BudgetJobDetail>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid, e.Costelementid });

                entity.ToTable("budget_job_detail");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Costelementid)
                    .HasColumnName("costelementid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Act0)
                    .HasColumnName("act_0")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Apr1)
                    .HasColumnName("apr_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Apr2)
                    .HasColumnName("apr_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Apr3)
                    .HasColumnName("apr_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aug1)
                    .HasColumnName("aug_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aug2)
                    .HasColumnName("aug_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aug3)
                    .HasColumnName("aug_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Costelementdescription)
                    .HasColumnName("costelementdescription")
                    .IsUnicode(false);

                entity.Property(e => e.Costelementgroupdescription)
                    .HasColumnName("costelementgroupdescription")
                    .IsUnicode(false);

                entity.Property(e => e.Costelementgroupid)
                    .HasColumnName("costelementgroupid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Costtypedescription)
                    .HasColumnName("costtypedescription")
                    .IsUnicode(false);

                entity.Property(e => e.Costtypeid)
                    .HasColumnName("costtypeid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Dec1)
                    .HasColumnName("dec_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dec2)
                    .HasColumnName("dec_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dec3)
                    .HasColumnName("dec_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Feb1)
                    .HasColumnName("feb_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Feb2)
                    .HasColumnName("feb_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Feb3)
                    .HasColumnName("feb_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jan1)
                    .HasColumnName("jan_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jan2)
                    .HasColumnName("jan_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jan3)
                    .HasColumnName("jan_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jul1)
                    .HasColumnName("jul_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jul2)
                    .HasColumnName("jul_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jul3)
                    .HasColumnName("jul_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jun1)
                    .HasColumnName("jun_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jun2)
                    .HasColumnName("jun_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jun3)
                    .HasColumnName("jun_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mar1)
                    .HasColumnName("mar_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mar2)
                    .HasColumnName("mar_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mar3)
                    .HasColumnName("mar_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.May1)
                    .HasColumnName("may_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.May2)
                    .HasColumnName("may_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.May3)
                    .HasColumnName("may_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Mtp1)
                    .HasColumnName("mtp_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mtp2)
                    .HasColumnName("mtp_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mtp3)
                    .HasColumnName("mtp_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nov1)
                    .HasColumnName("nov_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nov2)
                    .HasColumnName("nov_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nov3)
                    .HasColumnName("nov_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oct1)
                    .HasColumnName("oct_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oct2)
                    .HasColumnName("oct_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oct3)
                    .HasColumnName("oct_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrevMtp1)
                    .HasColumnName("prev_mtp_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sep1)
                    .HasColumnName("sep_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sep2)
                    .HasColumnName("sep_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sep3)
                    .HasColumnName("sep_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BudgetJobDetail2017>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid, e.Costelementid });

                entity.ToTable("budget_job_detail_2017");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Costelementid)
                    .HasColumnName("costelementid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Act0)
                    .HasColumnName("act_0")
                    .HasColumnType("money");

                entity.Property(e => e.Apr1)
                    .HasColumnName("apr_1")
                    .HasColumnType("money");

                entity.Property(e => e.Apr2)
                    .HasColumnName("apr_2")
                    .HasColumnType("money");

                entity.Property(e => e.Apr3)
                    .HasColumnName("apr_3")
                    .HasColumnType("money");

                entity.Property(e => e.Aug1)
                    .HasColumnName("aug_1")
                    .HasColumnType("money");

                entity.Property(e => e.Aug2)
                    .HasColumnName("aug_2")
                    .HasColumnType("money");

                entity.Property(e => e.Aug3)
                    .HasColumnName("aug_3")
                    .HasColumnType("money");

                entity.Property(e => e.Costelementdescription)
                    .HasColumnName("costelementdescription")
                    .IsUnicode(false);

                entity.Property(e => e.Costelementgroupdescription)
                    .HasColumnName("costelementgroupdescription")
                    .IsUnicode(false);

                entity.Property(e => e.Costelementgroupid)
                    .HasColumnName("costelementgroupid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Costtypedescription)
                    .HasColumnName("costtypedescription")
                    .IsUnicode(false);

                entity.Property(e => e.Costtypeid)
                    .HasColumnName("costtypeid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Dec1)
                    .HasColumnName("dec_1")
                    .HasColumnType("money");

                entity.Property(e => e.Dec2)
                    .HasColumnName("dec_2")
                    .HasColumnType("money");

                entity.Property(e => e.Dec3)
                    .HasColumnName("dec_3")
                    .HasColumnType("money");

                entity.Property(e => e.Entry).HasColumnName("entry");

                entity.Property(e => e.Feb1)
                    .HasColumnName("feb_1")
                    .HasColumnType("money");

                entity.Property(e => e.Feb2)
                    .HasColumnName("feb_2")
                    .HasColumnType("money");

                entity.Property(e => e.Feb3)
                    .HasColumnName("feb_3")
                    .HasColumnType("money");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Jan1)
                    .HasColumnName("jan_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jan2)
                    .HasColumnName("jan_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jan3)
                    .HasColumnName("jan_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jul1)
                    .HasColumnName("jul_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jul2)
                    .HasColumnName("jul_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jul3)
                    .HasColumnName("jul_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jun1)
                    .HasColumnName("jun_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jun2)
                    .HasColumnName("jun_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jun3)
                    .HasColumnName("jun_3")
                    .HasColumnType("money");

                entity.Property(e => e.Mar1)
                    .HasColumnName("mar_1")
                    .HasColumnType("money");

                entity.Property(e => e.Mar2)
                    .HasColumnName("mar_2")
                    .HasColumnType("money");

                entity.Property(e => e.Mar3)
                    .HasColumnName("mar_3")
                    .HasColumnType("money");

                entity.Property(e => e.May1)
                    .HasColumnName("may_1")
                    .HasColumnType("money");

                entity.Property(e => e.May2)
                    .HasColumnName("may_2")
                    .HasColumnType("money");

                entity.Property(e => e.May3)
                    .HasColumnName("may_3")
                    .HasColumnType("money");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Mtp1)
                    .HasColumnName("mtp_1")
                    .HasColumnType("money");

                entity.Property(e => e.Mtp2)
                    .HasColumnName("mtp_2")
                    .HasColumnType("money");

                entity.Property(e => e.Mtp3)
                    .HasColumnName("mtp_3")
                    .HasColumnType("money");

                entity.Property(e => e.Nov1)
                    .HasColumnName("nov_1")
                    .HasColumnType("money");

                entity.Property(e => e.Nov2)
                    .HasColumnName("nov_2")
                    .HasColumnType("money");

                entity.Property(e => e.Nov3)
                    .HasColumnName("nov_3")
                    .HasColumnType("money");

                entity.Property(e => e.Oct1)
                    .HasColumnName("oct_1")
                    .HasColumnType("money");

                entity.Property(e => e.Oct2)
                    .HasColumnName("oct_2")
                    .HasColumnType("money");

                entity.Property(e => e.Oct3)
                    .HasColumnName("oct_3")
                    .HasColumnType("money");

                entity.Property(e => e.PrevMtp1)
                    .HasColumnName("prev_mtp_1")
                    .HasColumnType("money");

                entity.Property(e => e.Sep1)
                    .HasColumnName("sep_1")
                    .HasColumnType("money");

                entity.Property(e => e.Sep2)
                    .HasColumnName("sep_2")
                    .HasColumnType("money");

                entity.Property(e => e.Sep3)
                    .HasColumnName("sep_3")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<BudgetJobDetail2018>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid, e.Costelementid });

                entity.ToTable("budget_job_detail_2018");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Costelementid)
                    .HasColumnName("costelementid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Act0)
                    .HasColumnName("act_0")
                    .HasColumnType("money");

                entity.Property(e => e.Apr1)
                    .HasColumnName("apr_1")
                    .HasColumnType("money");

                entity.Property(e => e.Apr2)
                    .HasColumnName("apr_2")
                    .HasColumnType("money");

                entity.Property(e => e.Apr3)
                    .HasColumnName("apr_3")
                    .HasColumnType("money");

                entity.Property(e => e.Aug1)
                    .HasColumnName("aug_1")
                    .HasColumnType("money");

                entity.Property(e => e.Aug2)
                    .HasColumnName("aug_2")
                    .HasColumnType("money");

                entity.Property(e => e.Aug3)
                    .HasColumnName("aug_3")
                    .HasColumnType("money");

                entity.Property(e => e.Costelementdescription)
                    .HasColumnName("costelementdescription")
                    .IsUnicode(false);

                entity.Property(e => e.Costelementgroupdescription)
                    .HasColumnName("costelementgroupdescription")
                    .IsUnicode(false);

                entity.Property(e => e.Costelementgroupid)
                    .HasColumnName("costelementgroupid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Costtypedescription)
                    .HasColumnName("costtypedescription")
                    .IsUnicode(false);

                entity.Property(e => e.Costtypeid)
                    .HasColumnName("costtypeid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Dec1)
                    .HasColumnName("dec_1")
                    .HasColumnType("money");

                entity.Property(e => e.Dec2)
                    .HasColumnName("dec_2")
                    .HasColumnType("money");

                entity.Property(e => e.Dec3)
                    .HasColumnName("dec_3")
                    .HasColumnType("money");

                entity.Property(e => e.Entry).HasColumnName("entry");

                entity.Property(e => e.Feb1)
                    .HasColumnName("feb_1")
                    .HasColumnType("money");

                entity.Property(e => e.Feb2)
                    .HasColumnName("feb_2")
                    .HasColumnType("money");

                entity.Property(e => e.Feb3)
                    .HasColumnName("feb_3")
                    .HasColumnType("money");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Jan1)
                    .HasColumnName("jan_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jan2)
                    .HasColumnName("jan_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jan3)
                    .HasColumnName("jan_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jul1)
                    .HasColumnName("jul_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jul2)
                    .HasColumnName("jul_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jul3)
                    .HasColumnName("jul_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jun1)
                    .HasColumnName("jun_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jun2)
                    .HasColumnName("jun_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jun3)
                    .HasColumnName("jun_3")
                    .HasColumnType("money");

                entity.Property(e => e.Mar1)
                    .HasColumnName("mar_1")
                    .HasColumnType("money");

                entity.Property(e => e.Mar2)
                    .HasColumnName("mar_2")
                    .HasColumnType("money");

                entity.Property(e => e.Mar3)
                    .HasColumnName("mar_3")
                    .HasColumnType("money");

                entity.Property(e => e.May1)
                    .HasColumnName("may_1")
                    .HasColumnType("money");

                entity.Property(e => e.May2)
                    .HasColumnName("may_2")
                    .HasColumnType("money");

                entity.Property(e => e.May3)
                    .HasColumnName("may_3")
                    .HasColumnType("money");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Mtp1)
                    .HasColumnName("mtp_1")
                    .HasColumnType("money");

                entity.Property(e => e.Mtp2)
                    .HasColumnName("mtp_2")
                    .HasColumnType("money");

                entity.Property(e => e.Mtp3)
                    .HasColumnName("mtp_3")
                    .HasColumnType("money");

                entity.Property(e => e.Nov1)
                    .HasColumnName("nov_1")
                    .HasColumnType("money");

                entity.Property(e => e.Nov2)
                    .HasColumnName("nov_2")
                    .HasColumnType("money");

                entity.Property(e => e.Nov3)
                    .HasColumnName("nov_3")
                    .HasColumnType("money");

                entity.Property(e => e.Oct1)
                    .HasColumnName("oct_1")
                    .HasColumnType("money");

                entity.Property(e => e.Oct2)
                    .HasColumnName("oct_2")
                    .HasColumnType("money");

                entity.Property(e => e.Oct3)
                    .HasColumnName("oct_3")
                    .HasColumnType("money");

                entity.Property(e => e.PrevMtp1)
                    .HasColumnName("prev_mtp_1")
                    .HasColumnType("money");

                entity.Property(e => e.Sep1)
                    .HasColumnName("sep_1")
                    .HasColumnType("money");

                entity.Property(e => e.Sep2)
                    .HasColumnName("sep_2")
                    .HasColumnType("money");

                entity.Property(e => e.Sep3)
                    .HasColumnName("sep_3")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<BudgetJobDetailFte>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid });

                entity.ToTable("budget_job_detail_fte");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apr1)
                    .HasColumnName("apr_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Apr2)
                    .HasColumnName("apr_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Apr3)
                    .HasColumnName("apr_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aug1)
                    .HasColumnName("aug_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aug2)
                    .HasColumnName("aug_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aug3)
                    .HasColumnName("aug_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Dec1)
                    .HasColumnName("dec_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dec2)
                    .HasColumnName("dec_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dec3)
                    .HasColumnName("dec_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Feb1)
                    .HasColumnName("feb_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Feb2)
                    .HasColumnName("feb_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Feb3)
                    .HasColumnName("feb_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jan1)
                    .HasColumnName("jan_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jan2)
                    .HasColumnName("jan_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jan3)
                    .HasColumnName("jan_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jul1)
                    .HasColumnName("jul_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jul2)
                    .HasColumnName("jul_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jul3)
                    .HasColumnName("jul_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jun1)
                    .HasColumnName("jun_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jun2)
                    .HasColumnName("jun_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jun3)
                    .HasColumnName("jun_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mar1)
                    .HasColumnName("mar_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mar2)
                    .HasColumnName("mar_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mar3)
                    .HasColumnName("mar_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.May1)
                    .HasColumnName("may_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.May2)
                    .HasColumnName("may_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.May3)
                    .HasColumnName("may_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Mtp1)
                    .HasColumnName("mtp_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mtp2)
                    .HasColumnName("mtp_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mtp3)
                    .HasColumnName("mtp_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nov1)
                    .HasColumnName("nov_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nov2)
                    .HasColumnName("nov_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nov3)
                    .HasColumnName("nov_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oct1)
                    .HasColumnName("oct_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oct2)
                    .HasColumnName("oct_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oct3)
                    .HasColumnName("oct_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sep1)
                    .HasColumnName("sep_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sep2)
                    .HasColumnName("sep_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sep3)
                    .HasColumnName("sep_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BudgetJobDetailFte2017>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid });

                entity.ToTable("budget_job_detail_fte_2017");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apr1)
                    .HasColumnName("apr_1")
                    .HasColumnType("money");

                entity.Property(e => e.Apr2)
                    .HasColumnName("apr_2")
                    .HasColumnType("money");

                entity.Property(e => e.Apr3)
                    .HasColumnName("apr_3")
                    .HasColumnType("money");

                entity.Property(e => e.Aug1)
                    .HasColumnName("aug_1")
                    .HasColumnType("money");

                entity.Property(e => e.Aug2)
                    .HasColumnName("aug_2")
                    .HasColumnType("money");

                entity.Property(e => e.Aug3)
                    .HasColumnName("aug_3")
                    .HasColumnType("money");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Dec1)
                    .HasColumnName("dec_1")
                    .HasColumnType("money");

                entity.Property(e => e.Dec2)
                    .HasColumnName("dec_2")
                    .HasColumnType("money");

                entity.Property(e => e.Dec3)
                    .HasColumnName("dec_3")
                    .HasColumnType("money");

                entity.Property(e => e.Feb1)
                    .HasColumnName("feb_1")
                    .HasColumnType("money");

                entity.Property(e => e.Feb2)
                    .HasColumnName("feb_2")
                    .HasColumnType("money");

                entity.Property(e => e.Feb3)
                    .HasColumnName("feb_3")
                    .HasColumnType("money");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Jan1)
                    .HasColumnName("jan_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jan2)
                    .HasColumnName("jan_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jan3)
                    .HasColumnName("jan_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jul1)
                    .HasColumnName("jul_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jul2)
                    .HasColumnName("jul_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jul3)
                    .HasColumnName("jul_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jun1)
                    .HasColumnName("jun_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jun2)
                    .HasColumnName("jun_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jun3)
                    .HasColumnName("jun_3")
                    .HasColumnType("money");

                entity.Property(e => e.Mar1)
                    .HasColumnName("mar_1")
                    .HasColumnType("money");

                entity.Property(e => e.Mar2)
                    .HasColumnName("mar_2")
                    .HasColumnType("money");

                entity.Property(e => e.Mar3)
                    .HasColumnName("mar_3")
                    .HasColumnType("money");

                entity.Property(e => e.May1)
                    .HasColumnName("may_1")
                    .HasColumnType("money");

                entity.Property(e => e.May2)
                    .HasColumnName("may_2")
                    .HasColumnType("money");

                entity.Property(e => e.May3)
                    .HasColumnName("may_3")
                    .HasColumnType("money");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Mtp1)
                    .HasColumnName("mtp_1")
                    .HasColumnType("money");

                entity.Property(e => e.Mtp2)
                    .HasColumnName("mtp_2")
                    .HasColumnType("money");

                entity.Property(e => e.Mtp3)
                    .HasColumnName("mtp_3")
                    .HasColumnType("money");

                entity.Property(e => e.Nov1)
                    .HasColumnName("nov_1")
                    .HasColumnType("money");

                entity.Property(e => e.Nov2)
                    .HasColumnName("nov_2")
                    .HasColumnType("money");

                entity.Property(e => e.Nov3)
                    .HasColumnName("nov_3")
                    .HasColumnType("money");

                entity.Property(e => e.Oct1)
                    .HasColumnName("oct_1")
                    .HasColumnType("money");

                entity.Property(e => e.Oct2)
                    .HasColumnName("oct_2")
                    .HasColumnType("money");

                entity.Property(e => e.Oct3)
                    .HasColumnName("oct_3")
                    .HasColumnType("money");

                entity.Property(e => e.Sep1)
                    .HasColumnName("sep_1")
                    .HasColumnType("money");

                entity.Property(e => e.Sep2)
                    .HasColumnName("sep_2")
                    .HasColumnType("money");

                entity.Property(e => e.Sep3)
                    .HasColumnName("sep_3")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<BudgetJobDetailFte2018>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid });

                entity.ToTable("budget_job_detail_fte_2018");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apr1)
                    .HasColumnName("apr_1")
                    .HasColumnType("money");

                entity.Property(e => e.Apr2)
                    .HasColumnName("apr_2")
                    .HasColumnType("money");

                entity.Property(e => e.Apr3)
                    .HasColumnName("apr_3")
                    .HasColumnType("money");

                entity.Property(e => e.Aug1)
                    .HasColumnName("aug_1")
                    .HasColumnType("money");

                entity.Property(e => e.Aug2)
                    .HasColumnName("aug_2")
                    .HasColumnType("money");

                entity.Property(e => e.Aug3)
                    .HasColumnName("aug_3")
                    .HasColumnType("money");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Dec1)
                    .HasColumnName("dec_1")
                    .HasColumnType("money");

                entity.Property(e => e.Dec2)
                    .HasColumnName("dec_2")
                    .HasColumnType("money");

                entity.Property(e => e.Dec3)
                    .HasColumnName("dec_3")
                    .HasColumnType("money");

                entity.Property(e => e.Feb1)
                    .HasColumnName("feb_1")
                    .HasColumnType("money");

                entity.Property(e => e.Feb2)
                    .HasColumnName("feb_2")
                    .HasColumnType("money");

                entity.Property(e => e.Feb3)
                    .HasColumnName("feb_3")
                    .HasColumnType("money");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Jan1)
                    .HasColumnName("jan_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jan2)
                    .HasColumnName("jan_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jan3)
                    .HasColumnName("jan_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jul1)
                    .HasColumnName("jul_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jul2)
                    .HasColumnName("jul_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jul3)
                    .HasColumnName("jul_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jun1)
                    .HasColumnName("jun_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jun2)
                    .HasColumnName("jun_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jun3)
                    .HasColumnName("jun_3")
                    .HasColumnType("money");

                entity.Property(e => e.Mar1)
                    .HasColumnName("mar_1")
                    .HasColumnType("money");

                entity.Property(e => e.Mar2)
                    .HasColumnName("mar_2")
                    .HasColumnType("money");

                entity.Property(e => e.Mar3)
                    .HasColumnName("mar_3")
                    .HasColumnType("money");

                entity.Property(e => e.May1)
                    .HasColumnName("may_1")
                    .HasColumnType("money");

                entity.Property(e => e.May2)
                    .HasColumnName("may_2")
                    .HasColumnType("money");

                entity.Property(e => e.May3)
                    .HasColumnName("may_3")
                    .HasColumnType("money");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Mtp1)
                    .HasColumnName("mtp_1")
                    .HasColumnType("money");

                entity.Property(e => e.Mtp2)
                    .HasColumnName("mtp_2")
                    .HasColumnType("money");

                entity.Property(e => e.Mtp3)
                    .HasColumnName("mtp_3")
                    .HasColumnType("money");

                entity.Property(e => e.Nov1)
                    .HasColumnName("nov_1")
                    .HasColumnType("money");

                entity.Property(e => e.Nov2)
                    .HasColumnName("nov_2")
                    .HasColumnType("money");

                entity.Property(e => e.Nov3)
                    .HasColumnName("nov_3")
                    .HasColumnType("money");

                entity.Property(e => e.Oct1)
                    .HasColumnName("oct_1")
                    .HasColumnType("money");

                entity.Property(e => e.Oct2)
                    .HasColumnName("oct_2")
                    .HasColumnType("money");

                entity.Property(e => e.Oct3)
                    .HasColumnName("oct_3")
                    .HasColumnType("money");

                entity.Property(e => e.Sep1)
                    .HasColumnName("sep_1")
                    .HasColumnType("money");

                entity.Property(e => e.Sep2)
                    .HasColumnName("sep_2")
                    .HasColumnType("money");

                entity.Property(e => e.Sep3)
                    .HasColumnName("sep_3")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<BudgetJobDetailNotes>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid, e.Costelementid, e.Lineid });

                entity.ToTable("budget_job_detail_notes");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Costelementid)
                    .HasColumnName("costelementid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Activitytype)
                    .HasColumnName("activitytype")
                    .IsUnicode(false);

                entity.Property(e => e.Apr1)
                    .HasColumnName("apr_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Apr2)
                    .HasColumnName("apr_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Apr3)
                    .HasColumnName("apr_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aug1)
                    .HasColumnName("aug_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aug2)
                    .HasColumnName("aug_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aug3)
                    .HasColumnName("aug_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Dec1)
                    .HasColumnName("dec_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dec2)
                    .HasColumnName("dec_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dec3)
                    .HasColumnName("dec_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Feb1)
                    .HasColumnName("feb_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Feb2)
                    .HasColumnName("feb_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Feb3)
                    .HasColumnName("feb_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fy1)
                    .HasColumnName("fy_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fy2)
                    .HasColumnName("fy_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fy3)
                    .HasColumnName("fy_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jan1)
                    .HasColumnName("jan_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jan2)
                    .HasColumnName("jan_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jan3)
                    .HasColumnName("jan_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jul1)
                    .HasColumnName("jul_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jul2)
                    .HasColumnName("jul_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jul3)
                    .HasColumnName("jul_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jun1)
                    .HasColumnName("jun_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jun2)
                    .HasColumnName("jun_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jun3)
                    .HasColumnName("jun_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mar1)
                    .HasColumnName("mar_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mar2)
                    .HasColumnName("mar_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mar3)
                    .HasColumnName("mar_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.May1)
                    .HasColumnName("may_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.May2)
                    .HasColumnName("may_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.May3)
                    .HasColumnName("may_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Nov1)
                    .HasColumnName("nov_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nov2)
                    .HasColumnName("nov_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nov3)
                    .HasColumnName("nov_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oct1)
                    .HasColumnName("oct_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oct2)
                    .HasColumnName("oct_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oct3)
                    .HasColumnName("oct_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sep1)
                    .HasColumnName("sep_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sep2)
                    .HasColumnName("sep_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sep3)
                    .HasColumnName("sep_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("unitprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Uom1)
                    .HasColumnName("uom1")
                    .IsUnicode(false);

                entity.Property(e => e.Uom2)
                    .HasColumnName("uom2")
                    .IsUnicode(false);

                entity.Property(e => e.Uom3)
                    .HasColumnName("uom3")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BudgetJobDetailNotes2017>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid, e.Costelementid, e.Lineid });

                entity.ToTable("budget_job_detail_notes_2017");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Costelementid)
                    .HasColumnName("costelementid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Activitytype)
                    .HasColumnName("activitytype")
                    .IsUnicode(false);

                entity.Property(e => e.Apr1)
                    .HasColumnName("apr_1")
                    .HasColumnType("money");

                entity.Property(e => e.Apr2)
                    .HasColumnName("apr_2")
                    .HasColumnType("money");

                entity.Property(e => e.Apr3)
                    .HasColumnName("apr_3")
                    .HasColumnType("money");

                entity.Property(e => e.Aug1)
                    .HasColumnName("aug_1")
                    .HasColumnType("money");

                entity.Property(e => e.Aug2)
                    .HasColumnName("aug_2")
                    .HasColumnType("money");

                entity.Property(e => e.Aug3)
                    .HasColumnName("aug_3")
                    .HasColumnType("money");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Dec1)
                    .HasColumnName("dec_1")
                    .HasColumnType("money");

                entity.Property(e => e.Dec2)
                    .HasColumnName("dec_2")
                    .HasColumnType("money");

                entity.Property(e => e.Dec3)
                    .HasColumnName("dec_3")
                    .HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Feb1)
                    .HasColumnName("feb_1")
                    .HasColumnType("money");

                entity.Property(e => e.Feb2)
                    .HasColumnName("feb_2")
                    .HasColumnType("money");

                entity.Property(e => e.Feb3)
                    .HasColumnName("feb_3")
                    .HasColumnType("money");

                entity.Property(e => e.Fy1)
                    .HasColumnName("fy_1")
                    .HasColumnType("money");

                entity.Property(e => e.Fy2)
                    .HasColumnName("fy_2")
                    .HasColumnType("money");

                entity.Property(e => e.Fy3)
                    .HasColumnName("fy_3")
                    .HasColumnType("money");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Jan1)
                    .HasColumnName("jan_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jan2)
                    .HasColumnName("jan_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jan3)
                    .HasColumnName("jan_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jul1)
                    .HasColumnName("jul_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jul2)
                    .HasColumnName("jul_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jul3)
                    .HasColumnName("jul_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jun1)
                    .HasColumnName("jun_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jun2)
                    .HasColumnName("jun_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jun3)
                    .HasColumnName("jun_3")
                    .HasColumnType("money");

                entity.Property(e => e.Mar1)
                    .HasColumnName("mar_1")
                    .HasColumnType("money");

                entity.Property(e => e.Mar2)
                    .HasColumnName("mar_2")
                    .HasColumnType("money");

                entity.Property(e => e.Mar3)
                    .HasColumnName("mar_3")
                    .HasColumnType("money");

                entity.Property(e => e.May1)
                    .HasColumnName("may_1")
                    .HasColumnType("money");

                entity.Property(e => e.May2)
                    .HasColumnName("may_2")
                    .HasColumnType("money");

                entity.Property(e => e.May3)
                    .HasColumnName("may_3")
                    .HasColumnType("money");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Nov1)
                    .HasColumnName("nov_1")
                    .HasColumnType("money");

                entity.Property(e => e.Nov2)
                    .HasColumnName("nov_2")
                    .HasColumnType("money");

                entity.Property(e => e.Nov3)
                    .HasColumnName("nov_3")
                    .HasColumnType("money");

                entity.Property(e => e.Oct1)
                    .HasColumnName("oct_1")
                    .HasColumnType("money");

                entity.Property(e => e.Oct2)
                    .HasColumnName("oct_2")
                    .HasColumnType("money");

                entity.Property(e => e.Oct3)
                    .HasColumnName("oct_3")
                    .HasColumnType("money");

                entity.Property(e => e.Sep1)
                    .HasColumnName("sep_1")
                    .HasColumnType("money");

                entity.Property(e => e.Sep2)
                    .HasColumnName("sep_2")
                    .HasColumnType("money");

                entity.Property(e => e.Sep3)
                    .HasColumnName("sep_3")
                    .HasColumnType("money");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("unitprice")
                    .HasColumnType("money");

                entity.Property(e => e.Uom1)
                    .HasColumnName("uom1")
                    .IsUnicode(false);

                entity.Property(e => e.Uom2)
                    .HasColumnName("uom2")
                    .IsUnicode(false);

                entity.Property(e => e.Uom3)
                    .HasColumnName("uom3")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BudgetJobDetailNotes2018>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid, e.Costelementid, e.Lineid });

                entity.ToTable("budget_job_detail_notes_2018");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Costelementid)
                    .HasColumnName("costelementid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Activitytype)
                    .HasColumnName("activitytype")
                    .IsUnicode(false);

                entity.Property(e => e.Apr1)
                    .HasColumnName("apr_1")
                    .HasColumnType("money");

                entity.Property(e => e.Apr2)
                    .HasColumnName("apr_2")
                    .HasColumnType("money");

                entity.Property(e => e.Apr3)
                    .HasColumnName("apr_3")
                    .HasColumnType("money");

                entity.Property(e => e.Aug1)
                    .HasColumnName("aug_1")
                    .HasColumnType("money");

                entity.Property(e => e.Aug2)
                    .HasColumnName("aug_2")
                    .HasColumnType("money");

                entity.Property(e => e.Aug3)
                    .HasColumnName("aug_3")
                    .HasColumnType("money");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Dec1)
                    .HasColumnName("dec_1")
                    .HasColumnType("money");

                entity.Property(e => e.Dec2)
                    .HasColumnName("dec_2")
                    .HasColumnType("money");

                entity.Property(e => e.Dec3)
                    .HasColumnName("dec_3")
                    .HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Feb1)
                    .HasColumnName("feb_1")
                    .HasColumnType("money");

                entity.Property(e => e.Feb2)
                    .HasColumnName("feb_2")
                    .HasColumnType("money");

                entity.Property(e => e.Feb3)
                    .HasColumnName("feb_3")
                    .HasColumnType("money");

                entity.Property(e => e.Fy1)
                    .HasColumnName("fy_1")
                    .HasColumnType("money");

                entity.Property(e => e.Fy2)
                    .HasColumnName("fy_2")
                    .HasColumnType("money");

                entity.Property(e => e.Fy3)
                    .HasColumnName("fy_3")
                    .HasColumnType("money");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Jan1)
                    .HasColumnName("jan_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jan2)
                    .HasColumnName("jan_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jan3)
                    .HasColumnName("jan_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jul1)
                    .HasColumnName("jul_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jul2)
                    .HasColumnName("jul_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jul3)
                    .HasColumnName("jul_3")
                    .HasColumnType("money");

                entity.Property(e => e.Jun1)
                    .HasColumnName("jun_1")
                    .HasColumnType("money");

                entity.Property(e => e.Jun2)
                    .HasColumnName("jun_2")
                    .HasColumnType("money");

                entity.Property(e => e.Jun3)
                    .HasColumnName("jun_3")
                    .HasColumnType("money");

                entity.Property(e => e.Mar1)
                    .HasColumnName("mar_1")
                    .HasColumnType("money");

                entity.Property(e => e.Mar2)
                    .HasColumnName("mar_2")
                    .HasColumnType("money");

                entity.Property(e => e.Mar3)
                    .HasColumnName("mar_3")
                    .HasColumnType("money");

                entity.Property(e => e.May1)
                    .HasColumnName("may_1")
                    .HasColumnType("money");

                entity.Property(e => e.May2)
                    .HasColumnName("may_2")
                    .HasColumnType("money");

                entity.Property(e => e.May3)
                    .HasColumnName("may_3")
                    .HasColumnType("money");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Nov1)
                    .HasColumnName("nov_1")
                    .HasColumnType("money");

                entity.Property(e => e.Nov2)
                    .HasColumnName("nov_2")
                    .HasColumnType("money");

                entity.Property(e => e.Nov3)
                    .HasColumnName("nov_3")
                    .HasColumnType("money");

                entity.Property(e => e.Oct1)
                    .HasColumnName("oct_1")
                    .HasColumnType("money");

                entity.Property(e => e.Oct2)
                    .HasColumnName("oct_2")
                    .HasColumnType("money");

                entity.Property(e => e.Oct3)
                    .HasColumnName("oct_3")
                    .HasColumnType("money");

                entity.Property(e => e.Sep1)
                    .HasColumnName("sep_1")
                    .HasColumnType("money");

                entity.Property(e => e.Sep2)
                    .HasColumnName("sep_2")
                    .HasColumnType("money");

                entity.Property(e => e.Sep3)
                    .HasColumnName("sep_3")
                    .HasColumnType("money");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("unitprice")
                    .HasColumnType("money");

                entity.Property(e => e.Uom1)
                    .HasColumnName("uom1")
                    .IsUnicode(false);

                entity.Property(e => e.Uom2)
                    .HasColumnName("uom2")
                    .IsUnicode(false);

                entity.Property(e => e.Uom3)
                    .HasColumnName("uom3")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BudgetJobHeader>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid });

                entity.ToTable("budget_job_header");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cat1)
                    .HasColumnName("cat1")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat10)
                    .HasColumnName("cat10")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat2)
                    .HasColumnName("cat2")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat3)
                    .HasColumnName("cat3")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat4)
                    .HasColumnName("cat4")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat5)
                    .HasColumnName("cat5")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat6)
                    .HasColumnName("cat6")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat7)
                    .HasColumnName("cat7")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat8)
                    .HasColumnName("cat8")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat9)
                    .HasColumnName("cat9")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Costcenterdescription)
                    .HasColumnName("costcenterdescription")
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Functionid)
                    .HasColumnName("functionid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Revision).HasColumnName("revision");

                entity.Property(e => e.Subsegmentid)
                    .HasColumnName("subsegmentid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<BudgetJobMaster>(entity =>
            {
                entity.ToTable("budget_job_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Revision).HasColumnName("revision");

                entity.Property(e => e.Rmxdistother0)
                    .HasColumnName("rmxdistother0")
                    .IsUnicode(false);

                entity.Property(e => e.Rmxdistother1)
                    .HasColumnName("rmxdistother1")
                    .IsUnicode(false);

                entity.Property(e => e.Rmxdistother2)
                    .HasColumnName("rmxdistother2")
                    .IsUnicode(false);

                entity.Property(e => e.Rmxdistother3)
                    .HasColumnName("rmxdistother3")
                    .IsUnicode(false);

                entity.Property(e => e.Rmxdistother4)
                    .HasColumnName("rmxdistother4")
                    .IsUnicode(false);

                entity.Property(e => e.Rmxdistother5)
                    .HasColumnName("rmxdistother5")
                    .IsUnicode(false);

                entity.Property(e => e.Rmxdistother6)
                    .HasColumnName("rmxdistother6")
                    .IsUnicode(false);

                entity.Property(e => e.Rmxdistother7)
                    .HasColumnName("rmxdistother7")
                    .IsUnicode(false);

                entity.Property(e => e.Rmxdistother8)
                    .HasColumnName("rmxdistother8")
                    .IsUnicode(false);

                entity.Property(e => e.Rmxdistother9)
                    .HasColumnName("rmxdistother9")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Year).HasColumnName("year");

                entity.Property(e => e.Year1).HasColumnName("year1");

                entity.Property(e => e.Year2).HasColumnName("year2");

                entity.Property(e => e.Year3).HasColumnName("year3");
            });

            modelBuilder.Entity<BudgetJobUpload>(entity =>
            {
                entity.ToTable("budget_job_upload");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Budgetjobrevision).HasColumnName("budgetjobrevision");

                entity.Property(e => e.Budgetjobyear).HasColumnName("budgetjobyear");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .IsUnicode(false);

                entity.Property(e => e.Filepath)
                    .IsRequired()
                    .HasColumnName("filepath")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Starttime)
                    .HasColumnName("starttime")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoryCode>(entity =>
            {
                entity.HasKey(e => new { e.Subsegmentid, e.Categorycode, e.Code });

                entity.ToTable("category_code");

                entity.Property(e => e.Subsegmentid)
                    .HasColumnName("subsegmentid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Categorycode)
                    .HasColumnName("categorycode")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<CementMaster>(entity =>
            {
                entity.ToTable("cement_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Defaulttype).HasColumnName("defaulttype");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<CementRegionMaster>(entity =>
            {
                entity.ToTable("cement_region_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<ClcPrice>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Itemmasterid, e.Cementregionid });

                entity.ToTable("clc_price");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Itemmasterid).HasColumnName("itemmasterid");

                entity.Property(e => e.Cementregionid)
                    .HasColumnName("cementregionid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AspApr1)
                    .HasColumnName("asp_apr_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspApr2)
                    .HasColumnName("asp_apr_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspApr3)
                    .HasColumnName("asp_apr_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspAug1)
                    .HasColumnName("asp_aug_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspAug2)
                    .HasColumnName("asp_aug_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspAug3)
                    .HasColumnName("asp_aug_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspDec1)
                    .HasColumnName("asp_dec_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspDec2)
                    .HasColumnName("asp_dec_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspDec3)
                    .HasColumnName("asp_dec_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspFeb1)
                    .HasColumnName("asp_feb_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspFeb2)
                    .HasColumnName("asp_feb_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspFeb3)
                    .HasColumnName("asp_feb_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspJan1)
                    .HasColumnName("asp_jan_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspJan2)
                    .HasColumnName("asp_jan_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspJan3)
                    .HasColumnName("asp_jan_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspJul1)
                    .HasColumnName("asp_jul_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspJul2)
                    .HasColumnName("asp_jul_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspJul3)
                    .HasColumnName("asp_jul_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspJun1)
                    .HasColumnName("asp_jun_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspJun2)
                    .HasColumnName("asp_jun_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspJun3)
                    .HasColumnName("asp_jun_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspMar1)
                    .HasColumnName("asp_mar_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspMar2)
                    .HasColumnName("asp_mar_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspMar3)
                    .HasColumnName("asp_mar_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspMay1)
                    .HasColumnName("asp_may_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspMay2)
                    .HasColumnName("asp_may_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspMay3)
                    .HasColumnName("asp_may_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspMtp1)
                    .HasColumnName("asp_mtp_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspMtp2)
                    .HasColumnName("asp_mtp_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspMtp3)
                    .HasColumnName("asp_mtp_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspNov1)
                    .HasColumnName("asp_nov_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspNov2)
                    .HasColumnName("asp_nov_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspNov3)
                    .HasColumnName("asp_nov_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspOct1)
                    .HasColumnName("asp_oct_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspOct2)
                    .HasColumnName("asp_oct_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspOct3)
                    .HasColumnName("asp_oct_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspSep1)
                    .HasColumnName("asp_sep_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspSep2)
                    .HasColumnName("asp_sep_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspSep3)
                    .HasColumnName("asp_sep_3")
                    .HasColumnType("money");

                entity.Property(e => e.Cementregiondesc)
                    .HasColumnName("cementregiondesc")
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Itemmasterdesc)
                    .HasColumnName("itemmasterdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<CopBom>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Lineid });

                entity.ToTable("cop_bom");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Costelementid)
                    .HasColumnName("costelementid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CopProduction>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Itemid, e.BomLineid });

                entity.ToTable("cop_production");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.BomLineid).HasColumnName("bom_lineid");

                entity.Property(e => e.BomCostelement)
                    .HasColumnName("bom_costelement")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BomDesc)
                    .HasColumnName("bom_desc")
                    .IsUnicode(false);

                entity.Property(e => e.BomUom)
                    .HasColumnName("bom_uom")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.CstApr1)
                    .HasColumnName("cst_apr_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstApr2)
                    .HasColumnName("cst_apr_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstApr3)
                    .HasColumnName("cst_apr_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstAug1)
                    .HasColumnName("cst_aug_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstAug2)
                    .HasColumnName("cst_aug_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstAug3)
                    .HasColumnName("cst_aug_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstDec1)
                    .HasColumnName("cst_dec_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstDec2)
                    .HasColumnName("cst_dec_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstDec3)
                    .HasColumnName("cst_dec_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstFeb1)
                    .HasColumnName("cst_feb_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstFeb2)
                    .HasColumnName("cst_feb_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstFeb3)
                    .HasColumnName("cst_feb_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstJan1)
                    .HasColumnName("cst_jan_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstJan2)
                    .HasColumnName("cst_jan_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstJan3)
                    .HasColumnName("cst_jan_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstJul1)
                    .HasColumnName("cst_jul_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstJul2)
                    .HasColumnName("cst_jul_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstJul3)
                    .HasColumnName("cst_jul_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstJun1)
                    .HasColumnName("cst_jun_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstJun2)
                    .HasColumnName("cst_jun_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstJun3)
                    .HasColumnName("cst_jun_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstMar1)
                    .HasColumnName("cst_mar_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstMar2)
                    .HasColumnName("cst_mar_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstMar3)
                    .HasColumnName("cst_mar_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstMay1)
                    .HasColumnName("cst_may_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstMay2)
                    .HasColumnName("cst_may_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstMay3)
                    .HasColumnName("cst_may_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstMtp1)
                    .HasColumnName("cst_mtp_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstMtp2)
                    .HasColumnName("cst_mtp_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstMtp3)
                    .HasColumnName("cst_mtp_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstNov1)
                    .HasColumnName("cst_nov_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstNov2)
                    .HasColumnName("cst_nov_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstNov3)
                    .HasColumnName("cst_nov_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstOct1)
                    .HasColumnName("cst_oct_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstOct2)
                    .HasColumnName("cst_oct_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstOct3)
                    .HasColumnName("cst_oct_3")
                    .HasColumnType("money");

                entity.Property(e => e.CstSep1)
                    .HasColumnName("cst_sep_1")
                    .HasColumnType("money");

                entity.Property(e => e.CstSep2)
                    .HasColumnName("cst_sep_2")
                    .HasColumnType("money");

                entity.Property(e => e.CstSep3)
                    .HasColumnName("cst_sep_3")
                    .HasColumnType("money");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Itemcostcenter)
                    .HasColumnName("itemcostcenter")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Itemdesc)
                    .HasColumnName("itemdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Itemtype)
                    .HasColumnName("itemtype")
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.VolApr1)
                    .HasColumnName("vol_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolApr2)
                    .HasColumnName("vol_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolApr3)
                    .HasColumnName("vol_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolAug1)
                    .HasColumnName("vol_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolAug2)
                    .HasColumnName("vol_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolAug3)
                    .HasColumnName("vol_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolDec1)
                    .HasColumnName("vol_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolDec2)
                    .HasColumnName("vol_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolDec3)
                    .HasColumnName("vol_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolFeb1)
                    .HasColumnName("vol_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolFeb2)
                    .HasColumnName("vol_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolFeb3)
                    .HasColumnName("vol_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolJan1)
                    .HasColumnName("vol_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolJan2)
                    .HasColumnName("vol_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolJan3)
                    .HasColumnName("vol_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolJul1)
                    .HasColumnName("vol_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolJul2)
                    .HasColumnName("vol_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolJul3)
                    .HasColumnName("vol_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolJun1)
                    .HasColumnName("vol_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolJun2)
                    .HasColumnName("vol_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolJun3)
                    .HasColumnName("vol_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolMar1)
                    .HasColumnName("vol_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolMar2)
                    .HasColumnName("vol_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolMar3)
                    .HasColumnName("vol_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolMay1)
                    .HasColumnName("vol_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolMay2)
                    .HasColumnName("vol_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolMay3)
                    .HasColumnName("vol_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolMtp1)
                    .HasColumnName("vol_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolMtp2)
                    .HasColumnName("vol_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolMtp3)
                    .HasColumnName("vol_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolNov1)
                    .HasColumnName("vol_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolNov2)
                    .HasColumnName("vol_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolNov3)
                    .HasColumnName("vol_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolOct1)
                    .HasColumnName("vol_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolOct2)
                    .HasColumnName("vol_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolOct3)
                    .HasColumnName("vol_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolSep1)
                    .HasColumnName("vol_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolSep2)
                    .HasColumnName("vol_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolSep3)
                    .HasColumnName("vol_sep_3")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<CopSales>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Itemid });

                entity.ToTable("cop_sales");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.AspApr1)
                    .HasColumnName("asp_apr_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspApr2)
                    .HasColumnName("asp_apr_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspApr3)
                    .HasColumnName("asp_apr_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspAug1)
                    .HasColumnName("asp_aug_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspAug2)
                    .HasColumnName("asp_aug_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspAug3)
                    .HasColumnName("asp_aug_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspDec1)
                    .HasColumnName("asp_dec_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspDec2)
                    .HasColumnName("asp_dec_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspDec3)
                    .HasColumnName("asp_dec_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspFeb1)
                    .HasColumnName("asp_feb_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspFeb2)
                    .HasColumnName("asp_feb_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspFeb3)
                    .HasColumnName("asp_feb_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJan1)
                    .HasColumnName("asp_jan_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJan2)
                    .HasColumnName("asp_jan_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJan3)
                    .HasColumnName("asp_jan_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJul1)
                    .HasColumnName("asp_jul_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJul2)
                    .HasColumnName("asp_jul_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJul3)
                    .HasColumnName("asp_jul_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJun1)
                    .HasColumnName("asp_jun_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJun2)
                    .HasColumnName("asp_jun_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJun3)
                    .HasColumnName("asp_jun_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMar1)
                    .HasColumnName("asp_mar_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMar2)
                    .HasColumnName("asp_mar_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMar3)
                    .HasColumnName("asp_mar_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMay1)
                    .HasColumnName("asp_may_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMay2)
                    .HasColumnName("asp_may_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMay3)
                    .HasColumnName("asp_may_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMtp1)
                    .HasColumnName("asp_mtp_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMtp2)
                    .HasColumnName("asp_mtp_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMtp3)
                    .HasColumnName("asp_mtp_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspNov1)
                    .HasColumnName("asp_nov_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspNov2)
                    .HasColumnName("asp_nov_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspNov3)
                    .HasColumnName("asp_nov_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspOct1)
                    .HasColumnName("asp_oct_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspOct2)
                    .HasColumnName("asp_oct_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspOct3)
                    .HasColumnName("asp_oct_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspSep1)
                    .HasColumnName("asp_sep_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspSep2)
                    .HasColumnName("asp_sep_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspSep3)
                    .HasColumnName("asp_sep_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Itemcostcenter)
                    .HasColumnName("itemcostcenter")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Itemdesc)
                    .HasColumnName("itemdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Itemtype)
                    .HasColumnName("itemtype")
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.NetApr1)
                    .HasColumnName("net_apr_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetApr2)
                    .HasColumnName("net_apr_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetApr3)
                    .HasColumnName("net_apr_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAug1)
                    .HasColumnName("net_aug_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAug2)
                    .HasColumnName("net_aug_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAug3)
                    .HasColumnName("net_aug_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetDec1)
                    .HasColumnName("net_dec_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetDec2)
                    .HasColumnName("net_dec_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetDec3)
                    .HasColumnName("net_dec_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFeb1)
                    .HasColumnName("net_feb_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFeb2)
                    .HasColumnName("net_feb_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFeb3)
                    .HasColumnName("net_feb_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJan1)
                    .HasColumnName("net_jan_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJan2)
                    .HasColumnName("net_jan_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJan3)
                    .HasColumnName("net_jan_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJul1)
                    .HasColumnName("net_jul_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJul2)
                    .HasColumnName("net_jul_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJul3)
                    .HasColumnName("net_jul_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJun1)
                    .HasColumnName("net_jun_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJun2)
                    .HasColumnName("net_jun_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJun3)
                    .HasColumnName("net_jun_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMar1)
                    .HasColumnName("net_mar_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMar2)
                    .HasColumnName("net_mar_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMar3)
                    .HasColumnName("net_mar_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMay1)
                    .HasColumnName("net_may_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMay2)
                    .HasColumnName("net_may_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMay3)
                    .HasColumnName("net_may_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMtp1)
                    .HasColumnName("net_mtp_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMtp2)
                    .HasColumnName("net_mtp_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMtp3)
                    .HasColumnName("net_mtp_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetNov1)
                    .HasColumnName("net_nov_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetNov2)
                    .HasColumnName("net_nov_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetNov3)
                    .HasColumnName("net_nov_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetOct1)
                    .HasColumnName("net_oct_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetOct2)
                    .HasColumnName("net_oct_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetOct3)
                    .HasColumnName("net_oct_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetSep1)
                    .HasColumnName("net_sep_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetSep2)
                    .HasColumnName("net_sep_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetSep3)
                    .HasColumnName("net_sep_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolApr1)
                    .HasColumnName("vol_apr_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolApr2)
                    .HasColumnName("vol_apr_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolApr3)
                    .HasColumnName("vol_apr_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolAug1)
                    .HasColumnName("vol_aug_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolAug2)
                    .HasColumnName("vol_aug_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolAug3)
                    .HasColumnName("vol_aug_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolDec1)
                    .HasColumnName("vol_dec_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolDec2)
                    .HasColumnName("vol_dec_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolDec3)
                    .HasColumnName("vol_dec_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolFeb1)
                    .HasColumnName("vol_feb_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolFeb2)
                    .HasColumnName("vol_feb_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolFeb3)
                    .HasColumnName("vol_feb_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJan1)
                    .HasColumnName("vol_jan_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJan2)
                    .HasColumnName("vol_jan_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJan3)
                    .HasColumnName("vol_jan_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJul1)
                    .HasColumnName("vol_jul_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJul2)
                    .HasColumnName("vol_jul_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJul3)
                    .HasColumnName("vol_jul_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJun1)
                    .HasColumnName("vol_jun_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJun2)
                    .HasColumnName("vol_jun_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJun3)
                    .HasColumnName("vol_jun_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMar1)
                    .HasColumnName("vol_mar_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMar2)
                    .HasColumnName("vol_mar_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMar3)
                    .HasColumnName("vol_mar_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMay1)
                    .HasColumnName("vol_may_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMay2)
                    .HasColumnName("vol_may_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMay3)
                    .HasColumnName("vol_may_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMtp1)
                    .HasColumnName("vol_mtp_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMtp2)
                    .HasColumnName("vol_mtp_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMtp3)
                    .HasColumnName("vol_mtp_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolNov1)
                    .HasColumnName("vol_nov_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolNov2)
                    .HasColumnName("vol_nov_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolNov3)
                    .HasColumnName("vol_nov_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolOct1)
                    .HasColumnName("vol_oct_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolOct2)
                    .HasColumnName("vol_oct_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolOct3)
                    .HasColumnName("vol_oct_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolSep1)
                    .HasColumnName("vol_sep_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolSep2)
                    .HasColumnName("vol_sep_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolSep3)
                    .HasColumnName("vol_sep_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CostCenterDetail>(entity =>
            {
                entity.HasKey(e => new { e.Costcenterid, e.Costelementid });

                entity.ToTable("cost_center_detail");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Costelementid)
                    .HasColumnName("costelementid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<CostCenterMaster>(entity =>
            {
                entity.ToTable("cost_center_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cat1)
                    .HasColumnName("cat1")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat10)
                    .HasColumnName("cat10")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat2)
                    .HasColumnName("cat2")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat3)
                    .HasColumnName("cat3")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat4)
                    .HasColumnName("cat4")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat5)
                    .HasColumnName("cat5")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat6)
                    .HasColumnName("cat6")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat7)
                    .HasColumnName("cat7")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat8)
                    .HasColumnName("cat8")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cat9)
                    .HasColumnName("cat9")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Functionid)
                    .HasColumnName("functionid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Subsegmentid)
                    .HasColumnName("subsegmentid")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CostElementGroupMaster>(entity =>
            {
                entity.ToTable("cost_element_group_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Costtypeid)
                    .HasColumnName("costtypeid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<CostElementMaster>(entity =>
            {
                entity.ToTable("cost_element_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Costelementgroupid)
                    .HasColumnName("costelementgroupid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.ToTable("counter");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Counter1).HasColumnName("counter");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<FunctionMaster>(entity =>
            {
                entity.ToTable("function_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<IncomeStatementConfigDetail>(entity =>
            {
                entity.HasKey(e => new { e.Ischid, e.Costelementgroupid });

                entity.ToTable("income_statement_config_detail");

                entity.Property(e => e.Ischid)
                    .HasColumnName("ischid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Costelementgroupid)
                    .HasColumnName("costelementgroupid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<IncomeStatementConfigHeader>(entity =>
            {
                entity.ToTable("income_statement_config_header");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Functionid)
                    .HasColumnName("functionid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<ItemMaster>(entity =>
            {
                entity.ToTable("item_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemPrice>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Itemmasterid, e.Batchingplantid });

                entity.ToTable("item_price");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Itemmasterid).HasColumnName("itemmasterid");

                entity.Property(e => e.Batchingplantid)
                    .HasColumnName("batchingplantid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AspApr1)
                    .HasColumnName("asp_apr_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspApr2)
                    .HasColumnName("asp_apr_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspApr3)
                    .HasColumnName("asp_apr_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspAug1)
                    .HasColumnName("asp_aug_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspAug2)
                    .HasColumnName("asp_aug_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspAug3)
                    .HasColumnName("asp_aug_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspDec1)
                    .HasColumnName("asp_dec_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspDec2)
                    .HasColumnName("asp_dec_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspDec3)
                    .HasColumnName("asp_dec_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspFeb1)
                    .HasColumnName("asp_feb_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspFeb2)
                    .HasColumnName("asp_feb_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspFeb3)
                    .HasColumnName("asp_feb_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspJan1)
                    .HasColumnName("asp_jan_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspJan2)
                    .HasColumnName("asp_jan_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspJan3)
                    .HasColumnName("asp_jan_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspJul1)
                    .HasColumnName("asp_jul_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspJul2)
                    .HasColumnName("asp_jul_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspJul3)
                    .HasColumnName("asp_jul_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspJun1)
                    .HasColumnName("asp_jun_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspJun2)
                    .HasColumnName("asp_jun_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspJun3)
                    .HasColumnName("asp_jun_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspMar1)
                    .HasColumnName("asp_mar_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspMar2)
                    .HasColumnName("asp_mar_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspMar3)
                    .HasColumnName("asp_mar_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspMay1)
                    .HasColumnName("asp_may_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspMay2)
                    .HasColumnName("asp_may_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspMay3)
                    .HasColumnName("asp_may_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspMtp1)
                    .HasColumnName("asp_mtp_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspMtp2)
                    .HasColumnName("asp_mtp_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspMtp3)
                    .HasColumnName("asp_mtp_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspNov1)
                    .HasColumnName("asp_nov_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspNov2)
                    .HasColumnName("asp_nov_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspNov3)
                    .HasColumnName("asp_nov_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspOct1)
                    .HasColumnName("asp_oct_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspOct2)
                    .HasColumnName("asp_oct_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspOct3)
                    .HasColumnName("asp_oct_3")
                    .HasColumnType("money");

                entity.Property(e => e.AspSep1)
                    .HasColumnName("asp_sep_1")
                    .HasColumnType("money");

                entity.Property(e => e.AspSep2)
                    .HasColumnName("asp_sep_2")
                    .HasColumnType("money");

                entity.Property(e => e.AspSep3)
                    .HasColumnName("asp_sep_3")
                    .HasColumnType("money");

                entity.Property(e => e.Batchingplantdesc)
                    .HasColumnName("batchingplantdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplanttype)
                    .HasColumnName("batchingplanttype")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Itemmasterdesc)
                    .HasColumnName("itemmasterdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Regiondesc)
                    .HasColumnName("regiondesc")
                    .IsUnicode(false);

                entity.Property(e => e.Regionid).HasColumnName("regionid");
            });

            modelBuilder.Entity<QuarryMaster>(entity =>
            {
                entity.ToTable("quarry_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<RegionMaster>(entity =>
            {
                entity.ToTable("region_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");
            });

            modelBuilder.Entity<RmxCement>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Rmxcomponentid, e.Batchingplantid });

                entity.ToTable("rmx_cement");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Rmxcomponentid).HasColumnName("rmxcomponentid");

                entity.Property(e => e.Batchingplantid)
                    .HasColumnName("batchingplantid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplantdesc)
                    .HasColumnName("batchingplantdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplanttype)
                    .HasColumnName("batchingplanttype")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Distcostcenterid)
                    .HasColumnName("distcostcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Item0).HasColumnName("item0");

                entity.Property(e => e.Item0Desc)
                    .HasColumnName("item0_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item1).HasColumnName("item1");

                entity.Property(e => e.Item1Desc)
                    .HasColumnName("item1_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item2).HasColumnName("item2");

                entity.Property(e => e.Item2Desc)
                    .HasColumnName("item2_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item3).HasColumnName("item3");

                entity.Property(e => e.Item3Desc)
                    .HasColumnName("item3_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item4).HasColumnName("item4");

                entity.Property(e => e.Item4Desc)
                    .HasColumnName("item4_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item5).HasColumnName("item5");

                entity.Property(e => e.Item5Desc)
                    .HasColumnName("item5_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item6).HasColumnName("item6");

                entity.Property(e => e.Item6Desc)
                    .HasColumnName("item6_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item7).HasColumnName("item7");

                entity.Property(e => e.Item7Desc)
                    .HasColumnName("item7_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item8).HasColumnName("item8");

                entity.Property(e => e.Item8Desc)
                    .HasColumnName("item8_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item9).HasColumnName("item9");

                entity.Property(e => e.Item9Desc)
                    .HasColumnName("item9_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Prodcostcenterid)
                    .HasColumnName("prodcostcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regiondesc)
                    .HasColumnName("regiondesc")
                    .IsUnicode(false);

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Vol0Apr1)
                    .HasColumnName("vol0_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Apr2)
                    .HasColumnName("vol0_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Apr3)
                    .HasColumnName("vol0_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Aug1)
                    .HasColumnName("vol0_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Aug2)
                    .HasColumnName("vol0_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Aug3)
                    .HasColumnName("vol0_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Dec1)
                    .HasColumnName("vol0_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Dec2)
                    .HasColumnName("vol0_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Dec3)
                    .HasColumnName("vol0_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Feb1)
                    .HasColumnName("vol0_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Feb2)
                    .HasColumnName("vol0_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Feb3)
                    .HasColumnName("vol0_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Jan1)
                    .HasColumnName("vol0_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Jan2)
                    .HasColumnName("vol0_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Jan3)
                    .HasColumnName("vol0_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Jul1)
                    .HasColumnName("vol0_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Jul2)
                    .HasColumnName("vol0_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Jul3)
                    .HasColumnName("vol0_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Jun1)
                    .HasColumnName("vol0_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Jun2)
                    .HasColumnName("vol0_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Jun3)
                    .HasColumnName("vol0_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Mar1)
                    .HasColumnName("vol0_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Mar2)
                    .HasColumnName("vol0_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Mar3)
                    .HasColumnName("vol0_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0May1)
                    .HasColumnName("vol0_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0May2)
                    .HasColumnName("vol0_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0May3)
                    .HasColumnName("vol0_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Mtp1)
                    .HasColumnName("vol0_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Mtp2)
                    .HasColumnName("vol0_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Mtp3)
                    .HasColumnName("vol0_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Nov1)
                    .HasColumnName("vol0_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Nov2)
                    .HasColumnName("vol0_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Nov3)
                    .HasColumnName("vol0_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Oct1)
                    .HasColumnName("vol0_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Oct2)
                    .HasColumnName("vol0_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Oct3)
                    .HasColumnName("vol0_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Sep1)
                    .HasColumnName("vol0_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Sep2)
                    .HasColumnName("vol0_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol0Sep3)
                    .HasColumnName("vol0_sep_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Apr1)
                    .HasColumnName("vol1_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Apr2)
                    .HasColumnName("vol1_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Apr3)
                    .HasColumnName("vol1_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Aug1)
                    .HasColumnName("vol1_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Aug2)
                    .HasColumnName("vol1_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Aug3)
                    .HasColumnName("vol1_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Dec1)
                    .HasColumnName("vol1_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Dec2)
                    .HasColumnName("vol1_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Dec3)
                    .HasColumnName("vol1_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Feb1)
                    .HasColumnName("vol1_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Feb2)
                    .HasColumnName("vol1_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Feb3)
                    .HasColumnName("vol1_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Jan1)
                    .HasColumnName("vol1_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Jan2)
                    .HasColumnName("vol1_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Jan3)
                    .HasColumnName("vol1_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Jul1)
                    .HasColumnName("vol1_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Jul2)
                    .HasColumnName("vol1_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Jul3)
                    .HasColumnName("vol1_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Jun1)
                    .HasColumnName("vol1_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Jun2)
                    .HasColumnName("vol1_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Jun3)
                    .HasColumnName("vol1_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Mar1)
                    .HasColumnName("vol1_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Mar2)
                    .HasColumnName("vol1_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Mar3)
                    .HasColumnName("vol1_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1May1)
                    .HasColumnName("vol1_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1May2)
                    .HasColumnName("vol1_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1May3)
                    .HasColumnName("vol1_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Mtp1)
                    .HasColumnName("vol1_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Mtp2)
                    .HasColumnName("vol1_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Mtp3)
                    .HasColumnName("vol1_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Nov1)
                    .HasColumnName("vol1_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Nov2)
                    .HasColumnName("vol1_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Nov3)
                    .HasColumnName("vol1_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Oct1)
                    .HasColumnName("vol1_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Oct2)
                    .HasColumnName("vol1_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Oct3)
                    .HasColumnName("vol1_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Sep1)
                    .HasColumnName("vol1_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Sep2)
                    .HasColumnName("vol1_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol1Sep3)
                    .HasColumnName("vol1_sep_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Apr1)
                    .HasColumnName("vol2_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Apr2)
                    .HasColumnName("vol2_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Apr3)
                    .HasColumnName("vol2_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Aug1)
                    .HasColumnName("vol2_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Aug2)
                    .HasColumnName("vol2_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Aug3)
                    .HasColumnName("vol2_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Dec1)
                    .HasColumnName("vol2_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Dec2)
                    .HasColumnName("vol2_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Dec3)
                    .HasColumnName("vol2_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Feb1)
                    .HasColumnName("vol2_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Feb2)
                    .HasColumnName("vol2_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Feb3)
                    .HasColumnName("vol2_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Jan1)
                    .HasColumnName("vol2_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Jan2)
                    .HasColumnName("vol2_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Jan3)
                    .HasColumnName("vol2_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Jul1)
                    .HasColumnName("vol2_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Jul2)
                    .HasColumnName("vol2_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Jul3)
                    .HasColumnName("vol2_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Jun1)
                    .HasColumnName("vol2_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Jun2)
                    .HasColumnName("vol2_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Jun3)
                    .HasColumnName("vol2_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Mar1)
                    .HasColumnName("vol2_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Mar2)
                    .HasColumnName("vol2_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Mar3)
                    .HasColumnName("vol2_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2May1)
                    .HasColumnName("vol2_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2May2)
                    .HasColumnName("vol2_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2May3)
                    .HasColumnName("vol2_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Mtp1)
                    .HasColumnName("vol2_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Mtp2)
                    .HasColumnName("vol2_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Mtp3)
                    .HasColumnName("vol2_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Nov1)
                    .HasColumnName("vol2_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Nov2)
                    .HasColumnName("vol2_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Nov3)
                    .HasColumnName("vol2_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Oct1)
                    .HasColumnName("vol2_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Oct2)
                    .HasColumnName("vol2_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Oct3)
                    .HasColumnName("vol2_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Sep1)
                    .HasColumnName("vol2_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Sep2)
                    .HasColumnName("vol2_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol2Sep3)
                    .HasColumnName("vol2_sep_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Apr1)
                    .HasColumnName("vol3_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Apr2)
                    .HasColumnName("vol3_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Apr3)
                    .HasColumnName("vol3_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Aug1)
                    .HasColumnName("vol3_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Aug2)
                    .HasColumnName("vol3_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Aug3)
                    .HasColumnName("vol3_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Dec1)
                    .HasColumnName("vol3_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Dec2)
                    .HasColumnName("vol3_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Dec3)
                    .HasColumnName("vol3_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Feb1)
                    .HasColumnName("vol3_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Feb2)
                    .HasColumnName("vol3_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Feb3)
                    .HasColumnName("vol3_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Jan1)
                    .HasColumnName("vol3_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Jan2)
                    .HasColumnName("vol3_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Jan3)
                    .HasColumnName("vol3_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Jul1)
                    .HasColumnName("vol3_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Jul2)
                    .HasColumnName("vol3_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Jul3)
                    .HasColumnName("vol3_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Jun1)
                    .HasColumnName("vol3_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Jun2)
                    .HasColumnName("vol3_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Jun3)
                    .HasColumnName("vol3_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Mar1)
                    .HasColumnName("vol3_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Mar2)
                    .HasColumnName("vol3_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Mar3)
                    .HasColumnName("vol3_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3May1)
                    .HasColumnName("vol3_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3May2)
                    .HasColumnName("vol3_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3May3)
                    .HasColumnName("vol3_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Mtp1)
                    .HasColumnName("vol3_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Mtp2)
                    .HasColumnName("vol3_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Mtp3)
                    .HasColumnName("vol3_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Nov1)
                    .HasColumnName("vol3_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Nov2)
                    .HasColumnName("vol3_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Nov3)
                    .HasColumnName("vol3_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Oct1)
                    .HasColumnName("vol3_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Oct2)
                    .HasColumnName("vol3_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Oct3)
                    .HasColumnName("vol3_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Sep1)
                    .HasColumnName("vol3_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Sep2)
                    .HasColumnName("vol3_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol3Sep3)
                    .HasColumnName("vol3_sep_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Apr1)
                    .HasColumnName("vol4_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Apr2)
                    .HasColumnName("vol4_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Apr3)
                    .HasColumnName("vol4_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Aug1)
                    .HasColumnName("vol4_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Aug2)
                    .HasColumnName("vol4_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Aug3)
                    .HasColumnName("vol4_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Dec1)
                    .HasColumnName("vol4_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Dec2)
                    .HasColumnName("vol4_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Dec3)
                    .HasColumnName("vol4_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Feb1)
                    .HasColumnName("vol4_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Feb2)
                    .HasColumnName("vol4_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Feb3)
                    .HasColumnName("vol4_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Jan1)
                    .HasColumnName("vol4_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Jan2)
                    .HasColumnName("vol4_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Jan3)
                    .HasColumnName("vol4_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Jul1)
                    .HasColumnName("vol4_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Jul2)
                    .HasColumnName("vol4_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Jul3)
                    .HasColumnName("vol4_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Jun1)
                    .HasColumnName("vol4_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Jun2)
                    .HasColumnName("vol4_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Jun3)
                    .HasColumnName("vol4_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Mar1)
                    .HasColumnName("vol4_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Mar2)
                    .HasColumnName("vol4_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Mar3)
                    .HasColumnName("vol4_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4May1)
                    .HasColumnName("vol4_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4May2)
                    .HasColumnName("vol4_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4May3)
                    .HasColumnName("vol4_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Mtp1)
                    .HasColumnName("vol4_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Mtp2)
                    .HasColumnName("vol4_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Mtp3)
                    .HasColumnName("vol4_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Nov1)
                    .HasColumnName("vol4_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Nov2)
                    .HasColumnName("vol4_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Nov3)
                    .HasColumnName("vol4_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Oct1)
                    .HasColumnName("vol4_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Oct2)
                    .HasColumnName("vol4_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Oct3)
                    .HasColumnName("vol4_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Sep1)
                    .HasColumnName("vol4_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Sep2)
                    .HasColumnName("vol4_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol4Sep3)
                    .HasColumnName("vol4_sep_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Apr1)
                    .HasColumnName("vol5_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Apr2)
                    .HasColumnName("vol5_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Apr3)
                    .HasColumnName("vol5_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Aug1)
                    .HasColumnName("vol5_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Aug2)
                    .HasColumnName("vol5_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Aug3)
                    .HasColumnName("vol5_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Dec1)
                    .HasColumnName("vol5_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Dec2)
                    .HasColumnName("vol5_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Dec3)
                    .HasColumnName("vol5_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Feb1)
                    .HasColumnName("vol5_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Feb2)
                    .HasColumnName("vol5_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Feb3)
                    .HasColumnName("vol5_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Jan1)
                    .HasColumnName("vol5_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Jan2)
                    .HasColumnName("vol5_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Jan3)
                    .HasColumnName("vol5_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Jul1)
                    .HasColumnName("vol5_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Jul2)
                    .HasColumnName("vol5_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Jul3)
                    .HasColumnName("vol5_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Jun1)
                    .HasColumnName("vol5_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Jun2)
                    .HasColumnName("vol5_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Jun3)
                    .HasColumnName("vol5_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Mar1)
                    .HasColumnName("vol5_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Mar2)
                    .HasColumnName("vol5_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Mar3)
                    .HasColumnName("vol5_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5May1)
                    .HasColumnName("vol5_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5May2)
                    .HasColumnName("vol5_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5May3)
                    .HasColumnName("vol5_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Mtp1)
                    .HasColumnName("vol5_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Mtp2)
                    .HasColumnName("vol5_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Mtp3)
                    .HasColumnName("vol5_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Nov1)
                    .HasColumnName("vol5_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Nov2)
                    .HasColumnName("vol5_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Nov3)
                    .HasColumnName("vol5_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Oct1)
                    .HasColumnName("vol5_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Oct2)
                    .HasColumnName("vol5_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Oct3)
                    .HasColumnName("vol5_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Sep1)
                    .HasColumnName("vol5_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Sep2)
                    .HasColumnName("vol5_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol5Sep3)
                    .HasColumnName("vol5_sep_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Apr1)
                    .HasColumnName("vol6_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Apr2)
                    .HasColumnName("vol6_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Apr3)
                    .HasColumnName("vol6_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Aug1)
                    .HasColumnName("vol6_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Aug2)
                    .HasColumnName("vol6_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Aug3)
                    .HasColumnName("vol6_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Dec1)
                    .HasColumnName("vol6_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Dec2)
                    .HasColumnName("vol6_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Dec3)
                    .HasColumnName("vol6_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Feb1)
                    .HasColumnName("vol6_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Feb2)
                    .HasColumnName("vol6_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Feb3)
                    .HasColumnName("vol6_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Jan1)
                    .HasColumnName("vol6_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Jan2)
                    .HasColumnName("vol6_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Jan3)
                    .HasColumnName("vol6_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Jul1)
                    .HasColumnName("vol6_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Jul2)
                    .HasColumnName("vol6_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Jul3)
                    .HasColumnName("vol6_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Jun1)
                    .HasColumnName("vol6_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Jun2)
                    .HasColumnName("vol6_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Jun3)
                    .HasColumnName("vol6_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Mar1)
                    .HasColumnName("vol6_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Mar2)
                    .HasColumnName("vol6_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Mar3)
                    .HasColumnName("vol6_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6May1)
                    .HasColumnName("vol6_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6May2)
                    .HasColumnName("vol6_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6May3)
                    .HasColumnName("vol6_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Mtp1)
                    .HasColumnName("vol6_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Mtp2)
                    .HasColumnName("vol6_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Mtp3)
                    .HasColumnName("vol6_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Nov1)
                    .HasColumnName("vol6_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Nov2)
                    .HasColumnName("vol6_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Nov3)
                    .HasColumnName("vol6_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Oct1)
                    .HasColumnName("vol6_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Oct2)
                    .HasColumnName("vol6_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Oct3)
                    .HasColumnName("vol6_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Sep1)
                    .HasColumnName("vol6_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Sep2)
                    .HasColumnName("vol6_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol6Sep3)
                    .HasColumnName("vol6_sep_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Apr1)
                    .HasColumnName("vol7_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Apr2)
                    .HasColumnName("vol7_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Apr3)
                    .HasColumnName("vol7_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Aug1)
                    .HasColumnName("vol7_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Aug2)
                    .HasColumnName("vol7_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Aug3)
                    .HasColumnName("vol7_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Dec1)
                    .HasColumnName("vol7_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Dec2)
                    .HasColumnName("vol7_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Dec3)
                    .HasColumnName("vol7_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Feb1)
                    .HasColumnName("vol7_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Feb2)
                    .HasColumnName("vol7_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Feb3)
                    .HasColumnName("vol7_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Jan1)
                    .HasColumnName("vol7_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Jan2)
                    .HasColumnName("vol7_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Jan3)
                    .HasColumnName("vol7_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Jul1)
                    .HasColumnName("vol7_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Jul2)
                    .HasColumnName("vol7_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Jul3)
                    .HasColumnName("vol7_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Jun1)
                    .HasColumnName("vol7_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Jun2)
                    .HasColumnName("vol7_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Jun3)
                    .HasColumnName("vol7_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Mar1)
                    .HasColumnName("vol7_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Mar2)
                    .HasColumnName("vol7_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Mar3)
                    .HasColumnName("vol7_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7May1)
                    .HasColumnName("vol7_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7May2)
                    .HasColumnName("vol7_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7May3)
                    .HasColumnName("vol7_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Mtp1)
                    .HasColumnName("vol7_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Mtp2)
                    .HasColumnName("vol7_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Mtp3)
                    .HasColumnName("vol7_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Nov1)
                    .HasColumnName("vol7_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Nov2)
                    .HasColumnName("vol7_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Nov3)
                    .HasColumnName("vol7_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Oct1)
                    .HasColumnName("vol7_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Oct2)
                    .HasColumnName("vol7_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Oct3)
                    .HasColumnName("vol7_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Sep1)
                    .HasColumnName("vol7_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Sep2)
                    .HasColumnName("vol7_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol7Sep3)
                    .HasColumnName("vol7_sep_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Apr1)
                    .HasColumnName("vol8_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Apr2)
                    .HasColumnName("vol8_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Apr3)
                    .HasColumnName("vol8_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Aug1)
                    .HasColumnName("vol8_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Aug2)
                    .HasColumnName("vol8_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Aug3)
                    .HasColumnName("vol8_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Dec1)
                    .HasColumnName("vol8_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Dec2)
                    .HasColumnName("vol8_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Dec3)
                    .HasColumnName("vol8_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Feb1)
                    .HasColumnName("vol8_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Feb2)
                    .HasColumnName("vol8_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Feb3)
                    .HasColumnName("vol8_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Jan1)
                    .HasColumnName("vol8_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Jan2)
                    .HasColumnName("vol8_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Jan3)
                    .HasColumnName("vol8_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Jul1)
                    .HasColumnName("vol8_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Jul2)
                    .HasColumnName("vol8_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Jul3)
                    .HasColumnName("vol8_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Jun1)
                    .HasColumnName("vol8_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Jun2)
                    .HasColumnName("vol8_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Jun3)
                    .HasColumnName("vol8_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Mar1)
                    .HasColumnName("vol8_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Mar2)
                    .HasColumnName("vol8_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Mar3)
                    .HasColumnName("vol8_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8May1)
                    .HasColumnName("vol8_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8May2)
                    .HasColumnName("vol8_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8May3)
                    .HasColumnName("vol8_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Mtp1)
                    .HasColumnName("vol8_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Mtp2)
                    .HasColumnName("vol8_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Mtp3)
                    .HasColumnName("vol8_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Nov1)
                    .HasColumnName("vol8_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Nov2)
                    .HasColumnName("vol8_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Nov3)
                    .HasColumnName("vol8_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Oct1)
                    .HasColumnName("vol8_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Oct2)
                    .HasColumnName("vol8_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Oct3)
                    .HasColumnName("vol8_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Sep1)
                    .HasColumnName("vol8_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Sep2)
                    .HasColumnName("vol8_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol8Sep3)
                    .HasColumnName("vol8_sep_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Apr1)
                    .HasColumnName("vol9_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Apr2)
                    .HasColumnName("vol9_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Apr3)
                    .HasColumnName("vol9_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Aug1)
                    .HasColumnName("vol9_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Aug2)
                    .HasColumnName("vol9_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Aug3)
                    .HasColumnName("vol9_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Dec1)
                    .HasColumnName("vol9_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Dec2)
                    .HasColumnName("vol9_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Dec3)
                    .HasColumnName("vol9_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Feb1)
                    .HasColumnName("vol9_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Feb2)
                    .HasColumnName("vol9_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Feb3)
                    .HasColumnName("vol9_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Jan1)
                    .HasColumnName("vol9_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Jan2)
                    .HasColumnName("vol9_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Jan3)
                    .HasColumnName("vol9_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Jul1)
                    .HasColumnName("vol9_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Jul2)
                    .HasColumnName("vol9_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Jul3)
                    .HasColumnName("vol9_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Jun1)
                    .HasColumnName("vol9_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Jun2)
                    .HasColumnName("vol9_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Jun3)
                    .HasColumnName("vol9_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Mar1)
                    .HasColumnName("vol9_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Mar2)
                    .HasColumnName("vol9_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Mar3)
                    .HasColumnName("vol9_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9May1)
                    .HasColumnName("vol9_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9May2)
                    .HasColumnName("vol9_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9May3)
                    .HasColumnName("vol9_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Mtp1)
                    .HasColumnName("vol9_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Mtp2)
                    .HasColumnName("vol9_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Mtp3)
                    .HasColumnName("vol9_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Nov1)
                    .HasColumnName("vol9_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Nov2)
                    .HasColumnName("vol9_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Nov3)
                    .HasColumnName("vol9_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Oct1)
                    .HasColumnName("vol9_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Oct2)
                    .HasColumnName("vol9_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Oct3)
                    .HasColumnName("vol9_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Sep1)
                    .HasColumnName("vol9_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Sep2)
                    .HasColumnName("vol9_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vol9Sep3)
                    .HasColumnName("vol9_sep_3")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<RmxComponent>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Rmxcomponentid });

                entity.ToTable("rmx_component");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Rmxcomponentid).HasColumnName("rmxcomponentid");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Item0).HasColumnName("item0");

                entity.Property(e => e.Item0Desc)
                    .HasColumnName("item0_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item1).HasColumnName("item1");

                entity.Property(e => e.Item1Desc)
                    .HasColumnName("item1_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item2).HasColumnName("item2");

                entity.Property(e => e.Item2Desc)
                    .HasColumnName("item2_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item3).HasColumnName("item3");

                entity.Property(e => e.Item3Desc)
                    .HasColumnName("item3_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item4).HasColumnName("item4");

                entity.Property(e => e.Item4Desc)
                    .HasColumnName("item4_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item5).HasColumnName("item5");

                entity.Property(e => e.Item5Desc)
                    .HasColumnName("item5_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item6).HasColumnName("item6");

                entity.Property(e => e.Item6Desc)
                    .HasColumnName("item6_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item7).HasColumnName("item7");

                entity.Property(e => e.Item7Desc)
                    .HasColumnName("item7_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item8).HasColumnName("item8");

                entity.Property(e => e.Item8Desc)
                    .HasColumnName("item8_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Item9).HasColumnName("item9");

                entity.Property(e => e.Item9Desc)
                    .HasColumnName("item9_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value1)
                    .HasColumnName("value1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<RmxComponentMaster>(entity =>
            {
                entity.ToTable("rmx_component_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Defaultvalue)
                    .HasColumnName("defaultvalue")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Item0).HasColumnName("item0");

                entity.Property(e => e.Item1).HasColumnName("item1");

                entity.Property(e => e.Item2).HasColumnName("item2");

                entity.Property(e => e.Item3).HasColumnName("item3");

                entity.Property(e => e.Item4).HasColumnName("item4");

                entity.Property(e => e.Item5).HasColumnName("item5");

                entity.Property(e => e.Item6).HasColumnName("item6");

                entity.Property(e => e.Item7).HasColumnName("item7");

                entity.Property(e => e.Item8).HasColumnName("item8");

                entity.Property(e => e.Item9).HasColumnName("item9");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value1)
                    .HasColumnName("value1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<RmxDist>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Transportationtypeid, e.Owner, e.Batchingplantid });

                entity.ToTable("rmx_dist");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Transportationtypeid).HasColumnName("transportationtypeid");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplantid)
                    .HasColumnName("batchingplantid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Availability)
                    .HasColumnName("availability")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgDrumCapacity)
                    .HasColumnName("avg_drum_capacity")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgFillingDegree)
                    .HasColumnName("avg_filling_degree")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Batchingplantdesc)
                    .HasColumnName("batchingplantdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplanttype)
                    .HasColumnName("batchingplanttype")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.CycleTime)
                    .HasColumnName("cycle_time")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DistanceMtp1)
                    .HasColumnName("distance_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DistanceMtp2)
                    .HasColumnName("distance_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DistanceMtp3)
                    .HasColumnName("distance_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Distcostcenterid)
                    .HasColumnName("distcostcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.LoadSize)
                    .HasColumnName("load_size")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Other0)
                    .HasColumnName("other0")
                    .IsUnicode(false);

                entity.Property(e => e.Other1)
                    .HasColumnName("other1")
                    .IsUnicode(false);

                entity.Property(e => e.Other2)
                    .HasColumnName("other2")
                    .IsUnicode(false);

                entity.Property(e => e.Other3)
                    .HasColumnName("other3")
                    .IsUnicode(false);

                entity.Property(e => e.Other4)
                    .HasColumnName("other4")
                    .IsUnicode(false);

                entity.Property(e => e.Other5)
                    .HasColumnName("other5")
                    .IsUnicode(false);

                entity.Property(e => e.Other6)
                    .HasColumnName("other6")
                    .IsUnicode(false);

                entity.Property(e => e.Other7)
                    .HasColumnName("other7")
                    .IsUnicode(false);

                entity.Property(e => e.Other8)
                    .HasColumnName("other8")
                    .IsUnicode(false);

                entity.Property(e => e.Other9)
                    .HasColumnName("other9")
                    .IsUnicode(false);

                entity.Property(e => e.Portion)
                    .HasColumnName("portion")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Prodcostcenterid)
                    .HasColumnName("prodcostcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RateMtp1)
                    .HasColumnName("rate_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RateMtp2)
                    .HasColumnName("rate_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RateMtp3)
                    .HasColumnName("rate_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Regiondesc)
                    .HasColumnName("regiondesc")
                    .IsUnicode(false);

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.TransportationTypeCostElementId)
                    .HasColumnName("transportation_type_cost_element_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Transportationtypedesc)
                    .HasColumnName("transportationtypedesc")
                    .IsUnicode(false);

                entity.Property(e => e.TripsPerDay)
                    .HasColumnName("trips_per_day")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckApr1)
                    .HasColumnName("truck_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckApr2)
                    .HasColumnName("truck_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckApr3)
                    .HasColumnName("truck_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckAug1)
                    .HasColumnName("truck_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckAug2)
                    .HasColumnName("truck_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckAug3)
                    .HasColumnName("truck_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckDec1)
                    .HasColumnName("truck_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckDec2)
                    .HasColumnName("truck_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckDec3)
                    .HasColumnName("truck_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckFeb1)
                    .HasColumnName("truck_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckFeb2)
                    .HasColumnName("truck_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckFeb3)
                    .HasColumnName("truck_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckJan1)
                    .HasColumnName("truck_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckJan2)
                    .HasColumnName("truck_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckJan3)
                    .HasColumnName("truck_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckJul1)
                    .HasColumnName("truck_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckJul2)
                    .HasColumnName("truck_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckJul3)
                    .HasColumnName("truck_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckJun1)
                    .HasColumnName("truck_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckJun2)
                    .HasColumnName("truck_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckJun3)
                    .HasColumnName("truck_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckMar1)
                    .HasColumnName("truck_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckMar2)
                    .HasColumnName("truck_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckMar3)
                    .HasColumnName("truck_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckMay1)
                    .HasColumnName("truck_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckMay2)
                    .HasColumnName("truck_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckMay3)
                    .HasColumnName("truck_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckMtp1)
                    .HasColumnName("truck_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckMtp2)
                    .HasColumnName("truck_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckMtp3)
                    .HasColumnName("truck_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckNov1)
                    .HasColumnName("truck_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckNov2)
                    .HasColumnName("truck_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckNov3)
                    .HasColumnName("truck_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckOct1)
                    .HasColumnName("truck_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckOct2)
                    .HasColumnName("truck_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckOct3)
                    .HasColumnName("truck_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckSep1)
                    .HasColumnName("truck_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckSep2)
                    .HasColumnName("truck_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TruckSep3)
                    .HasColumnName("truck_sep_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilApr1)
                    .HasColumnName("util_apr_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilApr2)
                    .HasColumnName("util_apr_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilApr3)
                    .HasColumnName("util_apr_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilAug1)
                    .HasColumnName("util_aug_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilAug2)
                    .HasColumnName("util_aug_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilAug3)
                    .HasColumnName("util_aug_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilDec1)
                    .HasColumnName("util_dec_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilDec2)
                    .HasColumnName("util_dec_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilDec3)
                    .HasColumnName("util_dec_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilFeb1)
                    .HasColumnName("util_feb_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilFeb2)
                    .HasColumnName("util_feb_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilFeb3)
                    .HasColumnName("util_feb_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilJan1)
                    .HasColumnName("util_jan_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilJan2)
                    .HasColumnName("util_jan_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilJan3)
                    .HasColumnName("util_jan_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilJul1)
                    .HasColumnName("util_jul_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilJul2)
                    .HasColumnName("util_jul_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilJul3)
                    .HasColumnName("util_jul_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilJun1)
                    .HasColumnName("util_jun_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilJun2)
                    .HasColumnName("util_jun_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilJun3)
                    .HasColumnName("util_jun_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilMar1)
                    .HasColumnName("util_mar_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilMar2)
                    .HasColumnName("util_mar_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilMar3)
                    .HasColumnName("util_mar_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilMay1)
                    .HasColumnName("util_may_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilMay2)
                    .HasColumnName("util_may_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilMay3)
                    .HasColumnName("util_may_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilMtp1)
                    .HasColumnName("util_mtp_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilMtp2)
                    .HasColumnName("util_mtp_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilMtp3)
                    .HasColumnName("util_mtp_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilNov1)
                    .HasColumnName("util_nov_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilNov2)
                    .HasColumnName("util_nov_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilNov3)
                    .HasColumnName("util_nov_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilOct1)
                    .HasColumnName("util_oct_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilOct2)
                    .HasColumnName("util_oct_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilOct3)
                    .HasColumnName("util_oct_3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilSep1)
                    .HasColumnName("util_sep_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilSep2)
                    .HasColumnName("util_sep_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UtilSep3)
                    .HasColumnName("util_sep_3")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<RmxRawMaterial>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Rmxcomponentid, e.Batchingplantid });

                entity.ToTable("rmx_raw_material");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Rmxcomponentid).HasColumnName("rmxcomponentid");

                entity.Property(e => e.Batchingplantid)
                    .HasColumnName("batchingplantid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplantdesc)
                    .HasColumnName("batchingplantdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplanttype)
                    .HasColumnName("batchingplanttype")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice1)
                    .HasColumnName("cost_price_1")
                    .HasColumnType("money");

                entity.Property(e => e.CostPrice2)
                    .HasColumnName("cost_price_2")
                    .HasColumnType("money");

                entity.Property(e => e.CostPrice3)
                    .HasColumnName("cost_price_3")
                    .HasColumnType("money");

                entity.Property(e => e.CostTransport1)
                    .HasColumnName("cost_transport_1")
                    .HasColumnType("money");

                entity.Property(e => e.CostTransport2)
                    .HasColumnName("cost_transport_2")
                    .HasColumnType("money");

                entity.Property(e => e.CostTransport3)
                    .HasColumnName("cost_transport_3")
                    .HasColumnType("money");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Distcostcenterid)
                    .HasColumnName("distcostcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Prodcostcenterid)
                    .HasColumnName("prodcostcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regiondesc)
                    .HasColumnName("regiondesc")
                    .IsUnicode(false);

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Rmxcomponentdescription)
                    .HasColumnName("rmxcomponentdescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VolUsage1)
                    .HasColumnName("vol_usage_1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolUsage2)
                    .HasColumnName("vol_usage_2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VolUsage3)
                    .HasColumnName("vol_usage_3")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<RmxSales>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Transportationtypeid, e.Salestype, e.Batchingplantid });

                entity.ToTable("rmx_sales");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Transportationtypeid).HasColumnName("transportationtypeid");

                entity.Property(e => e.Salestype)
                    .HasColumnName("salestype")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplantid)
                    .HasColumnName("batchingplantid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AspApr1)
                    .HasColumnName("asp_apr_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspApr2)
                    .HasColumnName("asp_apr_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspApr3)
                    .HasColumnName("asp_apr_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspAug1)
                    .HasColumnName("asp_aug_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspAug2)
                    .HasColumnName("asp_aug_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspAug3)
                    .HasColumnName("asp_aug_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspDec1)
                    .HasColumnName("asp_dec_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspDec2)
                    .HasColumnName("asp_dec_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspDec3)
                    .HasColumnName("asp_dec_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspFeb1)
                    .HasColumnName("asp_feb_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspFeb2)
                    .HasColumnName("asp_feb_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspFeb3)
                    .HasColumnName("asp_feb_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJan1)
                    .HasColumnName("asp_jan_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJan2)
                    .HasColumnName("asp_jan_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJan3)
                    .HasColumnName("asp_jan_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJul1)
                    .HasColumnName("asp_jul_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJul2)
                    .HasColumnName("asp_jul_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJul3)
                    .HasColumnName("asp_jul_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJun1)
                    .HasColumnName("asp_jun_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJun2)
                    .HasColumnName("asp_jun_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspJun3)
                    .HasColumnName("asp_jun_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMar1)
                    .HasColumnName("asp_mar_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMar2)
                    .HasColumnName("asp_mar_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMar3)
                    .HasColumnName("asp_mar_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMay1)
                    .HasColumnName("asp_may_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMay2)
                    .HasColumnName("asp_may_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMay3)
                    .HasColumnName("asp_may_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMtp1)
                    .HasColumnName("asp_mtp_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMtp2)
                    .HasColumnName("asp_mtp_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspMtp3)
                    .HasColumnName("asp_mtp_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspNov1)
                    .HasColumnName("asp_nov_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspNov2)
                    .HasColumnName("asp_nov_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspNov3)
                    .HasColumnName("asp_nov_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspOct1)
                    .HasColumnName("asp_oct_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspOct2)
                    .HasColumnName("asp_oct_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspOct3)
                    .HasColumnName("asp_oct_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspSep1)
                    .HasColumnName("asp_sep_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspSep2)
                    .HasColumnName("asp_sep_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AspSep3)
                    .HasColumnName("asp_sep_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Batchingplantdesc)
                    .HasColumnName("batchingplantdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Batchingplanttype)
                    .HasColumnName("batchingplanttype")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cementregiondesc)
                    .HasColumnName("cementregiondesc")
                    .IsUnicode(false);

                entity.Property(e => e.Cementregionid)
                    .HasColumnName("cementregionid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Distcostcenterid)
                    .HasColumnName("distcostcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.NetApr1)
                    .HasColumnName("net_apr_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetApr2)
                    .HasColumnName("net_apr_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetApr3)
                    .HasColumnName("net_apr_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAug1)
                    .HasColumnName("net_aug_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAug2)
                    .HasColumnName("net_aug_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAug3)
                    .HasColumnName("net_aug_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetDec1)
                    .HasColumnName("net_dec_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetDec2)
                    .HasColumnName("net_dec_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetDec3)
                    .HasColumnName("net_dec_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFeb1)
                    .HasColumnName("net_feb_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFeb2)
                    .HasColumnName("net_feb_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFeb3)
                    .HasColumnName("net_feb_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJan1)
                    .HasColumnName("net_jan_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJan2)
                    .HasColumnName("net_jan_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJan3)
                    .HasColumnName("net_jan_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJul1)
                    .HasColumnName("net_jul_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJul2)
                    .HasColumnName("net_jul_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJul3)
                    .HasColumnName("net_jul_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJun1)
                    .HasColumnName("net_jun_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJun2)
                    .HasColumnName("net_jun_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetJun3)
                    .HasColumnName("net_jun_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMar1)
                    .HasColumnName("net_mar_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMar2)
                    .HasColumnName("net_mar_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMar3)
                    .HasColumnName("net_mar_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMay1)
                    .HasColumnName("net_may_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMay2)
                    .HasColumnName("net_may_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMay3)
                    .HasColumnName("net_may_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMtp1)
                    .HasColumnName("net_mtp_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMtp2)
                    .HasColumnName("net_mtp_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetMtp3)
                    .HasColumnName("net_mtp_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetNov1)
                    .HasColumnName("net_nov_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetNov2)
                    .HasColumnName("net_nov_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetNov3)
                    .HasColumnName("net_nov_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetOct1)
                    .HasColumnName("net_oct_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetOct2)
                    .HasColumnName("net_oct_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetOct3)
                    .HasColumnName("net_oct_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetSep1)
                    .HasColumnName("net_sep_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetSep2)
                    .HasColumnName("net_sep_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetSep3)
                    .HasColumnName("net_sep_3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Prodcostcenterid)
                    .HasColumnName("prodcostcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regiondesc)
                    .HasColumnName("regiondesc")
                    .IsUnicode(false);

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Transportationtypedesc)
                    .HasColumnName("transportationtypedesc")
                    .IsUnicode(false);

                entity.Property(e => e.VehicleType)
                    .HasColumnName("vehicle_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolApr1)
                    .HasColumnName("vol_apr_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolApr2)
                    .HasColumnName("vol_apr_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolApr3)
                    .HasColumnName("vol_apr_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolAug1)
                    .HasColumnName("vol_aug_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolAug2)
                    .HasColumnName("vol_aug_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolAug3)
                    .HasColumnName("vol_aug_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolDec1)
                    .HasColumnName("vol_dec_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolDec2)
                    .HasColumnName("vol_dec_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolDec3)
                    .HasColumnName("vol_dec_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolFeb1)
                    .HasColumnName("vol_feb_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolFeb2)
                    .HasColumnName("vol_feb_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolFeb3)
                    .HasColumnName("vol_feb_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJan1)
                    .HasColumnName("vol_jan_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJan2)
                    .HasColumnName("vol_jan_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJan3)
                    .HasColumnName("vol_jan_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJul1)
                    .HasColumnName("vol_jul_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJul2)
                    .HasColumnName("vol_jul_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJul3)
                    .HasColumnName("vol_jul_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJun1)
                    .HasColumnName("vol_jun_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJun2)
                    .HasColumnName("vol_jun_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolJun3)
                    .HasColumnName("vol_jun_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMar1)
                    .HasColumnName("vol_mar_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMar2)
                    .HasColumnName("vol_mar_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMar3)
                    .HasColumnName("vol_mar_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMay1)
                    .HasColumnName("vol_may_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMay2)
                    .HasColumnName("vol_may_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMay3)
                    .HasColumnName("vol_may_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMtp1)
                    .HasColumnName("vol_mtp_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMtp2)
                    .HasColumnName("vol_mtp_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolMtp3)
                    .HasColumnName("vol_mtp_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolNov1)
                    .HasColumnName("vol_nov_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolNov2)
                    .HasColumnName("vol_nov_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolNov3)
                    .HasColumnName("vol_nov_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolOct1)
                    .HasColumnName("vol_oct_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolOct2)
                    .HasColumnName("vol_oct_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolOct3)
                    .HasColumnName("vol_oct_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolSep1)
                    .HasColumnName("vol_sep_1")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolSep2)
                    .HasColumnName("vol_sep_2")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VolSep3)
                    .HasColumnName("vol_sep_3")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SpcAllocation>(entity =>
            {
                entity.HasKey(e => new { e.Budgetjobid, e.Costcenterid });

                entity.ToTable("spc_allocation");

                entity.Property(e => e.Budgetjobid).HasColumnName("budgetjobid");

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Agg1)
                    .HasColumnName("agg1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Agg2)
                    .HasColumnName("agg2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Agg3)
                    .HasColumnName("agg3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cop1)
                    .HasColumnName("cop1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cop2)
                    .HasColumnName("cop2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cop3)
                    .HasColumnName("cop3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Costcenterdesc)
                    .HasColumnName("costcenterdesc")
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Functionid)
                    .HasColumnName("functionid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Rmx1)
                    .HasColumnName("rmx1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rmx2)
                    .HasColumnName("rmx2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rmx3)
                    .HasColumnName("rmx3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Subsegmentid)
                    .HasColumnName("subsegmentid")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransportationTypeMaster>(entity =>
            {
                entity.ToTable("transportation_type_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Costelementid)
                    .HasColumnName("costelementid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Subcont).HasColumnName("subcont");

                entity.Property(e => e.VehicleType)
                    .HasColumnName("vehicle_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserReserved>(entity =>
            {
                entity.ToTable("user_reserved");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Effective)
                    .HasColumnName("effective")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Expired)
                    .HasColumnName("expired")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasColumnName("rolename")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsersDetail>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Costcenterid });

                entity.ToTable("users_detail");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Costcenterid)
                    .HasColumnName("costcenterid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("modifiedby")
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Readonly)
                    .HasColumnName("readonly")
                    .HasDefaultValueSql("((0))");
            });
        }
    }
}
