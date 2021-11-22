using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Dto.DataKonsumen
{
    public class CreateDataKonsumenRequest
    {
        public int NoUrutKonsumen { get; set; }
        //[Display(Name = "No Register Konsumen")]
        //public string NoRegisterKonsumen { get; set; }
        public DateTime? TanggalRegister { get; set; }
        public string NamaKonsumen { get; set; }
        public string AlamatTinggalK { get; set; }
        public string KelurahanK { get; set; }
        public string KecamatanK { get; set; }
        public string KotaK { get; set; }
        public string PropinsiK { get; set; }
        public string KodePosTinggalK { get; set; }
        public string TelpRumah { get; set; }
        public string NoHandphone { get; set; }
        public string NoHandphone2 { get; set; }
        public string NoKTP { get; set; }
        public string TempatLahir { get; set; }
        public DateTime? Tanggallahir { get; set; }
        public DateTime? TanggalExpireKTP { get; set; }
        public string AlamatKTP { get; set; }
        public string KelurahanKTP { get; set; }
        public string KecamatanKTP { get; set; }
        public string KotaKTP { get; set; }
        public string PropinsiKTP { get; set; }
        public string KodePosKTP { get; set; }
        public string JenisKelamin { get; set; }
        public string StatusNikah { get; set; }
        public string Agama { get; set; }
        public string TingkatPendidikan { get; set; }
        public string Email { get; set; }

        public string KodePekerjaan { get; set; }
        public string NamaPekerjaan { get; set; }
        public string JabatanPerusahaan { get; set; }
        public string NamaKantor { get; set; }
        public string AlamatKantor { get; set; }
        public string KelurahanKantor { get; set; }
        public string KecamatanKantor { get; set; }
        public string KotaKantor { get; set; }
        public string PropinsiKantor { get; set; }

        public string KodePosKantor { get; set; }
        public string TelpKantor { get; set; }
        public string FaxKantor { get; set; }
        public string NamaUsaha { get; set; }
        public string AlamatUsaha { get; set; }
        public string KelurahanUsaha { get; set; }
        public string KecamatanUsaha { get; set; }
        public string KotaUsaha { get; set; }
        public string PropinsiUsaha { get; set; }
        public string KodePosUsaha { get; set; }
        public string TelpUsaha { get; set; }
        public string FaxUsaha { get; set; }
        public string NoNpwpusaha { get; set; }
        public string NoSiupusaha { get; set; }
        public string NoTDPusaha { get; set; }
        public DateTime? TanggalMulaiUsaha { get; set; }
        public string JumlahKaryawan { get; set; }
        public string SkalaUsaha { get; set; }
        public string KodeBidangUsaha { get; set; }
        public string NamaBidangUsaha { get; set; }
        public string AlamatSurat { get; set; }
        public string KelurahanSurat { get; set; }
        public string KecamatanSurat { get; set; }
        public string KotaSurat { get; set; }
        public string PropinsiSurat { get; set; }
        public string KodePosSurat { get; set; }
        public string NamaIbuKandung { get; set; }
        public string KodePekerjaanIbuKandung { get; set; }
        public string NamaPekerjaanIbuKandung { get; set; }
        public string KodeBidangUsahaIbuKandung { get; set; }
        public string NamaBidangUsahaIbuKandung { get; set; }
        public string NamaPenjamin { get; set; }
        public string AlamatPenjamin { get; set; }
        public string KelurahanPenjamin { get; set; }
        public string KecamatanPenjamin { get; set; }
        public string KotaPenjamin { get; set; }
        public string PropinsiPenjamin { get; set; }
        public string KodePosPenjamin { get; set; }
        public string TelpRumahPenjamin { get; set; }
        public string NoHandphonePenjamin { get; set; }
        public string NoHandphonePenjamin2 { get; set; }
        public string NoKTPPenjamin { get; set; }
        public string TempatLahirPenjamin { get; set; }
        public DateTime? TanggalLahirPenjamin { get; set; }
        public DateTime? TanggalExpireKTPPenjamin { get; set; }
        public string AlamatKtpPenjamin { get; set; }
        public string KelurahanKtpPenjamin { get; set; }
        public string KecamatanKtpPenjamin { get; set; }
        public string KotaKtpPenjamin { get; set; }
        public string PropinsiKtpPenjamin { get; set; }
        public string KodePosKTPPenjamin { get; set; }
        public string JenisKelaminPenjamin { get; set; }
        public string StatusNikahPenjamin { get; set; }
        public string AgamaPenjamin { get; set; }
        public string EmailPenjamin { get; set; }
        public string KodeBidangUsahaPenjamin { get; set; }
        public string NamaBidangUsahaPenjamin { get; set; }
        public string KodePekerjaanPenjamin { get; set; }
        public string NamaPekerjaanPenjamin { get; set; }
        public string TingkatPendidikanPenjamin { get; set; }
        public string HubunganPenjamin { get; set; }
        public string NamaKantorPenjamin { get; set; }
        public string AlamatKantorPenjamin { get; set; }
        public string KelurahanKantorPenjamin { get; set; }
        public string KecamatanKantorPenjamin { get; set; }
        public string KotaKantorPenjamin { get; set; }
        public string PropinsiKantorPenjamin { get; set; }
        public string KodePosKantorPenjamin { get; set; }
        public string TelpKantorPenjamin { get; set; }
        public string FaxKantorPenjamin { get; set; }
        public string NamaUsahaPenjamin { get; set; }
        public string AlamatUsahaPenjamin { get; set; }
        public string KelurahanUsahaPenjamin { get; set; }
        public string KecamatanUsahaPenjamin { get; set; }
        public string KotaUsahaPenjamin { get; set; }
        public string PropinsiUsahaPenjamin { get; set; }
        public string KodePosUsahaPenjamin { get; set; }
        public string TelpUsahaPenjamin { get; set; }
        public string FaxUsahaPenjamin { get; set; }
        public string NoNPWPUsahaPenjamin { get; set; }
        public string NoSIUPusahaPenjamin { get; set; }
        public string NoTDPUsahaPenjamin { get; set; }
        public string JmlKaryawanPenjamin { get; set; }
        public string SkalaUsahaPenjamin { get; set; }
    }
}
