using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Domain
{
    public class MasterBarang
    {
        public static MasterBarang CreateMasterBarang(decimal? bBN, string cc, decimal? harga, string merek, string namaBarang, string nomorRangka, string nomorMesin, int? tahun, string tipe, string typeKendaraan)
        {
            return new MasterBarang(  bBN,  cc,   harga,  merek,  namaBarang,  nomorRangka,  nomorMesin,   tahun,  tipe,  typeKendaraan);
        }
        private MasterBarang(decimal? bBN, string cc, decimal? harga, string merek, string namaBarang, string nomorRangka, string nomorMesin, int? tahun, string tipe, string typeKendaraan)
        {
            MasterBarangId=Guid.NewGuid();
            BBN=bBN;
            Cc=cc;
            Harga=harga;
            Merek=merek;
            NamaBarang=namaBarang;
            NomorRangka=nomorRangka;
            NomorMesin=nomorMesin;
            Tahun=tahun;
            Tipe=tipe;
            TypeKendaraan=typeKendaraan;
        }

        public Guid MasterBarangId { get; set; }
      
      
        public decimal? BBN { get; set; }
        public string Cc { get; set; }
        public decimal? Harga { get; set; }
        public string Merek { get; set; }
        public string NamaBarang { get; set; }
        public string NomorRangka { get; set; }
        public string NomorMesin { get; set; }
        public int? Tahun { get; set; }
        public string Tipe { get; set; }
        public string TypeKendaraan { get; set; }

        public string Aktif { get; set; }
        public int NoUrutId { get; set; }
    }
}
