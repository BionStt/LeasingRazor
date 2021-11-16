using LeasingRazor.Dto.MasterBidangUsaha;
using LeasingRazor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.MasterBidangUsaha.Queries.GetNamaBidangUsaha
{
    public class GetNamaBidangUsahaQueryHandler : IRequestHandler<GetNamaBidangUsahaQuery, IReadOnlyCollection<GetNamaBidangUsahaResponse>>
    {
        private readonly LeasingRazorDbContext _context;

        public GetNamaBidangUsahaQueryHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetNamaBidangUsahaResponse>> Handle(GetNamaBidangUsahaQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBidangUsaha.Select(x => new GetNamaBidangUsahaResponse
            {
                NoKodeMasterBidangUsaha = x.NoUrutId,
                NamaMasterBidangUsaha = x.MasterBidangUsahaKeterangan

            }).AsNoTracking().ToListAsync();



            return returnQuery;
        }
    }
}
