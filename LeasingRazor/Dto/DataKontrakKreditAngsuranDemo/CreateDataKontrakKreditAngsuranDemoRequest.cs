using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LeasingRazor.Dto.DataKontrakKreditAngsuranDemo
{
    public class CreateDataKontrakKreditAngsuranDemoRequest
    {
        public int NoUrutDataKontrakKredit { get; set; }
        [Display(Name = "Anguran Dimuka")]//, Prompt = "Masukkan nama konsumen")]
        public string AngsuranDimuka { get; set; }
        [Display(Name = "Bunga efektif")]
        public decimal? BungaEff { get; set; }
        [Display(Name = "Bunga Flat")]
        public decimal? BungaFlat { get; set; }
        [Display(Name = "Harga Barang")]
        public decimal? HargaBarang { get; set; }
        [Display(Name = "Uang Muka")]
        public decimal? UangMuka { get; set; }
        [Display(Name = "Asuransi")]
        public decimal? Asuransi { get; set; }
        [Display(Name = "Administrasi")]
        public decimal? Administrasi { get; set; }
        [Display(Name = "Angsuran bulan")]
        public decimal? AngsuranBulanan { get; set; }
        [Display(Name = "Nilai bunga")]
        public decimal? NilaiBunga { get; set; }
        [Display(Name = "Tenor")]
        public int? LamaKredit { get; set; }
        [Display(Name = "Angsuran")]
        public Double? Angsuran { get; set; }
        [Display(Name = "Tanggal Jatuh Tempo Bulanan")]
        public int TanggalJatuhTempoBulanan { get; set; }
        [Display(Name = "Pola Angsuran")]
        public string PolaAngsuran { get; set; }
        [Display(Name = "Nilai Kontrak")]
        public decimal? NilaiKontrak { get; set; }
    }
}
