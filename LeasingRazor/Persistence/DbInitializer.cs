using LeasingRazor.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Persistence
{
    public class DbInitializer
    {
        public static async Task Initialize(LeasingRazorDbContext context)
        {
            var initializer = new DbInitializer();
            await initializer.SeedEverything(context);
        }

        public async Task SeedEverything(LeasingRazorDbContext context)
        {

            context.Database.EnsureCreated();

            //if (context.CustomerDB.Any())
            //{
            //    return;// Db has been seeded
            //}
            await SeedMasterBidangPekerjaan(context);
            await SeedMasterBidangUsaha(context);
   
            await SeedMasterBarang(context);
         
        }

        private async Task SeedMasterBarang(LeasingRazorDbContext context)
        {
            if (context.MasterBarang.Any())
            {
                return;
            }
            var masterBarang = new[]
            {
              //  Domain.MasterBarang.Create("BEAT STREET CBS ACC","MH1","","HONDA","110",decimal.Parse("13781000"),decimal.Parse("2875000"),"2019","D1I2N2A2A/T"),
                Domain.MasterBarang.CreateMasterBarang(decimal.Parse("2875000"),"110",decimal.Parse("13781000"),"HONDA","BEAT STREET CBS ACC","MH1",String.Empty,2019,"MATIC","D1I2N2A2A/T")
            };
            context.MasterBarang.AddRange(masterBarang);
            // context.MasterBarang.Add(masterBarang);
            await context.SaveChangesAsync();
        }
        private async Task SeedMasterBidangPekerjaan(LeasingRazorDbContext context)
        {
            if (context.MasterBidangPekerjaan.Any())
            {
                return;
            }
            var MasterBidangPekerjaanDB = new[]
            {
                 Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Tidak Bekerja"),
                 Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Pensiunan PNS/BUMN"),
                  Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Tentara Nasional Indonesia (TNI) dan Kepolisian Negara Republik Indonesia (POLRI)"),
                  Domain. MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Pejabat Pembuat Peraturan Perundang-undangan dan Pejabat Tinggi Pemerintah"),
                 Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Manager"),
                 Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Profesional"),
                  Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Pegawai Negeri Sipil"),
                   Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Pegawai BUMN"),
                    Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Teknisi dan Asisten Profesional"),
                    Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Tenaga Tata Usaha"),
                    Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Tenaga Usaha Jasa dan Tenaga Penjualan"),
                     Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Pekerja Terampil, Pertanian, Kehutanan, dan Perikanan"),
                     Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Pekerja Pengolahan, Kerajinan,dan YBDI"),
                      Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Operator dan Perakit Mesin"),
                        Domain.MasterBidangPekerjaan.CreateMasterBidangPekerjaan("Pekerja Kasar")

            };
            context.MasterBidangPekerjaan.AddRange(MasterBidangPekerjaanDB);
            await context.SaveChangesAsync();

        }
        private async Task SeedMasterBidangUsaha(LeasingRazorDbContext context)
        {
            if (context.MasterBidangUsaha.Any())
            {
                return;
            }
            var MasterBidangUsahaDB = new[]
            {
                 Domain.MasterBidangUsaha.CreateMasterBidangUsaha("TIDAK MEMPUNYAI USAHA"),
                 Domain.MasterBidangUsaha.CreateMasterBidangUsaha("PERTANIAN, KEHUTANAN DAN PERIKANAN"),
                  Domain.MasterBidangUsaha.CreateMasterBidangUsaha("PERTAMBANGAN DAN PENGGALIAN "),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("INDUSTRI PENGOLAHAN"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("PENGADAAN LISTRIK, GAS, UAP/AIR PANAS DAN UDARA DINGIN"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("PENGELOLAAN AIR, PENGELOLAAN AIR LIMBAH, PENGELOLAAN DAN DAUR ULANG SAMPAH, DAN AKTIVITAS REMEDIASI"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("KONSTRUKSI"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("PERDAGANGAN BESAR DAN ECERAN; REPARASI DAN PERAWATAN MOBIL DAN SEPEDA MOTOR"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("PENGANGKUTAN DAN PERGUDANGAN"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("PENYEDIAAN AKOMODASI DAN PENYEDIAAN MAKAN MINUM"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("INFORMASI DAN KOMUNIKASI"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("AKTIVITAS KEUANGAN DAN ASURANSI"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("REAL ESTAT"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("AKTIVITAS PROFESIONAL, ILMIAH DAN TEKNIS"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("AKTIVITAS PENYEWAAN DAN SEWA GUNA USAHA TANPA HAK OPSI, KETENAGAKERJAAN, AGEN PERJALANAN DAN PENUNJANG USAHA LAINNYA"),
                       Domain.MasterBidangUsaha.CreateMasterBidangUsaha("ADMINISTRASI PEMERINTAHAN, PERTAHANAN DAN JAMINAN SOSIAL WAJIB"),
                      Domain.MasterBidangUsaha.CreateMasterBidangUsaha("PENDIDIKAN"),
                      Domain.MasterBidangUsaha.CreateMasterBidangUsaha("AKTIVITAS KESEHATAN MANUSIA DAN AKTIVITAS SOSIAL"),
                            Domain.MasterBidangUsaha.CreateMasterBidangUsaha("KESENIAN, HIBURAN DAN REKREASI"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("AKTIVITAS BADAN INTERNASIONAL DAN BADAN EKSTRA INTERNASIONAL LAINNYA"),
                Domain.MasterBidangUsaha.CreateMasterBidangUsaha("AKTIVITAS JASA LAINNYA")

            };
            context.MasterBidangUsaha.AddRange(MasterBidangUsahaDB);
            await context.SaveChangesAsync();

        }


    }
}
