using LeasingRazor.Dto.MasterBidangPekerjaan;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.MasterBidangPekerjaan.Queries.GetNamaBidangPekerjaan
{
    public class GetNamaBidangPekerjaanQuery:IRequest<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>>
    {
        
    }
}
