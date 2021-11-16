using LeasingRazor.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Persistence.Context
{
    public class LeasingRazorDbContext:DbContext
    {
        public LeasingRazorDbContext(DbContextOptions<LeasingRazorDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeasingRazorDbContext).Assembly);

        }
        public DbSet<MasterBidangUsaha> MasterBidangUsaha { get; set; }
        public DbSet<MasterBidangPekerjaan> MasterBidangPekerjaan { get; set; }
        public DbSet<MasterBarang> MasterBarang { get; set; }
        public DbSet<DataKonsumen> DataKonsumen { get; set; }
        public DbSet<DataKontrakAngsuran> DataKontrakAngsuran { get; set; }
        public DbSet<DataKontrakAsuransi> DataKontrakAsuransi { get; set; }
        public DbSet<DataKontrakKredit> DataKontrakKredit { get; set; }
        public DbSet<DataKontrakKreditAngsuranDemo> DataKontrakKreditAngsuranDemo { get; set; }

        public DbSet<DataKontrakSurvei> DataKontrakSurvei { get; set; }




    }
}
