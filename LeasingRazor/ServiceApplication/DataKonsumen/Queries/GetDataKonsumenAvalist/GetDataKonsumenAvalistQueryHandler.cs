using LeasingRazor.Dto.DataKonsumen;
using LeasingRazor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKonsumen.Queries.GetDataKonsumenAvalist
{
    public class GetDataKonsumenAvalistQueryHandler : IRequestHandler<GetDataKonsumenAvalistQuery, IReadOnlyCollection<GetDataKonsumenAvalistResponse>>
    {
        private readonly LeasingRazorDbContext _context;

        public GetDataKonsumenAvalistQueryHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetDataKonsumenAvalistResponse>> Handle(GetDataKonsumenAvalistQuery request, CancellationToken cancellationToken)
        {
          
            var returnQuery = await (from a in _context.DataKonsumen
                            where _context.DataKontrakSurvei.All(x => x.DataKonsumenAvalistId != a.DataKonsumenId)
                            select new GetDataKonsumenAvalistResponse
                            { 
                                NoCustomerAvalist = a.NoUrutId,
                                NamaKonsumen = string.Format("{0} - {1} - {2}", a.NamaKonsumen, a.NamaPenjamin, a.NoHandphone) 
                            }

              ).OrderByDescending(x => x.NoCustomerAvalist).ToListAsync(cancellationToken);
            return returnQuery;
        }
    }
}
