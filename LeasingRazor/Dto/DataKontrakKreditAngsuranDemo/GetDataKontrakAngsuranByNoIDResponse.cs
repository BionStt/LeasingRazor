using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Dto.DataKontrakKreditAngsuranDemo
{
    public class GetDataKontrakAngsuranByNoIDResponse
    {
        public int NoUrutDataKontrakKredit1 { get; set; }
        public int? AngsuranKeA { get; set; }

        public DateTime? TanggalAngsuran1 { get; set; }
        public double? AngsuranPerBulan { get; set; }
        public double? Pokok1 { get; set; }
        public double? Bunga1 { get; set; }
        public double? SisaPokok1 { get; set; }
        public double? SisaBunga1 { get; set; }
    }
}
