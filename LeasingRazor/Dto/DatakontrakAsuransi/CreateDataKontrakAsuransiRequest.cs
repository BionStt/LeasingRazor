using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Dto.DatakontrakAsuransi
{
    public class CreateDataKontrakAsuransiRequest
    {
        public int NoUrutDataAsuransi { get; set; }
        public int NoRegistrasiKontrakKredit { get; set; }
        [Display(Name = "Kode Asuransi")]
        public string KodeAsuransi { get; set; }
        [Display(Name = "Jenis asuransi")]
        public int? JenisAsuransi { get; set; }
        [Display(Name = "Periode Awal asuransi")]
        public DateTime? TanggalMulaiAsuransi { get; set; }
        [Display(Name = "Periode akhir asuransi")]
        public DateTime? TanggalAkhirAsuransi { get; set; }
        [Display(Name = "Lama asuransi")]
        public int? LamaAsuransi { get; set; }
        [Display(Name = "Nilai pertanggungan")]
        public decimal? NilaiPertanggungan { get; set; }
        [Display(Name = "Biaya asuransi")]
        public decimal? BiayaAsuransi { get; set; }
    }
}
