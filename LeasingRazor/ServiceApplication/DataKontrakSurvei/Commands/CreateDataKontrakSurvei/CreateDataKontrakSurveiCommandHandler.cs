using LeasingRazor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakSurvei.Commands.CreateDataKontrakSurvei
{
    public class CreateDataKontrakSurveiCommandHandler : IRequestHandler<CreateDataKontrakSurveiCommand>
    {
        private readonly LeasingRazorDbContext _context;

        public CreateDataKontrakSurveiCommandHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateDataKontrakSurveiCommand request, CancellationToken cancellationToken)
        {
            var dtKonsumenAvalist = await _context.DataKonsumen.Where(x => x.NoUrutId==request.NoRegistrasiKonsumen).Select(x => x.DataKonsumenId).SingleOrDefaultAsync();

            var KodeBidangPekerjaan = await _context.MasterBidangPekerjaan.Where(x=>x.NoUrutId==int.Parse(request.KodeBidangPekerjaan)).Select(x=>x.MasterBidangPekerjaanId).SingleOrDefaultAsync(); //request.KodeBidangPekerjaan
            var KodeBidangUsaha = await _context.MasterBidangUsaha.Where(x=>x.NoUrutId==int.Parse(request.KodeBidangUsaha)).Select(x=>x.MasterBidangUsahaId).SingleOrDefaultAsync(); //request.KodeBidangUsaha
            var mstBarangId = await _context.MasterBarang.Where(x=>x.NoUrutId==request.NoUrutMasterBarang).Select(x=>x.MasterBarangId).SingleOrDefaultAsync();//request.NoUrutMasterBarang

            var dtDataKontrakSurvei = Domain.DataKontrakSurvei.CreateDataKontrakSurvei(DateTime.UtcNow.Date.Year.ToString() +
               DateTime.UtcNow.Date.Month.ToString() +
               DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGDS",
               DateTime.Now.Date, dtKonsumenAvalist, request.Karakter, request.Kerjasama, request.Penghasilan, request.Penghasilanlain, request.PenghasilanPasangan, request.PengeluaranTetapBulanan,
               request.Tanggungan, request.StatusTempatTinggal, request.TinggalSejak, request.HasilSurvei, KodeBidangPekerjaan, request.NamaBidangPekerjaan,
               KodeBidangUsaha, request.NamaBidangUsaha, request.OmzetBulanan, request.PernahKredit, mstBarangId, request.FasilitasKreditBank, request.JenisFasilitasbank,
               request.NamaRekeningBank, request.NoRekeningBank, request.LuasRumah, request.LuasTanah, request.LuasUsaha, request.DayaListrikRumah, request.TagihanPLN, request.TagihanTelp,
               request.TagihanPDAM, request.KondisiFisikRumah, request.SegmenRumah, request.KondisiJalanRumah, request.PagarRumah, request.TamanRumah, request.GarasiRumah,
               request.KapasitasGarasiRumah, request.DindingRumah, request.AtapRumah, request.LantaiRumah, request.ToiletRumah, request.TelevisiRumah, request.Kulkas, request.LokasiSurvei,
               request.LokasiTempatTinggal, request.NamaMendesak, request.AlamatMendesak, request.KelurahanMendesak, request.KecamatanMendesak, request.KotaMendesak, request.PropinsiMendesak,
               request.KodePosMendesak, request.TelpMendesak, request.HandphoneMendesak, request.HandphoneMendesak2, request.HubunganDenganMendesak, request.SurveiId, request.KeteranganLain);
               

            await _context.DataKontrakSurvei.AddAsync(dtDataKontrakSurvei);
            await _context.SaveChangesAsync();

            return Unit.Value;

        }
    }
}
