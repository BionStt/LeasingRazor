using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Domain
{
    public class MasterBidangPekerjaan
    {
        public static MasterBidangPekerjaan CreateMasterBidangPekerjaan(string masterBidangPekerjaanKeterangan)
        {
            return new MasterBidangPekerjaan(masterBidangPekerjaanKeterangan);
        }
        private MasterBidangPekerjaan(string masterBidangPekerjaanKeterangan)
        {
            MasterBidangPekerjaanId=Guid.NewGuid();
            MasterBidangPekerjaanKeterangan=masterBidangPekerjaanKeterangan;
        }

        public int NoUrutId { get; set; }
        public Guid MasterBidangPekerjaanId { get; set; }
        public string MasterBidangPekerjaanKeterangan { get; set; }

    }
}
