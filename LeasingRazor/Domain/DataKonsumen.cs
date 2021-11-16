using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Domain
{
    public class DataKonsumen
    {
        public static DataKonsumen CreateDataKonsumen( string noRegisterKonsumen, DateTime? tanggalRegister,
            string namaKonsumen, string alamatTinggalK, string kelurahanK, string kecamatanK, string kotaK,
            string propinsiK, string kodePosTinggalK, string telpRumah, string noHandphone, string noHandphone2,
            string noKTP, string tempatLahir, DateTime? tanggallahir, DateTime? tanggalExpireKTP,
            string alamatKTP, string kelurahanKTP, string kecamatanKTP, string kotaKTP, string propinsiKTP,
            string kodePosKTP, string jenisKelamin, string statusNikah, string agama, string tingkatPendidikan,
            string email, string kodePekerjaan, string namaPekerjaan, string jabatanPerusahaan, string namaKantor,
            string alamatKantor, string kelurahanKantor, string kecamatanKantor, string kotaKantor,
            string propinsiKantor, string kodePosKantor, string telpKantor, string faxKantor, string namaUsaha,
            string alamatUsaha, string kelurahanUsaha, string kecamatanUsaha, string kotaUsaha, string propinsiUsaha,
            string kodePosUsaha, string telpUsaha, string faxUsaha, string noNpwpusaha, string noSiupusaha,
            string noTDPusaha, DateTime? tanggalMulaiUsaha, string jumlahKaryawan, string skalaUsaha,
            string kodeBidangUsaha, string namaBidangUsaha, string alamatSurat, string kelurahanSurat,
            string kecamatanSurat, string kotaSurat, string propinsiSurat, string kodePosSurat,
            string namaIbuKandung, string kodePekerjaanIbuKandung, string namaPekerjaanIbuKandung,
            string kodeBidangUsahaIbuKandung, string namaBidangUsahaIbuKandung, string namaPenjamin,
            string alamatPenjamin, string kelurahanPenjamin, string kecamatanPenjamin, string kotaPenjamin,
            string propinsiPenjamin, string kodePosPenjamin, string telpRumahPenjamin, string noHandphonePenjamin,
            string noHandphonePenjamin2, string noKTPPenjamin, string tempatLahirPenjamin,
            DateTime? tanggalLahirPenjamin, DateTime? tanggalExpireKTPPenjamin, string alamatKtpPenjamin,
            string kelurahanKtpPenjamin, string kecamatanKtpPenjamin, string kotaKtpPenjamin,
            string propinsiKtpPenjamin, string kodePosKTPPenjamin, string jenisKelaminPenjamin, string statusNikahPenjamin, string agamaPenjamin, string emailPenjamin, string kodeBidangUsahaPenjamin, string namaBidangUsahaPenjamin, string kodePekerjaanPenjamin, string namaPekerjaanPenjamin, string tingkatPendidikanPenjamin, string hubunganPenjamin, string namaKantorPenjamin, string alamatKantorPenjamin, string kelurahanKantorPenjamin, string kecamatanKantorPenjamin, string kotaKantorPenjamin, string propinsiKantorPenjamin, string kodePosKantorPenjamin, string telpKantorPenjamin, string faxKantorPenjamin, string namaUsahaPenjamin, string alamatUsahaPenjamin, string kelurahanUsahaPenjamin, string kecamatanUsahaPenjamin, string kotaUsahaPenjamin, string propinsiUsahaPenjamin, string kodePosUsahaPenjamin, string telpUsahaPenjamin, string faxUsahaPenjamin, string noNPWPUsahaPenjamin, string noSIUPusahaPenjamin, string noTDPUsahaPenjamin, string jmlKaryawanPenjamin, string skalaUsahaPenjamin)
        {
            return new DataKonsumen(     noRegisterKonsumen,     tanggalRegister,
              namaKonsumen,   alamatTinggalK,   kelurahanK,   kecamatanK,   kotaK,
              propinsiK,   kodePosTinggalK,   telpRumah,   noHandphone,   noHandphone2,
              noKTP,   tempatLahir,     tanggallahir,     tanggalExpireKTP,
              alamatKTP,   kelurahanKTP,   kecamatanKTP,   kotaKTP,   propinsiKTP,
              kodePosKTP,   jenisKelamin,   statusNikah,   agama,   tingkatPendidikan,
              email,   kodePekerjaan,   namaPekerjaan,   jabatanPerusahaan,   namaKantor,
              alamatKantor,   kelurahanKantor,   kecamatanKantor,   kotaKantor,
              propinsiKantor,   kodePosKantor,   telpKantor,   faxKantor,   namaUsaha,
              alamatUsaha,   kelurahanUsaha,   kecamatanUsaha,   kotaUsaha,   propinsiUsaha,
              kodePosUsaha,   telpUsaha,   faxUsaha,   noNpwpusaha,   noSiupusaha,
              noTDPusaha,     tanggalMulaiUsaha,   jumlahKaryawan,   skalaUsaha,
              kodeBidangUsaha,   namaBidangUsaha,   alamatSurat,   kelurahanSurat,
              kecamatanSurat,   kotaSurat,   propinsiSurat,   kodePosSurat,
              namaIbuKandung,   kodePekerjaanIbuKandung,   namaPekerjaanIbuKandung,
              kodeBidangUsahaIbuKandung,   namaBidangUsahaIbuKandung,   namaPenjamin,
              alamatPenjamin,   kelurahanPenjamin,   kecamatanPenjamin,   kotaPenjamin,
              propinsiPenjamin,   kodePosPenjamin,   telpRumahPenjamin,   noHandphonePenjamin,
              noHandphonePenjamin2,   noKTPPenjamin,   tempatLahirPenjamin,
                tanggalLahirPenjamin,     tanggalExpireKTPPenjamin,   alamatKtpPenjamin,
              kelurahanKtpPenjamin,   kecamatanKtpPenjamin,   kotaKtpPenjamin,
              propinsiKtpPenjamin,   kodePosKTPPenjamin,   jenisKelaminPenjamin,   statusNikahPenjamin,   agamaPenjamin,   emailPenjamin,   kodeBidangUsahaPenjamin,   namaBidangUsahaPenjamin,   kodePekerjaanPenjamin,   namaPekerjaanPenjamin,   tingkatPendidikanPenjamin,   hubunganPenjamin,   namaKantorPenjamin,   alamatKantorPenjamin,   kelurahanKantorPenjamin,   kecamatanKantorPenjamin,   kotaKantorPenjamin,   propinsiKantorPenjamin,   kodePosKantorPenjamin,   telpKantorPenjamin,   faxKantorPenjamin,   namaUsahaPenjamin,   alamatUsahaPenjamin,   kelurahanUsahaPenjamin,   kecamatanUsahaPenjamin,   kotaUsahaPenjamin,   propinsiUsahaPenjamin,   kodePosUsahaPenjamin,   telpUsahaPenjamin,   faxUsahaPenjamin,   noNPWPUsahaPenjamin,   noSIUPusahaPenjamin,   noTDPUsahaPenjamin,   jmlKaryawanPenjamin,   skalaUsahaPenjamin);
        }
        private DataKonsumen( string noRegisterKonsumen, DateTime? tanggalRegister,
            string namaKonsumen, string alamatTinggalK, string kelurahanK, string kecamatanK, string kotaK,
            string propinsiK, string kodePosTinggalK, string telpRumah, string noHandphone, string noHandphone2,
            string noKTP, string tempatLahir, DateTime? tanggallahir, DateTime? tanggalExpireKTP, 
            string alamatKTP, string kelurahanKTP, string kecamatanKTP, string kotaKTP, string propinsiKTP,
            string kodePosKTP, string jenisKelamin, string statusNikah, string agama, string tingkatPendidikan, 
            string email, string kodePekerjaan, string namaPekerjaan, string jabatanPerusahaan, string namaKantor,
            string alamatKantor, string kelurahanKantor, string kecamatanKantor, string kotaKantor, 
            string propinsiKantor, string kodePosKantor, string telpKantor, string faxKantor, string namaUsaha,
            string alamatUsaha, string kelurahanUsaha, string kecamatanUsaha, string kotaUsaha, string propinsiUsaha,
            string kodePosUsaha, string telpUsaha, string faxUsaha, string noNpwpusaha, string noSiupusaha,
            string noTDPusaha, DateTime? tanggalMulaiUsaha, string jumlahKaryawan, string skalaUsaha, 
            string kodeBidangUsaha, string namaBidangUsaha, string alamatSurat, string kelurahanSurat,
            string kecamatanSurat, string kotaSurat, string propinsiSurat, string kodePosSurat, 
            string namaIbuKandung, string kodePekerjaanIbuKandung, string namaPekerjaanIbuKandung,
            string kodeBidangUsahaIbuKandung, string namaBidangUsahaIbuKandung, string namaPenjamin, 
            string alamatPenjamin, string kelurahanPenjamin, string kecamatanPenjamin, string kotaPenjamin,
            string propinsiPenjamin, string kodePosPenjamin, string telpRumahPenjamin, string noHandphonePenjamin,
            string noHandphonePenjamin2, string noKTPPenjamin, string tempatLahirPenjamin, 
            DateTime? tanggalLahirPenjamin, DateTime? tanggalExpireKTPPenjamin, string alamatKtpPenjamin, 
            string kelurahanKtpPenjamin, string kecamatanKtpPenjamin, string kotaKtpPenjamin, 
            string propinsiKtpPenjamin, string kodePosKTPPenjamin, string jenisKelaminPenjamin, string statusNikahPenjamin, string agamaPenjamin, string emailPenjamin, string kodeBidangUsahaPenjamin, string namaBidangUsahaPenjamin, string kodePekerjaanPenjamin, string namaPekerjaanPenjamin, string tingkatPendidikanPenjamin, string hubunganPenjamin, string namaKantorPenjamin, string alamatKantorPenjamin, string kelurahanKantorPenjamin, string kecamatanKantorPenjamin, string kotaKantorPenjamin, string propinsiKantorPenjamin, string kodePosKantorPenjamin, string telpKantorPenjamin, string faxKantorPenjamin, string namaUsahaPenjamin, string alamatUsahaPenjamin, string kelurahanUsahaPenjamin, string kecamatanUsahaPenjamin, string kotaUsahaPenjamin, string propinsiUsahaPenjamin, string kodePosUsahaPenjamin, string telpUsahaPenjamin, string faxUsahaPenjamin, string noNPWPUsahaPenjamin, string noSIUPusahaPenjamin, string noTDPUsahaPenjamin, string jmlKaryawanPenjamin, string skalaUsahaPenjamin)
        {
            DataKonsumenId=Guid.NewGuid();
            NoRegisterKonsumen=noRegisterKonsumen;
            TanggalRegister=tanggalRegister;
            NamaKonsumen=namaKonsumen;
            AlamatTinggalK=alamatTinggalK;
            KelurahanK=kelurahanK;
            KecamatanK=kecamatanK;
            KotaK=kotaK;
            PropinsiK=propinsiK;
            KodePosTinggalK=kodePosTinggalK;
            TelpRumah=telpRumah;
            NoHandphone=noHandphone;
            NoHandphone2=noHandphone2;
            NoKTP=noKTP;
            TempatLahir=tempatLahir;
            Tanggallahir=tanggallahir;
            TanggalExpireKTP=tanggalExpireKTP;
            AlamatKTP=alamatKTP;
            KelurahanKTP=kelurahanKTP;
            KecamatanKTP=kecamatanKTP;
            KotaKTP=kotaKTP;
            PropinsiKTP=propinsiKTP;
            KodePosKTP=kodePosKTP;
            JenisKelamin=jenisKelamin;
            StatusNikah=statusNikah;
            Agama=agama;
            TingkatPendidikan=tingkatPendidikan;
            Email=email;
            KodePekerjaan=kodePekerjaan;
            NamaPekerjaan=namaPekerjaan;
            JabatanPerusahaan=jabatanPerusahaan;
            NamaKantor=namaKantor;
            AlamatKantor=alamatKantor;
            KelurahanKantor=kelurahanKantor;
            KecamatanKantor=kecamatanKantor;
            KotaKantor=kotaKantor;
            PropinsiKantor=propinsiKantor;
            KodePosKantor=kodePosKantor;
            TelpKantor=telpKantor;
            FaxKantor=faxKantor;
            NamaUsaha=namaUsaha;
            AlamatUsaha=alamatUsaha;
            KelurahanUsaha=kelurahanUsaha;
            KecamatanUsaha=kecamatanUsaha;
            KotaUsaha=kotaUsaha;
            PropinsiUsaha=propinsiUsaha;
            KodePosUsaha=kodePosUsaha;
            TelpUsaha=telpUsaha;
            FaxUsaha=faxUsaha;
            NoNpwpusaha=noNpwpusaha;
            NoSiupusaha=noSiupusaha;
            NoTDPusaha=noTDPusaha;
            TanggalMulaiUsaha=tanggalMulaiUsaha;
            JumlahKaryawan=jumlahKaryawan;
            SkalaUsaha=skalaUsaha;
            KodeBidangUsaha=kodeBidangUsaha;
            NamaBidangUsaha=namaBidangUsaha;
            AlamatSurat=alamatSurat;
            KelurahanSurat=kelurahanSurat;
            KecamatanSurat=kecamatanSurat;
            KotaSurat=kotaSurat;
            PropinsiSurat=propinsiSurat;
            KodePosSurat=kodePosSurat;
            NamaIbuKandung=namaIbuKandung;
            KodePekerjaanIbuKandung=kodePekerjaanIbuKandung;
            NamaPekerjaanIbuKandung=namaPekerjaanIbuKandung;
            KodeBidangUsahaIbuKandung=kodeBidangUsahaIbuKandung;
            NamaBidangUsahaIbuKandung=namaBidangUsahaIbuKandung;
            NamaPenjamin=namaPenjamin;
            AlamatPenjamin=alamatPenjamin;
            KelurahanPenjamin=kelurahanPenjamin;
            KecamatanPenjamin=kecamatanPenjamin;
            KotaPenjamin=kotaPenjamin;
            PropinsiPenjamin=propinsiPenjamin;
            KodePosPenjamin=kodePosPenjamin;
            TelpRumahPenjamin=telpRumahPenjamin;
            NoHandphonePenjamin=noHandphonePenjamin;
            NoHandphonePenjamin2=noHandphonePenjamin2;
            NoKTPPenjamin=noKTPPenjamin;
            TempatLahirPenjamin=tempatLahirPenjamin;
            TanggalLahirPenjamin=tanggalLahirPenjamin;
            TanggalExpireKTPPenjamin=tanggalExpireKTPPenjamin;
            AlamatKtpPenjamin=alamatKtpPenjamin;
            KelurahanKtpPenjamin=kelurahanKtpPenjamin;
            KecamatanKtpPenjamin=kecamatanKtpPenjamin;
            KotaKtpPenjamin=kotaKtpPenjamin;
            PropinsiKtpPenjamin=propinsiKtpPenjamin;
            KodePosKTPPenjamin=kodePosKTPPenjamin;
            JenisKelaminPenjamin=jenisKelaminPenjamin;
            StatusNikahPenjamin=statusNikahPenjamin;
            AgamaPenjamin=agamaPenjamin;
            EmailPenjamin=emailPenjamin;
            KodeBidangUsahaPenjamin=kodeBidangUsahaPenjamin;
            NamaBidangUsahaPenjamin=namaBidangUsahaPenjamin;
            KodePekerjaanPenjamin=kodePekerjaanPenjamin;
            NamaPekerjaanPenjamin=namaPekerjaanPenjamin;
            TingkatPendidikanPenjamin=tingkatPendidikanPenjamin;
            HubunganPenjamin=hubunganPenjamin;
            NamaKantorPenjamin=namaKantorPenjamin;
            AlamatKantorPenjamin=alamatKantorPenjamin;
            KelurahanKantorPenjamin=kelurahanKantorPenjamin;
            KecamatanKantorPenjamin=kecamatanKantorPenjamin;
            KotaKantorPenjamin=kotaKantorPenjamin;
            PropinsiKantorPenjamin=propinsiKantorPenjamin;
            KodePosKantorPenjamin=kodePosKantorPenjamin;
            TelpKantorPenjamin=telpKantorPenjamin;
            FaxKantorPenjamin=faxKantorPenjamin;
            NamaUsahaPenjamin=namaUsahaPenjamin;
            AlamatUsahaPenjamin=alamatUsahaPenjamin;
            KelurahanUsahaPenjamin=kelurahanUsahaPenjamin;
            KecamatanUsahaPenjamin=kecamatanUsahaPenjamin;
            KotaUsahaPenjamin=kotaUsahaPenjamin;
            PropinsiUsahaPenjamin=propinsiUsahaPenjamin;
            KodePosUsahaPenjamin=kodePosUsahaPenjamin;
            TelpUsahaPenjamin=telpUsahaPenjamin;
            FaxUsahaPenjamin=faxUsahaPenjamin;
            NoNPWPUsahaPenjamin=noNPWPUsahaPenjamin;
            NoSIUPusahaPenjamin=noSIUPusahaPenjamin;
            NoTDPUsahaPenjamin=noTDPUsahaPenjamin;
            JmlKaryawanPenjamin=jmlKaryawanPenjamin;
            SkalaUsahaPenjamin=skalaUsahaPenjamin;
        }

        public int NoUrutId { get; set; }
        public Guid DataKonsumenId { get; private set; }
      
        public string NoRegisterKonsumen { get; private set; }
        public DateTime? TanggalRegister { get; private set; }
        public string NamaKonsumen { get; private set; }
        public string AlamatTinggalK { get; private set; }
        public string KelurahanK { get; private set; }
        public string KecamatanK { get; private set; }
        public string KotaK { get; private set; }
        public string PropinsiK { get; private set; }
        public string KodePosTinggalK { get; private set; }
        public string TelpRumah { get; private set; }
        public string NoHandphone { get; private set; }
        public string NoHandphone2 { get; private set; }
        public string NoKTP { get; private set; }
        public string TempatLahir { get; private set; }
        public DateTime? Tanggallahir { get; private set; }
        public DateTime? TanggalExpireKTP { get; private set; }
        public string AlamatKTP { get; private set; }
        public string KelurahanKTP { get; private set; }
        public string KecamatanKTP { get; private set; }
        public string KotaKTP { get; private set; }
        public string PropinsiKTP { get; private set; }
        public string KodePosKTP { get; private set; }
        public string JenisKelamin { get; private set; }
        public string StatusNikah { get; private set; }
        public string Agama { get; private set; }
        public string TingkatPendidikan { get; private set; }
        public string Email { get; private set; }

        public string KodePekerjaan { get; private set; }
        public string NamaPekerjaan { get; private set; }
        public string JabatanPerusahaan { get; private set; }
        public string NamaKantor { get; private set; }
        public string AlamatKantor { get; private set; }
        public string KelurahanKantor { get; private set; }
        public string KecamatanKantor { get; private set; }
        public string KotaKantor { get; private set; }
        public string PropinsiKantor { get; private set; }

        public string KodePosKantor { get; private set; }
        public string TelpKantor { get; private set; }
        public string FaxKantor { get; private set; }
        public string NamaUsaha { get; private set; }
        public string AlamatUsaha { get; private set; }
        public string KelurahanUsaha { get; private set; }
        public string KecamatanUsaha { get; private set; }
        public string KotaUsaha { get; private set; }
        public string PropinsiUsaha { get; private set; }
        public string KodePosUsaha { get; private set; }
        public string TelpUsaha { get; private set; }
        public string FaxUsaha { get; private set; }
        public string NoNpwpusaha { get; private set; }
        public string NoSiupusaha { get; private set; }
        public string NoTDPusaha { get; private set; }
        public DateTime? TanggalMulaiUsaha { get; private set; }
        public string JumlahKaryawan { get; private set; }
        public string SkalaUsaha { get; private set; }
        public string KodeBidangUsaha { get; private set; }
        public string NamaBidangUsaha { get; private set; }
        public string AlamatSurat { get; private set; }
        public string KelurahanSurat { get; private set; }
        public string KecamatanSurat { get; private set; }
        public string KotaSurat { get; private set; }
        public string PropinsiSurat { get; private set; }
        public string KodePosSurat { get; private set; }
        public string NamaIbuKandung { get; private set; }
        public string KodePekerjaanIbuKandung { get; private set; }
        public string NamaPekerjaanIbuKandung { get; private set; }
        public string KodeBidangUsahaIbuKandung { get; private set; }
        public string NamaBidangUsahaIbuKandung { get; private set; }
        public string NamaPenjamin { get; private set; }
        public string AlamatPenjamin { get; private set; }
        public string KelurahanPenjamin { get; private set; }
        public string KecamatanPenjamin { get; private set; }
        public string KotaPenjamin { get; private set; }
        public string PropinsiPenjamin { get; private set; }
        public string KodePosPenjamin { get; private set; }
        public string TelpRumahPenjamin { get; private set; }
        public string NoHandphonePenjamin { get; private set; }
        public string NoHandphonePenjamin2 { get; private set; }
        public string NoKTPPenjamin { get; private set; }
        public string TempatLahirPenjamin { get; private set; }
        public DateTime? TanggalLahirPenjamin { get; private set; }
        public DateTime? TanggalExpireKTPPenjamin { get; private set; }
        public string AlamatKtpPenjamin { get; private set; }
        public string KelurahanKtpPenjamin { get; private set; }
        public string KecamatanKtpPenjamin { get; private set; }
        public string KotaKtpPenjamin { get; private set; }
        public string PropinsiKtpPenjamin { get; private set; }
        public string KodePosKTPPenjamin { get; private set; }
        public string JenisKelaminPenjamin { get; private set; }
        public string StatusNikahPenjamin { get; private set; }
        public string AgamaPenjamin { get; private set; }
        public string EmailPenjamin { get; private set; }
        public string KodeBidangUsahaPenjamin { get; private set; }
        public string NamaBidangUsahaPenjamin { get; private set; }
        public string KodePekerjaanPenjamin { get; private set; }
        public string NamaPekerjaanPenjamin { get; private set; }
        public string TingkatPendidikanPenjamin { get; private set; }
        public string HubunganPenjamin { get; private set; }
        public string NamaKantorPenjamin { get; private set; }
        public string AlamatKantorPenjamin { get; private set; }
        public string KelurahanKantorPenjamin { get; private set; }
        public string KecamatanKantorPenjamin { get; private set; }
        public string KotaKantorPenjamin { get; private set; }
        public string PropinsiKantorPenjamin { get; private set; }
        public string KodePosKantorPenjamin { get; private set; }
        public string TelpKantorPenjamin { get; private set; }
        public string FaxKantorPenjamin { get; private set; }
        public string NamaUsahaPenjamin { get; private set; }
        public string AlamatUsahaPenjamin { get; private set; }
        public string KelurahanUsahaPenjamin { get; private set; }
        public string KecamatanUsahaPenjamin { get; private set; }
        public string KotaUsahaPenjamin { get; private set; }
        public string PropinsiUsahaPenjamin { get; private set; }
        public string KodePosUsahaPenjamin { get; private set; }
        public string TelpUsahaPenjamin { get; private set; }
        public string FaxUsahaPenjamin { get; private set; }
        public string NoNPWPUsahaPenjamin { get; private set; }
        public string NoSIUPusahaPenjamin { get; private set; }
        public string NoTDPUsahaPenjamin { get; private set; }
        public string JmlKaryawanPenjamin { get; private set; }
        public string SkalaUsahaPenjamin { get; private set; }
    }
}
