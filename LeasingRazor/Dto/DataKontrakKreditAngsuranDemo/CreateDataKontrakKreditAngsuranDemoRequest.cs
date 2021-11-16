using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Dto.DataKontrakKreditAngsuranDemo
{
    public class CreateDataKontrakKreditAngsuranDemoRequest
    {
        public int NoUrutDataKontrakKredit { get; set; }
        public string AngsuranDimuka { get; set; }
        public decimal? BungaEff { get; set; }
        public decimal? BungaFlat { get; set; }
        public decimal? HargaBarang { get; set; }
        public decimal? UangMuka { get; set; }
        public decimal? Asuransi { get; set; }
        public decimal? Administrasi { get; set; }
        public decimal? AngsuranBulanan { get; set; }
        public decimal? NilaiBunga { get; set; }
        public int? LamaKredit { get; set; }
        public Double? Angsuran { get; set; }
        public int TanggalJatuhTempoBulanan { get; set; }
        public string PolaAngsuran { get; set; }
        public decimal? NilaiKontrak { get; set; }
    }
}
