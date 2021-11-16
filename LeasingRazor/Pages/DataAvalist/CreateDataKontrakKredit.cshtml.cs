using LeasingRazor.Dto.DataKontrakKredit;
using LeasingRazor.Helpers;
using LeasingRazor.Mapping;
using LeasingRazor.ServiceApplication.DataKontrakSurvei.Queries.GetDataSurvei;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeasingRazor.Pages.DataAvalist
{
    public class CreateDataKontrakKreditModel : PageModel
    {
        private readonly IMediator _mediator;

        public CreateDataKontrakKreditModel(IMediator mediator)
        {
            _mediator=mediator;
        }
        [BindProperty]
        public CreateDataKontrakKreditRequest DataKonstrakKredit { get; set; }
        public async Task OnGetAsync()
        {
            ViewData["AngsuranDimuka1"] = new SelectList(SelectListItemHelper.GetAngsuranDimuka(), "Value", "Text");
            ViewData["PolaAngsuran1"] = new SelectList(SelectListItemHelper.GetPolaAngsuran(), "Value", "Text");
            ViewData["CaraBayar1"] = new SelectList(SelectListItemHelper.GetCaraBayar(), "Value", "Text");

            var DataSurvei1 = await _mediator.Send(new GetDataSurveiQuery());
            ViewData["DataSurvei1"] = new SelectList(DataSurvei1, "NoDataSurveiAvalist", "NamaKonsumen");


        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var xx = DataKonstrakKredit.ToCommand();
            await _mediator.Send(xx);


            return RedirectToPage();
        }
    }
}
