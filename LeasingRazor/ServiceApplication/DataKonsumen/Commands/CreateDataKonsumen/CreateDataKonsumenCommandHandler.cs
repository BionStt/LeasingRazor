using LeasingRazor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class CreateDataKonsumenCommandHandler : IRequestHandler<CreateDataKonsumenCommand, Guid>
    {
        private readonly LeasingRazorDbContext _context;

        public CreateDataKonsumenCommandHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<Guid> Handle(CreateDataKonsumenCommand request, CancellationToken cancellationToken)
        {
            var dtDataKonsumen = Domain.DataKonsumen.CreateDataKonsumen(DateTime.UtcNow.Date.Year.ToString() +
              DateTime.UtcNow.Date.Month.ToString() +
              DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGCUST",
              DateTime.Now.Date,request.NamaKonsumen, request.AlamatTinggalK, request.KelurahanK, request.KecamatanK, request.KotaK, request.PropinsiK, request.KodePosTinggalK, request.TelpRumah,
              request.NoHandphone, request.NoHandphone2, request.NoKTP, request.TempatLahir, request.Tanggallahir, request.TanggalExpireKTP, request.AlamatKTP, request.KelurahanKTP, request.KecamatanKTP, request.KotaKTP,
               request.PropinsiKTP, request.KodePosKTP, request.JenisKelamin, request.StatusNikah, request.Agama, request.TingkatPendidikan, request.Email, request.KodePekerjaan, request.NamaPekerjaan, request.JabatanPerusahaan, request.NamaKantor,
              request.AlamatKantor, request.KelurahanKantor, request.KecamatanKantor, request.KotaKantor, request.PropinsiKantor, request.KodePosKantor,
                request.TelpKantor, request.FaxKantor, request.NamaUsaha, request.AlamatUsaha, request.KelurahanUsaha, request.KecamatanUsaha, request.KotaUsaha, request.PropinsiUsaha, request.KodePosUsaha,
              request.TelpUsaha, request.FaxUsaha, request.NoNpwpusaha, request.NoSiupusaha, request.NoTDPusaha, request.TanggalMulaiUsaha,
                request.JumlahKaryawan, request.SkalaUsaha, request.KodeBidangUsaha, request.NamaBidangUsaha, request.AlamatSurat, request.KelurahanSurat,
               request.KecamatanSurat, request.KotaSurat, request.PropinsiSurat, request.KodePosSurat, request.NamaIbuKandung, request.KodePekerjaanIbuKandung,
               request.NamaPekerjaanIbuKandung, request.KodeBidangUsahaIbuKandung, request.NamaBidangUsahaIbuKandung, request.NamaPenjamin,
            request.AlamatPenjamin, request.KelurahanPenjamin, request.KecamatanPenjamin, request.KotaPenjamin, request.PropinsiPenjamin,
              request.KodePosPenjamin, request.TelpRumahPenjamin, request.NoHandphonePenjamin, request.NoHandphonePenjamin2, request.NoKTPPenjamin,
              request.TempatLahirPenjamin, request.TanggalLahirPenjamin, request.TanggalExpireKTPPenjamin, request.AlamatKtpPenjamin,
              request.KelurahanKtpPenjamin, request.KecamatanKtpPenjamin, request.KotaKtpPenjamin, request.PropinsiKtpPenjamin, request.KodePosKTPPenjamin,
               request.JenisKelaminPenjamin, request.StatusNikahPenjamin, request.AgamaPenjamin, request.KodeBidangUsahaPenjamin, request.NamaBidangUsahaPenjamin,
                request.KodePekerjaanPenjamin, request.NamaPekerjaanPenjamin, request.TingkatPendidikanPenjamin, request.HubunganPenjamin, request.NamaKantorPenjamin,
             request.AlamatKantorPenjamin, request.KelurahanKantorPenjamin, request.KecamatanKantorPenjamin, request.KotaKantorPenjamin,
             request.PropinsiKantorPenjamin, request.KodePosKantorPenjamin, request.TelpKantorPenjamin, request.FaxKantorPenjamin, request.NamaUsahaPenjamin,
              request.AlamatUsahaPenjamin, request.KelurahanUsahaPenjamin, request.KecamatanUsahaPenjamin, request.KotaUsahaPenjamin,
               request.PropinsiUsahaPenjamin, request.KodePosUsahaPenjamin, request.TelpUsahaPenjamin, request.FaxUsahaPenjamin,
               request.NoNPWPUsahaPenjamin,string.Empty, request.NoSIUPusahaPenjamin ,request.NoTDPUsahaPenjamin, request.JmlKaryawanPenjamin, request.SkalaUsahaPenjamin);

         


            await _context.DataKonsumen.AddAsync(dtDataKonsumen);
            await _context.SaveChangesAsync();

            return dtDataKonsumen.DataKonsumenId;

        }
    }
}
