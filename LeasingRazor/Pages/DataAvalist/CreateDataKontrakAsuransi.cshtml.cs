using LeasingRazor.Dto.DatakontrakAsuransi;
using LeasingRazor.Mapping;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LeasingRazor.Pages.DataAvalist
{
    public class CreateDataKontrakAsuransiModel : PageModel
    {
        private readonly IMediator _mediator;

        public CreateDataKontrakAsuransiModel(IMediator mediator)
        {
            _mediator=mediator;
        }

        [BindProperty]
        public CreateDataKontrakAsuransiRequest DataKonstrakAsuransi { get; set; }
        public async Task OnGetAsync()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            var xx = DataKonstrakAsuransi.ToCommand();

            await _mediator.Send(xx);
            return RedirectToPage();
        }
    }
}
