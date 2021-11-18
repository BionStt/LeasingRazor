using LeasingRazor.Dto.DataKontrakKredit;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakKredit.Queries.GetListDataKontrakKreditByNoID
{
    public class GetListDataKontrakKreditByNoIDQuery:IRequest<IReadOnlyCollection<GetListDataKontrakKreditByNoIDResponse>>
    {
        public string dataKontrakId { get; set; }
    }
}
