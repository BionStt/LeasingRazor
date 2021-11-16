using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakAsuransi.Commands.CreateDataKontrakAsuransi
{
    public class CreateDataKontrakAsuransiCommand:IRequest
    {
        public int NoUrutDataAsuransi { get; set; }
        public int NoRegistrasiKontrakKredit { get; set; }
        public string KodeAsuransi { get; set; }
        public int? JenisAsuransi { get; set; }
        public DateTime? TanggalMulaiAsuransi { get; set; }
        public DateTime? TanggalAkhirAsuransi { get; set; }
        public int? LamaAsuransi { get; set; }
        public decimal? NilaiPertanggungan { get; set; }
        public decimal? BiayaAsuransi { get; set; }
    }
}
