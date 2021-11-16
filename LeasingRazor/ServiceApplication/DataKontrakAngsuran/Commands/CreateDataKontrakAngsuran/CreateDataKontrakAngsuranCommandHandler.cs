using LeasingRazor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.ServiceApplication.DataKontrakAngsuran.Commands.CreateDataKontrakAngsuran
{
    public class CreateDataKontrakAngsuranCommandHandler : IRequestHandler<CreateDataKontrakAngsuranCommand, Guid>
    {
        public readonly LeasingRazorDbContext _context;

        public CreateDataKontrakAngsuranCommandHandler(LeasingRazorDbContext context)
        {
            _context=context;
        }

        public async Task<Guid> Handle(CreateDataKontrakAngsuranCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
