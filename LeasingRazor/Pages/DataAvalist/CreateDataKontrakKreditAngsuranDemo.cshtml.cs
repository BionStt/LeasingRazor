using LeasingRazor.Dto.DataKontrakKreditAngsuranDemo;
using LeasingRazor.Helpers;
using LeasingRazor.Mapping;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeasingRazor.Pages.DataAvalist
{
    public class CreateDataKontrakKreditAngsuranDemoModel : PageModel
    {
        private readonly IMediator _mediator;

        [BindProperty]
        public CreateDataKontrakKreditAngsuranDemoRequest DataKonstrakKreditAngsuranDemo { get; set; }
        public CreateDataKontrakKreditAngsuranDemoModel(IMediator mediator)
        {
            _mediator=mediator;
        }

        public async Task OnGetAsync()
        {
            ViewData["AngsuranDimuka1"] = new SelectList(SelectListItemHelper.GetAngsuranDimuka(), "Value", "Text");
            ViewData["PolaAngsuran1"] = new SelectList(SelectListItemHelper.GetPolaAngsuran(), "Value", "Text");
            ViewData["CaraBayar1"] = new SelectList(SelectListItemHelper.GetCaraBayar(), "Value", "Text");

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var xx = DataKonstrakKreditAngsuranDemo.ToCommand();
            await _mediator.Send(xx);

          
            return RedirectToPage();
        }
    }
}
