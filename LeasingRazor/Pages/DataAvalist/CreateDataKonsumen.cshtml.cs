using LeasingRazor.Dto.DataKonsumen;
using LeasingRazor.Helpers;
using LeasingRazor.Mapping;
using LeasingRazor.ServiceApplication.MasterBidangPekerjaan.Queries.GetNamaBidangPekerjaan;
using LeasingRazor.ServiceApplication.MasterBidangUsaha.Queries.GetNamaBidangUsaha;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeasingRazor.Pages.DataAvalist
{
    public class CreateDataKonsumenModel : PageModel
    {
        private readonly IMediator _mediator;
        [BindProperty]
        public CreateDataKonsumenRequest DataKonsumenRequest { get; set; }

        public CreateDataKonsumenModel(IMediator mediator)
        {
            _mediator=mediator;
        }

        public async Task OnGetAsync()
        {
            ViewData["JenisKelamin1"] = new SelectList(SelectListItemHelper.GetJenisKelaminList(), "Value", "Text");
            ViewData["Agama1"] = new SelectList(SelectListItemHelper.GetAgamaList(), "Value", "Text");
            ViewData["StatusNikah"] = new SelectList(SelectListItemHelper.GetStatusMenikah(), "Value", "Text");
            ViewData["StatusRumah"] = new SelectList(SelectListItemHelper.GetStatusTempatTinggal(), "Value", "Text");
            ViewData["TingkatPendidikan"] = new SelectList(SelectListItemHelper.GetPendidikanTerakhir(), "Value", "Text");
            ViewData["HubunganDenganKel"] = new SelectList(SelectListItemHelper.GetHubunganKeluarga(), "Value", "Text");
            ViewData["SkalaUsaha1"] = new SelectList(SelectListItemHelper.GetSkalaUsaha(), "Value", "Text");

            var NamaBidangPekerjaan1 = await _mediator.Send(new GetNamaBidangPekerjaanQuery());
            var NamaBidangUsaha1 = await _mediator.Send(new GetNamaBidangUsahaQuery());
            ViewData["NamaBidangPekerjaan1"] = new SelectList(NamaBidangPekerjaan1, "NoUrutBidangPekerjaan", "NamaMasterBidangPekerjaan");
            ViewData["NamaBidangUsaha1"] = new SelectList(NamaBidangUsaha1, "NoKodeMasterBidangUsaha", "NamaMasterBidangUsaha");

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var xx = DataKonsumenRequest.ToCommand();
            await _mediator.Send(xx);



            return RedirectToPage("./DataAvalist/CreateDataKontrakSurvei");

     

        }
    }
}
