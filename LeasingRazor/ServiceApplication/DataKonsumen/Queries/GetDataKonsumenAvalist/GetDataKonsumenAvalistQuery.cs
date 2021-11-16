using LeasingRazor.Dto.DataKonsumen;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKonsumen.Queries.GetDataKonsumenAvalist
{
    public class GetDataKonsumenAvalistQuery:IRequest<IReadOnlyCollection<GetDataKonsumenAvalistResponse>>
    {
        
    }
}
