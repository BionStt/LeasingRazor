using LeasingRazor.Dto.DataKontrakKredit;
using LeasingRazor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakKredit.Queries.GetListDataKontrakKreditByNoID
{
    public class GetListDataKontrakKreditByNoIDQueryHandler : IRequestHandler<GetListDataKontrakKreditByNoIDQuery, GetListDataKontrakKreditByNoIDResponse>
    {
        private readonly LeasingRazorDbContext _context;

        public GetListDataKontrakKreditByNoIDQueryHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<GetListDataKontrakKreditByNoIDResponse> Handle(GetListDataKontrakKreditByNoIDQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.DataKontrakAngsuran
                            join b in _context.DataKontrakKredit on a.DataKontrakKreditId equals b.DataKontrakKreditId
                            join c in _context.DataKontrakSurvei on b.DataKontrakSurveiId equals c.DataKontrakSurveiId
                            join d in _context.DataKonsumen on c.DataKonsumenAvalistId equals d.DataKonsumenId
                            where b.NoUrutId == Int32.Parse(request.dataKontrakId)

                            select new GetListDataKontrakKreditByNoIDResponse
                            {
                                NoUrutDataKontrakKredit1 = b.NoUrutId,
                                NamaKonsumen1 = d.NamaKonsumen,
                                NamaPenjamin1 = d.NamaPenjamin,
                                AlamatRumah = string.Format("{0} Kel.{1} Kec.{2} Kota {3} Propinsi {4} Kode Pos:{5}", d.AlamatTinggalK, d.KelurahanK, d.KecamatanK, d.KotaK, d.PropinsiK, d.KodePosTinggalK),
                                NoTeleponRumah = d.TelpRumah,
                                NoTeleponKantor = d.TelpKantor,
                                NoTeleponUsaha = d.TelpUsaha,
                                NoHP1 = d.NoHandphone,
                                NoHP2 = d.NoHandphone2,
                                NilaiKontrak1 = b.NilaiKontrak,
                                NilaiBunga1 = b.NilaiBunga,
                                Tenor1 = b.LamaKredit,
                                Angsuran1 = b.AngsuranBulanan,
                                pinjamanPokok = b.PinjamanPokok


                            }

             ).SingleOrDefaultAsync(cancellationToken);

            return returnQuery;

        }
    }
}
