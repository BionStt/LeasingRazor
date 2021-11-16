using LeasingRazor.Helpers;
using LeasingRazor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakKreditAngsuranDemo.Commands.CreateDataKontrakKreditAngsuranDemo
{
    public class CreateDataKontrakKreditAngsuranDemoCommandHandler : IRequestHandler<CreateDataKontrakKreditAngsuranDemoCommand>
    {
        private readonly LeasingRazorDbContext _context;

        public CreateDataKontrakKreditAngsuranDemoCommandHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateDataKontrakKreditAngsuranDemoCommand request, CancellationToken cancellationToken)
        {
            if (request.AngsuranDimuka == "1")
            {
              
                var tglangsur = new DateTime(DateTime.Now.Year, DateTime.Now.Month, request.TanggalJatuhTempoBulanan);

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

                        //var dt = Domain.DataKontrakKreditAngsuranDemo.CreateDataKontrakKreditAngsuranDemo(angske,String.Empty, DateTime.Now.Date, AngsuranBln1a, AngsuranBln1a,
                        //    0, pokokpinjaman2, nilaibunga,0,0,0,DateTime.Parse("1/1/1900"),0,0,String.Empty);

                       await  _context.DataKontrakKreditAngsuranDemo.AddAsync(Domain.DataKontrakKreditAngsuranDemo.CreateDataKontrakKreditAngsuranDemo(angske, String.Empty, DateTime.Now.Date, AngsuranBln1a, AngsuranBln1a,
                            0, pokokpinjaman2, nilaibunga, 0, 0, 0, DateTime.Parse("1/1/1900"), 0, 0, String.Empty));

                        //_context.DataKontrakKreditAngsuranDemo.Add(new DataKontrakKreditAngsuranDemo
                        //{


                        //    AngsKe = angske,
                        //    TglAngsuran = DateTime.Now.Date,
                        //    Angsuran = AngsuranBln1a,
                        //    Pokok = AngsuranBln1a,
                        //    Bunga = 0,
                        //    SisaPokok = pokokpinjaman2,
                        //    SisaBunga = nilaibunga


                        //});

                    }
                    else
                    {
                        cicilanpokok = FinancialFunctional.Ppmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 1);
                        bunga1 = FinancialFunctional.Ipmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 1);
                        bunga2 = AngsuranBln1a - (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000);
                        pokokpinjaman2 = Math.Round((((pokokpinjaman2 / 1000) * 1000) - (((cicilanpokok / 1000)) * 1000)), MidpointRounding.ToEven);
                        nilaibunga = Math.Round(((((nilaibunga) / 1000) * 1000) - (((((cicilanpokok / 1000)) * 1000) + ((bunga2 / 1000) * 1000)) - ((((cicilanpokok / 1000)) * 1000)))), MidpointRounding.ToEven);

                         await _context.DataKontrakKreditAngsuranDemo.AddAsync(Domain.DataKontrakKreditAngsuranDemo.CreateDataKontrakKreditAngsuranDemo(angske, String.Empty, tglangsur.AddMonths(angske - 1), AngsuranBln1a,
                            (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000), bunga2, pokokpinjaman2, nilaibunga, 0, 0, 0, DateTime.Parse("1/1/1900"), 0, 0, String.Empty));
                       
                        //_context.DataKontrakKreditAngsuranDemo.Add(new DataKontrakKreditAngsuranDemo
                        //{


                        //    AngsKe = angske,
                        //    TglAngsuran = tglangsur.AddMonths(angske - 1),
                        //    Angsuran = AngsuranBln1a,
                        //    Pokok = (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000),
                        //    Bunga = bunga2,
                        //    SisaPokok = pokokpinjaman2,
                        //    SisaBunga = nilaibunga


                        //});

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
                var tglangsur = new DateTime(DateTime.Now.Year, DateTime.Now.Month, request.TanggalJatuhTempoBulanan);
                var pokokpinjaman = request.HargaBarang + request.Asuransi + request.Administrasi - request.UangMuka;
                var pokokpinjaman2 = (double)(request.HargaBarang + request.Asuransi + request.Administrasi - request.UangMuka);
                for (int angske = 1; angske <= request.LamaKredit; angske++)
                {
                    cicilanpokok = FinancialFunctional.Ppmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 0);
                    bunga1 = FinancialFunctional.Ipmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 0);
                    bunga2 = AngsuranBln1a - (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000);
                    pokokpinjaman2 = Math.Round((((pokokpinjaman2 / 1000) * 1000) - (((cicilanpokok / 1000)) * 1000)), MidpointRounding.ToEven);
                    nilaibunga = Math.Round(((((nilaibunga) / 1000) * 1000) - (((((cicilanpokok / 1000)) * 1000) + ((bunga2 / 1000) * 1000)) - ((((cicilanpokok / 1000)) * 1000)))), MidpointRounding.ToEven);

                  await _context.DataKontrakKreditAngsuranDemo.AddAsync(Domain.DataKontrakKreditAngsuranDemo.CreateDataKontrakKreditAngsuranDemo(angske, String.Empty, tglangsur.AddMonths(angske),
                         Math.Round((((((cicilanpokok / 1000)) * 1000) + ((bunga1 / 1000) * 1000))) / 1000, MidpointRounding.ToEven) * 1000,
                         (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000), bunga2,
                         ((Math.Round(pokokpinjaman2 / 1000, MidpointRounding.ToEven) * 1000)), (Math.Round((nilaibunga) / 1000, MidpointRounding.ToEven) * 1000),
                         0, 0, 0, DateTime.Parse("1/1/1900"), 0, 0, String.Empty));

                    //_context.DataKontrakKreditAngsuranDemo.Add(new DataKontrakKreditAngsuranDemo
                    //{

                    //    AngsKe = angske,
                    //    TglAngsuran = tglangsur.AddMonths(angske),
                    //    Angsuran = Math.Round((((((cicilanpokok / 1000)) * 1000) + ((bunga1 / 1000) * 1000))) / 1000, MidpointRounding.ToEven) * 1000,
                    //    Pokok = (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000),
                    //    Bunga = bunga2,
                    //    SisaPokok = ((Math.Round(pokokpinjaman2 / 1000, MidpointRounding.ToEven) * 1000)),
                    //    SisaBunga = (Math.Round((nilaibunga) / 1000, MidpointRounding.ToEven) * 1000)


                    //});


                }
            }



            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;

        }
    }
}
