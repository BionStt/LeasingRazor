using LeasingRazor.ServiceApplication.DataKontrakAngsuran.Queries.GetDataKontrakAngsuranByNoID;
using LeasingRazor.ServiceApplication.DataKontrakKredit.Queries.GetListDataKontrakKreditByNoID;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LeasingRazor.Dto.DataKontrakKreditAngsuranDemo;

namespace LeasingRazor.Pages.DataAvalist
{
    public class CetakDataRincianAngsuranModel : PageModel
    {
        private readonly IMediator _mediator;

        [BindProperty]
        public IReadOnlyCollection<GetDataKontrakAngsuranByNoIDResponse> DataKontrakAngsuranById { get; set; }

        public CetakDataRincianAngsuranModel(IMediator mediator)
        {
            _mediator=mediator;
        }

        public async Task OnGetAsync(string dataKontrakKreditId)
        {
            var DataAngsuran = await _mediator.Send(new GetListDataKontrakKreditByNoIDQuery { dataKontrakId = dataKontrakKreditId });

           
            ViewData["NamaKonsumen1"] = DataAngsuran.NamaKonsumen1;
            ViewData["NamaPenjamin1"] = DataAngsuran.NamaPenjamin1;
            ViewData["AlamatRumah"] = DataAngsuran.AlamatRumah;
            ViewData["NoTeleponRumah"] = DataAngsuran.NoTeleponRumah;
            ViewData["NoTeleponKantor"] = DataAngsuran.NoTeleponKantor;
            ViewData["NoTeleponUsaha"] = DataAngsuran.NoTeleponUsaha;
            ViewData["NoHP1"] = DataAngsuran.NoHP1;
            ViewData["NoHP2"] = DataAngsuran.NoHP2;
            ViewData["NilaiKontrak1"] = DataAngsuran.NilaiKontrak1;
            ViewData["NilaiBunga1"] = DataAngsuran.NilaiBunga1;
            ViewData["Tenor1"] = DataAngsuran.Tenor1;
            ViewData["Angsuran1"] = DataAngsuran.Angsuran1;
            ViewData["pinjamanPokok"] = DataAngsuran.pinjamanPokok;
            ViewData["hargaBarang"] = DataAngsuran.hargaBarang;
            ViewData["uangMuka"] = DataAngsuran.uangMuka;
            ViewData["asuransi"] = DataAngsuran.asuransi;
            ViewData["administrasi"] = DataAngsuran.administrasi;
            ViewData["bungaEff"] = DataAngsuran.bungaEff;
            ViewData["bungaFlat"] = DataAngsuran.bungaFlat;

            DataKontrakAngsuranById = await _mediator.Send(new GetDataKontrakAngsuranByNoIDQuery { dataKontrakId = dataKontrakKreditId });
         

        }
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    return RedirectToPage();
        //}
    }
}
