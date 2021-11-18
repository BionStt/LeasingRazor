using LeasingRazor.ServiceApplication.DataKontrakAngsuran.Queries.GetDataKontrakAngsuranByNoID;
using LeasingRazor.ServiceApplication.DataKontrakKredit.Queries.GetListDataKontrakKreditByNoID;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LeasingRazor.Pages.DataAvalist
{
    public class CetakDataRincianAngsuranModel : PageModel
    {
        private readonly IMediator _mediator;

        public CetakDataRincianAngsuranModel(IMediator mediator)
        {
            _mediator=mediator;
        }

        public async Task OnGetAsync()
        {
            var DataAngsuran = await Mediator.Send(new GetListDataKontrakKreditByNoIDQuery { dataKontrakId = Id });
            var aa = DataAngsuran.DataKontraKrediListByIDDs.ToList();
            ViewBag.NamaKonsumen1 = aa[0].NamaKonsumen1;
            ViewBag.NamaPenjamin1 = aa[0].NamaPenjamin1;
            ViewBag.AlamatRumah = aa[0].AlamatRumah;
            ViewBag.NoTeleponRumah = aa[0].NoTeleponRumah;
            ViewBag.NoTeleponKantor = aa[0].NoTeleponKantor;
            ViewBag.NoTeleponUsaha = aa[0].NoTeleponUsaha;
            ViewBag.NoHP1 = aa[0].NoHP1;
            ViewBag.NoHP2 = aa[0].NoHP2;
            ViewBag.NilaiKontrak1 = aa[0].NilaiKontrak1;
            ViewBag.NilaiBunga1 = aa[0].NilaiBunga1;
            ViewBag.Tenor1 = aa[0].Tenor1;
            ViewBag.Angsuran1 = aa[0].Angsuran1;
            ViewBag.pinjamanPokok = aa[0].pinjamanPokok;


            var RinciangAngsuran = await _mediator.Send(new GetDataKontrakAngsuranByNoIDQuery { dataKontrakId = Id });
            var RinciangAngsuran1 = RinciangAngsuran;

        }
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage();
        }
    }
}
