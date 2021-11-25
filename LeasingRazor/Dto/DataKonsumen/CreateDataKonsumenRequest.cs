using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Tanggal Daftar")]
        public DateTime? TanggalRegister { get; set; }
        [Display(Name = "Nama Konsumen",Prompt ="Masukkan nama konsumen")]
        public string NamaKonsumen { get; set; }
        [Display(Name = "Alamat Tinggal")]
        public string AlamatTinggalK { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanK { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanK { get; set; }
        [Display(Name = "Kota")]
        public string KotaK { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiK { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePosTinggalK { get; set; }
        [Display(Name = "Telepon Rumah")]
        public string TelpRumah { get; set; }
        [Display(Name = "Nomor Handphone")]
        public string NoHandphone { get; set; }
        [Display(Name = "Nomor Handphone 2")]
        public string NoHandphone2 { get; set; }
        [Display(Name = "Nomor KTP")]
        public string NoKTP { get; set; }
        [Display(Name = "Tempat Lahir")]
        public string TempatLahir { get; set; }
        [Display(Name = "Tanggal Lahir")]
        public DateTime? Tanggallahir { get; set; }
        [Display(Name = "Tanggal Expire KTP")]
        public DateTime? TanggalExpireKTP { get; set; }
        [Display(Name = "Alamat KTP")]
        public string AlamatKTP { get; set; }
        [Display(Name = "Kelurahan KTP")]
        public string KelurahanKTP { get; set; }
        [Display(Name = "Kecamatan KTP")]
        public string KecamatanKTP { get; set; }
        [Display(Name = "Kota KTP")]
        public string KotaKTP { get; set; }
        [Display(Name = "Propinsi KTP")]
        public string PropinsiKTP { get; set; }
        [Display(Name = "Kode Pos KTP")]
        public string KodePosKTP { get; set; }
        [Display(Name = "Jenis Kelamin")]
        public string JenisKelamin { get; set; }
        [Display(Name = "Status Pernikahan")]
        public string StatusNikah { get; set; }
        public string Agama { get; set; }
        [Display(Name = "Tingkat Pendidikan")]
        public string TingkatPendidikan { get; set; }
        [Display(Name = "Email",Prompt ="Contoh: timurjaya@gmail.com")]
        public string Email { get; set; }

        [Display(Name = "Kode Bidang Pekerjaan")]
        public string KodePekerjaan { get; set; }
        [Display(Name = "Nama Bidang Pekerjaan")]
        public string NamaPekerjaan { get; set; }
        [Display(Name = "Jabatan di perusahaan")]
        public string JabatanPerusahaan { get; set; }
        [Display(Name = "Nama Kantor")]
        public string NamaKantor { get; set; }
        [Display(Name = "Alamat Kantor")]
        public string AlamatKantor { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanKantor { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanKantor { get; set; }
        [Display(Name = "Kota")]
        public string KotaKantor { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiKantor { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePosKantor { get; set; }
        [Display(Name = "Telepon")]
        public string TelpKantor { get; set; }
        [Display(Name = "Faks")]
        public string FaxKantor { get; set; }
        [Display(Name = "Nama Usaha")]
        public string NamaUsaha { get; set; }
        [Display(Name = "Alamat")]
        public string AlamatUsaha { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanUsaha { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanUsaha { get; set; }
        [Display(Name = "Kota")]
        public string KotaUsaha { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiUsaha { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePosUsaha { get; set; }
        [Display(Name = "Telepon")]
        public string TelpUsaha { get; set; }
        [Display(Name = "Faks")]
        public string FaxUsaha { get; set; }
        [Display(Name = "NPWP")]
        public string NoNpwpusaha { get; set; }
        [Display(Name = "SIUP")]
        public string NoSiupusaha { get; set; }
        [Display(Name = "No TDP")]
        public string NoTDPusaha { get; set; }
        [Display(Name = "Tanggal Mulai Usaha")]
        public DateTime? TanggalMulaiUsaha { get; set; }
        [Display(Name = "Jumlah Karyawan")]
        public string JumlahKaryawan { get; set; }
        [Display(Name = "Skala Usaha")]
        public string SkalaUsaha { get; set; }
        [Display(Name = "Kode Bidang Usaha")]
        public string KodeBidangUsaha { get; set; }
        [Display(Name = "Nama Bidang Usaha")]
        public string NamaBidangUsaha { get; set; }
        [Display(Name = "Alamat Surat menyurat")]
        public string AlamatSurat { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanSurat { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanSurat { get; set; }
        [Display(Name = "Kota")]
        public string KotaSurat { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiSurat { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePosSurat { get; set; }
        [Display(Name = "Nama Ibu Kandung")]
        public string NamaIbuKandung { get; set; }
        [Display(Name = "Kode Bidang Pekerjaan")]
        public string KodePekerjaanIbuKandung { get; set; }
        [Display(Name = "Nama Pekerjaan")]
        public string NamaPekerjaanIbuKandung { get; set; }
        [Display(Name = "KOde Bidang Usaha")]
        public string KodeBidangUsahaIbuKandung { get; set; }
        [Display(Name = "Nama Bidang Usaha")]
        public string NamaBidangUsahaIbuKandung { get; set; }
        [Display(Name = "Nama Penjamin")]
        public string NamaPenjamin { get; set; }
        [Display(Name = "Alamat Penjamin")]
        public string AlamatPenjamin { get; set; }
        [Display(Name = "Kelurahan Penjamin")]
        public string KelurahanPenjamin { get; set; }
        [Display(Name = "Kecamatan Penjamin")]
        public string KecamatanPenjamin { get; set; }
        [Display(Name = "Kota Penjamin")]
        public string KotaPenjamin { get; set; }
        [Display(Name = "Propinsi Penjamin")]
        public string PropinsiPenjamin { get; set; }
        [Display(Name = "Kode Pos Penjamin")]
        public string KodePosPenjamin { get; set; }
        [Display(Name = "Telepon")]
        public string TelpRumahPenjamin { get; set; }
        [Display(Name = "Nomor Handphone")]
        public string NoHandphonePenjamin { get; set; }
        [Display(Name = "Nomor Handphone")]
        public string NoHandphonePenjamin2 { get; set; }
        [Display(Name = "Nomor KTP")]
        public string NoKTPPenjamin { get; set; }
        [Display(Name = "Tempat Lahir")]
        public string TempatLahirPenjamin { get; set; }
        [Display(Name = "Tanggal Lahir")]
        public DateTime? TanggalLahirPenjamin { get; set; }
        [Display(Name = "Tanggal Expire KTP")]
        public DateTime? TanggalExpireKTPPenjamin { get; set; }
        [Display(Name = "Alamat KTP Penjamin")]
        public string AlamatKtpPenjamin { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanKtpPenjamin { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanKtpPenjamin { get; set; }
        [Display(Name = "Kota")]
        public string KotaKtpPenjamin { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiKtpPenjamin { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePosKTPPenjamin { get; set; }
        [Display(Name = "Jenis Kelamin")]
        public string JenisKelaminPenjamin { get; set; }
        [Display(Name = "Status Nikah")]
        public string StatusNikahPenjamin { get; set; }
        [Display(Name = "Agama")]
        public string AgamaPenjamin { get; set; }
        [Display(Name = "Email")]
        public string EmailPenjamin { get; set; }
        [Display(Name = "Kode Bidang Usaha")]
        public string KodeBidangUsahaPenjamin { get; set; }
        [Display(Name = "Nama Bidang Usaha")]
        public string NamaBidangUsahaPenjamin { get; set; }
        [Display(Name = "Kode Bidang Pekerjaan")]
        public string KodePekerjaanPenjamin { get; set; }
        [Display(Name = "Nama Bidang Pekerjaan")]
        public string NamaPekerjaanPenjamin { get; set; }
        [Display(Name = "Tingkat Pendidikan")]
        public string TingkatPendidikanPenjamin { get; set; }
        [Display(Name = "Hubungan dengan Penjamin")]
        public string HubunganPenjamin { get; set; }
        [Display(Name = "Nama Kantor Penjamin")]
        public string NamaKantorPenjamin { get; set; }
        [Display(Name = "Alamat Kantor")]
        public string AlamatKantorPenjamin { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanKantorPenjamin { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanKantorPenjamin { get; set; }
        [Display(Name = "Kota")]
        public string KotaKantorPenjamin { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiKantorPenjamin { get; set; }
        [Display(Name = "Kode Kantor Pos")]
        public string KodePosKantorPenjamin { get; set; }
        [Display(Name = "Telepon")]
        public string TelpKantorPenjamin { get; set; }
        [Display(Name = "Faks")]
        public string FaxKantorPenjamin { get; set; }
        [Display(Name = "Nama Usaha Penjamin")]
        public string NamaUsahaPenjamin { get; set; }
        [Display(Name = "Alamat Tempat Usaha")]
        public string AlamatUsahaPenjamin { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanUsahaPenjamin { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanUsahaPenjamin { get; set; }
        [Display(Name = "Kota")]
        public string KotaUsahaPenjamin { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiUsahaPenjamin { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePosUsahaPenjamin { get; set; }
        [Display(Name = "Telepon")]
        public string TelpUsahaPenjamin { get; set; }
        [Display(Name = "Faks")]
        public string FaxUsahaPenjamin { get; set; }
        [Display(Name = "NPWP")]
        public string NoNPWPUsahaPenjamin { get; set; }
        [Display(Name = "SIUP")]
        public string NoSIUPusahaPenjamin { get; set; }
        [Display(Name = "No TDP")]
        public string NoTDPUsahaPenjamin { get; set; }
        [Display(Name = "Jumlah Karyawan")]
        public string JmlKaryawanPenjamin { get; set; }
        [Display(Name = "Skala Usaha")]
        public string SkalaUsahaPenjamin { get; set; }
    }
}
