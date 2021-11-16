using LeasingRazor.Dto.MasterBarang;
using LeasingRazor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.MasterBarang.Queries.GetNamaBarangQr
{
    public class GetNamaBarangQrQueryHandler : IRequestHandler<GetNamaBarangQrQuery, IReadOnlyCollection<GetNamaBarangQrResponse>>
    {
        private readonly LeasingRazorDbContext _context;

        public GetNamaBarangQrQueryHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetNamaBarangQrResponse>> Handle(GetNamaBarangQrQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBarang.Select(x=>new GetNamaBarangQrResponse {
            NamaBarang = x.NamaBarang,
            NoUrutKendaraan = x.NoUrutId

            }).ToListAsync();

            return returnQuery;
        }
    }
}
