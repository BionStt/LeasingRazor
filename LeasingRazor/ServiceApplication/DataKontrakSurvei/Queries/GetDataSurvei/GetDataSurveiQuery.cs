using LeasingRazor.Dto.DataKontrakSurvei;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakSurvei.Queries.GetDataSurvei
{
    public class GetDataSurveiQuery:IRequest<IReadOnlyCollection<GetDataSurveiResponse>>
    {
        
    }
}
