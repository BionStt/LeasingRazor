using LeasingRazor.Helpers;
using LeasingRazor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakKredit.Commands.CreateDataKontrakKredit
{
    public class CreateDataKontrakKreditCommandhandler : IRequestHandler<CreateDataKontrakKreditCommand>
    {
        private readonly LeasingRazorDbContext _context;

        public CreateDataKontrakKreditCommandhandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateDataKontrakKreditCommand request, CancellationToken cancellationToken)
        {
            var pokokpinjaman1a = (request.HargaBarang + request.Asuransi + request.Administrasi) - request.UangMuka;
            var bungaflat11 = request.NilaiBunga / pokokpinjaman1a * 12 / request.LamaKredit * 100;

            var dtKontrakSurvei = Guid.NewGuid();// mau dicoding

            var entity = Domain.DataKontrakKredit.CreateDataKontrakKredit(DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGKK", dtKontrakSurvei,
               request.TanggalKontrak, request.PolaAngsuran, request.CaraBayar,request.HargaBarang, request.UangMuka, request.Asuransi,
               request.Administrasi, request.BungaEff, (decimal)bungaflat11, request.LamaKredit, request.TanggalAngsuranBulanan, request.AngsuranDimuka,
                request.NilaiBunga, request.NilaiKontrak, pokokpinjaman1a, request.AngsuranBulanan, request.BiayaAdministrasiAngsuran, request.PenagihId);
      

           await  _context.DataKontrakKredit.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);
            var NoRegKontrakKredit = entity.DataKontrakKreditId;


            if (request.AngsuranDimuka == "1")
            {
                var tglangsur = new DateTime(DateTime.Now.Year, DateTime.Now.Month, Int32.Parse(request.TanggalAngsuranBulanan));

                var BungaEfektif = request.BungaEff / 1200;
                var pokokpinjaman = (request.HargaBarang + request.Asuransi + request.Administrasi) - request.UangMuka;
                var pokokpinjaman2 = (double)((request.HargaBarang + request.Asuransi + request.Administrasi) - request.UangMuka);
                double AngsuranBln1a = (double)request.AngsuranBulanan;
                double cicilanpokok;
                double bunga1;
                double bunga2;
                double nilaibunga = (double)request.NilaiBunga;

                for (int angske = 1; angske <= (request.LamaKredit); angske++)
                {
                    if (angske == 1)
                    {
                        cicilanpokok = FinancialFunctional.Ppmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 1);
                        bunga1 = FinancialFunctional.Ipmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 1);
                        bunga2 = AngsuranBln1a - (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000);
                        pokokpinjaman2 = Math.Round((((pokokpinjaman2 / 1000) * 1000) - (((AngsuranBln1a / 1000)) * 1000)), MidpointRounding.ToEven);

                        var dt = Domain.DataKontrakAngsuran.CreateDataKontrakAngsuran(NoRegKontrakKredit, angske,String.Empty, DateTime.Now.Date,
                           AngsuranBln1a, AngsuranBln1a,0, pokokpinjaman2, nilaibunga,0,0,0,DateTime.Parse("1/1/1900"),0,0,0,String.Empty);

                        await _context.DataKontrakAngsuran.AddAsync(dt);


                    

                    }
                    else
                    {
                        cicilanpokok = FinancialFunctional.Ppmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 1);
                        bunga1 = FinancialFunctional.Ipmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 1);
                        bunga2 = AngsuranBln1a - (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000);
                        pokokpinjaman2 = Math.Round((((pokokpinjaman2 / 1000) * 1000) - (((cicilanpokok / 1000)) * 1000)), MidpointRounding.ToEven);
                        nilaibunga = Math.Round(((((nilaibunga) / 1000) * 1000) - (((((cicilanpokok / 1000)) * 1000) + ((bunga2 / 1000) * 1000)) - ((((cicilanpokok / 1000)) * 1000)))), MidpointRounding.ToEven);

                        var dt = Domain.DataKontrakAngsuran.CreateDataKontrakAngsuran(NoRegKontrakKredit, angske,String.Empty, tglangsur.AddMonths(angske - 1),
                            AngsuranBln1a, (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000), bunga2, pokokpinjaman2, nilaibunga,0,0,0,DateTime.Parse("1/1/1900"),0,0,0,String.Empty);

                        await _context.DataKontrakAngsuran.AddAsync(dt);

                    }
                }
            }
            else
            {
                double AngsuranBln1a = (double)request.AngsuranBulanan;
                Double cicilanpokok;
                Double bunga1;
                Double bunga2;
                var BungaEfektif = request.BungaEff / 1200;
                double nilaibunga = (double)request.NilaiBunga;
                var tglangsur = new DateTime(DateTime.Now.Year, DateTime.Now.Month, Int32.Parse(request.TanggalAngsuranBulanan));
                var pokokpinjaman = request.HargaBarang + request.Asuransi + request.Administrasi - request.UangMuka;
                var pokokpinjaman2 = (double)(request.HargaBarang + request.Asuransi + request.Administrasi - request.UangMuka);
                for (int angske = 1; angske <= request.LamaKredit; angske++)
                {
                    cicilanpokok = FinancialFunctional.Ppmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 0);
                    bunga1 = FinancialFunctional.Ipmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 0);
                    bunga2 = AngsuranBln1a - (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000);
                    pokokpinjaman2 = Math.Round((((pokokpinjaman2 / 1000) * 1000) - (((cicilanpokok / 1000)) * 1000)), MidpointRounding.ToEven);
                    nilaibunga = Math.Round(((((nilaibunga) / 1000) * 1000) - (((((cicilanpokok / 1000)) * 1000) + ((bunga2 / 1000) * 1000)) - ((((cicilanpokok / 1000)) * 1000)))), MidpointRounding.ToEven);

                    var dt = Domain.DataKontrakAngsuran.CreateDataKontrakAngsuran(NoRegKontrakKredit, angske,String.Empty, tglangsur.AddMonths(angske),
                         Math.Round((((((cicilanpokok / 1000)) * 1000) + ((bunga1 / 1000) * 1000))) / 1000, MidpointRounding.ToEven) * 1000, (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000),
                         bunga2, ((Math.Round(pokokpinjaman2 / 1000, MidpointRounding.ToEven) * 1000)), (Math.Round((nilaibunga) / 1000, MidpointRounding.ToEven) * 1000),0,0,0,DateTime.Parse("1/1/1900"),0,0,0,String.Empty);

                    await _context.DataKontrakAngsuran.AddAsync(dt);

                   


                }
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
