using LeasingRazor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakAsuransi.Commands.CreateDataKontrakAsuransi
{
    public class CreateDataKontrakAsuransiCommandHandler : IRequestHandler<CreateDataKontrakAsuransiCommand>
    {
        private readonly LeasingRazorDbContext _context;

        public CreateDataKontrakAsuransiCommandHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateDataKontrakAsuransiCommand request, CancellationToken cancellationToken)
        {
            var dtKontrakKreditId = Guid.NewGuid();//request.NoRegistrasiKontrakKredit
            var mstPerusahaanAsuransi = Guid.NewGuid();

            var entity = Domain.DataKontrakAsuransi.CreateDataKontrakAsuransi(dtKontrakKreditId, mstPerusahaanAsuransi,
                 DateTime.UtcNow.Date.Year.ToString() +
               DateTime.UtcNow.Date.Month.ToString() +
               DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGKA",
                request.KodeAsuransi, request.JenisAsuransi ,request.TanggalMulaiAsuransi, request.TanggalAkhirAsuransi, request.LamaAsuransi,
                request.NilaiPertanggungan, request.BiayaAsuransi);

        
            await  _context.DataKontrakAsuransi.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);


            return Unit.Value;
        }
    }
}
