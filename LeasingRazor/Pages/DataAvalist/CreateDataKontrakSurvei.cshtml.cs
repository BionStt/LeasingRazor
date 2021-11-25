using LeasingRazor.Dto.DataKontrakSurvei;
using LeasingRazor.Helpers;
using LeasingRazor.Mapping;
using LeasingRazor.ServiceApplication.DataKonsumen.Queries.GetDataKonsumenAvalist;
using LeasingRazor.ServiceApplication.MasterBarang.Queries.GetNamaBarangQr;
using LeasingRazor.ServiceApplication.MasterBidangPekerjaan.Queries.GetNamaBidangPekerjaan;
using LeasingRazor.ServiceApplication.MasterBidangUsaha.Queries.GetNamaBidangUsaha;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeasingRazor.Pages.DataAvalist
{
    public class CreateDataKontrakSurveiModel : PageModel
    {
        private readonly IMediator _mediator;

        [BindProperty]
        public DataKontrakSurveiRequest DataKonstrakSurvei { get; set; }

        public CreateDataKontrakSurveiModel(IMediator mediator)
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
            ViewData["HasilSurvei"] = new SelectList(SelectListItemHelper.GetHasilSurvei(), "Value", "Text");
            ViewData["LokasiTempatTinggal"] = new SelectList(SelectListItemHelper.GetLokasiTempatTinggal(), "Value", "Text");
            ViewData["TempatSurvei"] = new SelectList(SelectListItemHelper.GetTempatSurvei(), "Value", "Text");
            ViewData["Kulkas"] = new SelectList(SelectListItemHelper.GetKulkas(), "Value", "Text");
            ViewData["TV"] = new SelectList(SelectListItemHelper.GetTv(), "Value", "Text");
            ViewData["Toilet"] = new SelectList(SelectListItemHelper.GetToilet(), "Value", "Text");
            ViewData["LantaiRumah"] = new SelectList(SelectListItemHelper.GetLantaiRumah(), "Value", "Text");
            ViewData["AtapRumah"] = new SelectList(SelectListItemHelper.GetAtapRumah(), "Value", "Text");
            ViewData["DindingRumah"] = new SelectList(SelectListItemHelper.GetDindingRumah(), "Value", "Text");
            ViewData["GarasiRumah"] = new SelectList(SelectListItemHelper.GetGarasiRumah(), "Value", "Text");
            ViewData["KondisiPagar"] = new SelectList(SelectListItemHelper.GetKondisiPagar(), "Value", "Text");
            ViewData["KondisiTanaman"] = new SelectList(SelectListItemHelper.GetKondisiTanaman(), "Value", "Text");
            ViewData["KondisiJalanRumah"] = new SelectList(SelectListItemHelper.GetKondisiJalanRumah(), "Value", "Text");
            ViewData["KondisiFisikRumah"] = new SelectList(SelectListItemHelper.GetKondisiFisikRumah(), "Value", "Text");
            ViewData["SegmenRumah"] = new SelectList(SelectListItemHelper.GetSegmenRumah(), "Value", "Text");
            ViewData["PernahKredit"] = new SelectList(SelectListItemHelper.GetPernahKredit(), "Value", "Text");
            ViewData["JumlahTanggungan"] = new SelectList(SelectListItemHelper.GetJumlahTanggungan(), "Value", "Text");
            ViewData["Kerjasama"] = new SelectList(SelectListItemHelper.GetKerjasama(), "Value", "Text");
            ViewData["Karakter"] = new SelectList(SelectListItemHelper.GetKarakter(), "Value", "Text");

            var DataKonsumenAvalist = await _mediator.Send(new GetDataKonsumenAvalistQuery());
            ViewData["NamaKonsumen1"] = new SelectList(DataKonsumenAvalist, "NoCustomerAvalist", "NamaKonsumen");

            var NamaBarang = await _mediator.Send(new GetNamaBarangQrQuery());
            ViewData["NamaBarang"] = new SelectList(NamaBarang, "NoUrutKendaraan", "NamaBarang");

            var NamaBidangPekerjaan1 = await _mediator.Send(new GetNamaBidangPekerjaanQuery());
            var NamaBidangUsaha1 = await _mediator.Send(new GetNamaBidangUsahaQuery());
            ViewData["NamaBidangPekerjaan1"] = new SelectList(NamaBidangPekerjaan1, "NoUrutBidangPekerjaan", "NamaMasterBidangPekerjaan");
            ViewData["NamaBidangUsaha1"] = new SelectList(NamaBidangUsaha1, "NoKodeMasterBidangUsaha", "NamaMasterBidangUsaha");

        }
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            var xx = DataKonstrakSurvei.ToCommand();
            await _mediator.Send(xx);



           // return RedirectToPage("./DataAvalist/CreateDataKontrakKredit");
               return RedirectToPage("./CreateDataKontrakKredit");
            // return RedirectToPage();
        }

    }
}
