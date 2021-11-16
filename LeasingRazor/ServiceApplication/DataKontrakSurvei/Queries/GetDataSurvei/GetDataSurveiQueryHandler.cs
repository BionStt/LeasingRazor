using LeasingRazor.Dto.DataKontrakSurvei;
using LeasingRazor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakSurvei.Queries.GetDataSurvei
{
    public class GetDataSurveiQueryHandler : IRequestHandler<GetDataSurveiQuery, IReadOnlyCollection<GetDataSurveiResponse>>
    {
        private readonly LeasingRazorDbContext _context;

        public GetDataSurveiQueryHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetDataSurveiResponse>> Handle(GetDataSurveiQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.DataKontrakSurvei
                            join b in _context.DataKonsumen on a.DataKonsumenAvalistId equals b.DataKonsumenId
                            where _context.DataKontrakKredit.All(x => x.DataKontrakSurveiId != a.DataKontrakSurveiId)
                            select new GetDataSurveiResponse { 
                                NoDataSurveiAvalist = a.NoUrutId,
                                NamaKonsumen = string.Format("{0} - {1} - {2}", b.NoRegisterKonsumen, b.NamaKonsumen, b.NamaPenjamin) }

                ).OrderByDescending(x => x.NoDataSurveiAvalist).ToListAsync(cancellationToken);

            return returnQuery;
        }
    }
}
