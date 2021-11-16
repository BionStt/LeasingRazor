using LeasingRazor.Dto.MasterBidangPekerjaan;
using LeasingRazor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.MasterBidangPekerjaan.Queries.GetNamaBidangPekerjaan
{
    public class GetNamaBidangPekerjaanQueryHandler : IRequestHandler<GetNamaBidangPekerjaanQuery, IReadOnlyCollection<GetNamaBidangPekerjaanResponse>>
    {
        private readonly LeasingRazorDbContext _context;

        public GetNamaBidangPekerjaanQueryHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>> Handle(GetNamaBidangPekerjaanQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBidangPekerjaan.Select(x => new GetNamaBidangPekerjaanResponse
            {
                NoUrutBidangPekerjaan = x.NoUrutId,
                NamaMasterBidangPekerjaan = x.MasterBidangPekerjaanKeterangan

            }).AsNoTracking().ToListAsync();

            return returnQuery;

        }
    }
}
