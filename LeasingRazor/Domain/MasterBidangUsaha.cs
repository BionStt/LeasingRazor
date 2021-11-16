using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Domain
{
    public class MasterBidangUsaha
    {
        public static MasterBidangUsaha CreateMasterBidangUsaha(string masterBidangUsahaKeterangan)
        {
            return new MasterBidangUsaha(masterBidangUsahaKeterangan);
        }
        private MasterBidangUsaha( string masterBidangUsahaKeterangan)
        {
            MasterBidangUsahaId=Guid.NewGuid();
            MasterBidangUsahaKeterangan=masterBidangUsahaKeterangan;
        }

        public int NoUrutId { get; set; }
        public Guid MasterBidangUsahaId { get; set; }
        public string MasterBidangUsahaKeterangan { get; set; }
    }
}
