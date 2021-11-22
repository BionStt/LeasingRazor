using LeasingRazor.Dto.DataKontrakKreditAngsuranDemo;
using LeasingRazor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LeasingRazor.ServiceApplication.DataKontrakAngsuran.Queries.GetDataKontrakAngsuranByNoID
{
    public class GetDataKontrakAngsuranByNoIDQueryHandler : IRequestHandler<GetDataKontrakAngsuranByNoIDQuery, IReadOnlyCollection<GetDataKontrakAngsuranByNoIDResponse>>
    {
        private readonly LeasingRazorDbContext _context;

        public GetDataKontrakAngsuranByNoIDQueryHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetDataKontrakAngsuranByNoIDResponse>> Handle(GetDataKontrakAngsuranByNoIDQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.DataKontrakAngsuran
                            join b in _context.DataKontrakKredit on a.DataKontrakKreditId equals b.DataKontrakKreditId
                            join c in _context.DataKontrakSurvei on b.DataKontrakSurveiId equals c.DataKontrakSurveiId
                            where b.NoUrutId == Int32.Parse(request.dataKontrakId)

                            select new GetDataKontrakAngsuranByNoIDResponse
                            {
                                NoUrutDataKontrakKredit1 = b.NoUrutId,
                                AngsuranKeA = a.AngsuranKe,
                                TanggalAngsuran1 = a.TanggalAngsuran,
                                AngsuranPerBulan = a.Angsuran,
                                Pokok1 = a.Pokok,
                                Bunga1 = a.Bunga,
                                SisaPokok1 = a.SisaPokok,
                                SisaBunga1 = a.SisaBunga
                            }

             ).OrderBy(x => x.AngsuranKeA).ToListAsync(cancellationToken);

            return returnQuery;

        }
    }
}
