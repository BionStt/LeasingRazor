using LeasingRazor.Dto.DataKontrakKreditAngsuranDemo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakAngsuran.Queries.GetDataKontrakAngsuranByNoID
{
    public class GetDataKontrakAngsuranByNoIDQuery:IRequest<IReadOnlyCollection<GetDataKontrakAngsuranByNoIDResponse>>
    {
        public string dataKontrakId { get; set; }
    }
}
