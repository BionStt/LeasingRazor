using LeasingRazor.Dto.DataKontrakKredit;
using LeasingRazor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LeasingRazor.ServiceApplication.DataKontrakKredit.Queries.GetListDataKontrakKredit
{
    public class GetListDataKontrakKreditQueryHandler : IRequestHandler<GetListDataKontrakKreditQuery, IReadOnlyCollection<GetListDataKontrakKreditResponse>>
    {
        private readonly LeasingRazorDbContext _context;

        public GetListDataKontrakKreditQueryHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetListDataKontrakKreditResponse>> Handle(GetListDataKontrakKreditQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.DataKontrakKredit
                            join b in _context.DataKontrakSurvei on a.DataKontrakSurveiId equals b.DataKontrakSurveiId
                            join c in _context.DataKonsumen on b.DataKonsumenAvalistId equals c.DataKonsumenId
                            join d in _context.MasterBarang on b.MasterBarangDBId equals d.MasterBarangId
                            select new GetListDataKontrakKreditResponse
                            {
                                NoUrutDataKontrakKredit1 = a.NoUrutId,
                                DataKontrakKredit = string.Format("{0} - {1} - {2} - {3}", a.NoRegisterKontrakKredit, c.NamaKonsumen, c.NamaPenjamin, d.NamaBarang)
                            }

               ).OrderByDescending(x => x.NoUrutDataKontrakKredit1).ToListAsync(cancellationToken);

            return returnQuery;
        }
    }
}
