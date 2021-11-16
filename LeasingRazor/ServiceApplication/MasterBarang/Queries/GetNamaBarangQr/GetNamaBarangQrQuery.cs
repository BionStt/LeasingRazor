using LeasingRazor.Dto.MasterBarang;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.MasterBarang.Queries.GetNamaBarangQr
{
    public class GetNamaBarangQrQuery:IRequest<IReadOnlyCollection<GetNamaBarangQrResponse>>
    {
        
    }
}
