using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Dto.DataKontrakKredit
{
    public class CreateDataKontrakKreditRequest
    {
        public int NoUrutDataKontrakKredit { get; set; }
        //[Display(Name = "No Register Kontrak Kredit")]
        //public string NoRegisterKontrakKredit { get; set; }
        public int NoRegisterSurvei { get; set; }
        [Display(Name = "Tanggal kontrak")]//, Prompt = "Masukkan nama konsumen")]
        public DateTime? TanggalKontrak { get; set; }
        [Display(Name = "Pola angsuran")]
        public string PolaAngsuran { get; set; }
        [Display(Name = "Cara Pembayaran")]
        public string CaraBayar { get; set; }

  
        [Display(Name = "Harga Barang")]
        public double? HargaBarang { get; set; }
        [Display(Name = "Uang Muka")]
        public double? UangMuka { get; set; }
        [Display(Name = "Asuransi")]
        public double? Asuransi { get; set; }
        [Display(Name = "Administrasi")]
        public double? Administrasi { get; set; }
        [Display(Name = "Bunga Efektif")]
        public decimal? BungaEff { get; set; }
        [Display(Name = "Bunga Flat")]
        public decimal? BungaFlat { get; set; }
        [Display(Name = "Tenor")]
        public int? LamaKredit { get; set; }
        [Display(Name = "Tanggal Angsuran jatuh tempo")]
        public string TanggalAngsuranBulanan { get; set; }
        [Display(Name = "Angsuran diMuka ?")]
        public string AngsuranDimuka { get; set; }
        [Display(Name = "Pinjaman Pokok")]
        public double? PinjamanPokok { get; set; }
        [Display(Name = "Nilai Bunga")]
        public double? NilaiBunga { get; set; }
        [Display(Name = "Nilai Kontrak")]
        public double? NilaiKontrak { get; set; }
        [Display(Name = "Angsuran bulanan")]
        public double? AngsuranBulanan { get; set; }
        [Display(Name = "Biaya administrasi angsuran")]
        public double? BiayaAdministrasiAngsuran { get; set; }
        [Display(Name = "Penagih")]
        public string PenagihId { get; set; }
    }
}
