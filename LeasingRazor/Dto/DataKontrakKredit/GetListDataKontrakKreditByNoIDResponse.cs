using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Dto.DataKontrakKredit
{
    public class GetListDataKontrakKreditByNoIDResponse
    {
        public int NoUrutDataKontrakKredit1 { get; set; }
        public string NamaKonsumen1 { get; set; }
        public string NamaPenjamin1 { get; set; }
        public string AlamatRumah { get; set; }
        public string NoTeleponRumah { get; set; }
        public string NoTeleponKantor { get; set; }
        public string NoTeleponUsaha { get; set; }
        public string NoHP1 { get; set; }
        public string NoHP2 { get; set; }
        public double? NilaiKontrak1 { get; set; }
        public double? NilaiBunga1 { get; set; }
        public int? Tenor1 { get; set; }
        public double? Angsuran1 { get; set; }
        public double? pinjamanPokok { get; set; }

    }
}
