using LeasingRazor.ServiceApplication.DataKontrakKredit.Queries.GetListDataKontrakKredit;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeasingRazor.Pages.DataAvalist
{
    public class ListDataKontrakKreditModel : PageModel
    {
        private readonly IMediator _mediator;


        public ListDataKontrakKreditModel(IMediator mediator)
        {
            _mediator=mediator;
        }

        public async Task OnGetAsync()
        {
            var datalist = await _mediator.Send(new GetListDataKontrakKreditQuery());
            ViewData["DataKontrakList1"] = new SelectList(datalist, "NoUrutDataKontrakKredit1", "DataKontrakKredit");

        }
        public async Task<IActionResult> OnPostAsync(string DataId)
        {
            return RedirectToPage("./CetakDataRincianAngsuran", new { dataKontrakKreditId = DataId });
        }
    }
}
