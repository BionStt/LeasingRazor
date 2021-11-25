using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LeasingRazor.Dto.DataKontrakSurvei
{
    public class DataKontrakSurveiRequest
    {

        [Display(Name = "Alamat ")]//, Prompt = "Masukkan nama konsumen")]
        public string AlamatMendesak { get;  set; }
        [Display(Name = "Atap Rumah")]
        public string AtapRumah { get;  set; }
        [Display(Name = "Daya listrik Rumah")]
        public string DayaListrikRumah { get;  set; }
        [Display(Name = "Dinding Rumah")]
        public string DindingRumah { get;  set; }
        [Display(Name = "Fasilitas kredit bank")]
        public string FasilitasKreditBank { get;  set; }
        [Display(Name = "garasin Rumah")]
        public string GarasiRumah { get;  set; }
        [Display(Name = "Handphone Mendesak")]
        public string HandphoneMendesak { get;  set; }
        [Display(Name = "Handphone Mendesak")]
        public string HandphoneMendesak2 { get;  set; }
        [Display(Name = "Hasil Survei")]
        public string HasilSurvei { get;  set; }
        [Display(Name = "Hubungan dengan orang yang dapat dihubungi ketika mendesak")]
        public string HubunganDenganMendesak { get;  set; }
        [Display(Name = "Jenis fasilitas bank")]
        public string JenisFasilitasbank { get;  set; }
        [Display(Name = "Kapasitas garasi rumah")]
        public int? KapasitasGarasiRumah { get;  set; }
        [Display(Name = "Karakter")]
        public string Karakter { get;  set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanMendesak { get;  set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanMendesak { get;  set; }
        [Display(Name = "Kerjasama")]
        public string Kerjasama { get;  set; }
        [Display(Name = "Keterangan lain")]
        public string KeteranganLain { get;  set; }
        [Display(Name = "Kode Bidang Pekerjaan")]
        public string KodeBidangPekerjaan { get;  set; }
        [Display(Name = "Kode Bidang Usaha")]
        public string KodeBidangUsaha { get;  set; }
        [Display(Name = "Kode Pos")]
        public string KodePosMendesak { get;  set; }
        [Display(Name = "Kondisi Fisik Rumah")]
        public string KondisiFisikRumah { get;  set; }
        [Display(Name = "Kondisi jalan rumah")]
        public string KondisiJalanRumah { get;  set; }
        [Display(Name = "Kota")]
        public string KotaMendesak { get;  set; }
        [Display(Name = "Kulkas")]
        public string Kulkas { get;  set; }
        [Display(Name = "Lantai rumah")]
        public string LantaiRumah { get;  set; }
        [Display(Name = "Lokasi survei")]
        public string LokasiSurvei { get;  set; }
        [Display(Name = "Lokasi tempat tinggal")]
        public string LokasiTempatTinggal { get;  set; }
        [Display(Name = "Luas rumah")]
        public string LuasRumah { get;  set; }
        [Display(Name = "Luas tanah")]
        public string LuasTanah { get;  set; }
        [Display(Name = "Luas usaha")]
        public string LuasUsaha { get;  set; }
        [Display(Name = "Nama Bidang pekerjaan")]
        public string NamaBidangPekerjaan { get;  set; }
        [Display(Name = "Nama bidang usaha")]
        public string NamaBidangUsaha { get;  set; }
        [Display(Name = "orang yang bisa dihubungi dalam keadaan mendesak",Prompt ="Masukkan nama orang yang bisa dihubungi dalam keadaan mendesak")]
        public string NamaMendesak { get;  set; }
        [Display(Name = "Nama rekening bank")]
        public string NamaRekeningBank { get;  set; }
        [Display(Name = "Nomor registrasi")]
        public int NoRegistrasiKonsumen { get;  set; }
        [Display(Name = "Nomor Rekening bank")]
        public string NoRekeningBank { get;  set; }
        [Display(Name = "No Urut Data survbei")]
        public int NoUrutDataSurvei { get;  set; }
        [Display(Name = "Omzet bulanan")]
        public decimal? OmzetBulanan { get;  set; }
        [Display(Name = "Master Barang")]
        public int NoUrutMasterBarang { get;  set; }
        [Display(Name = "Pagar rumah")]
        public string PagarRumah { get;  set; }
        [Display(Name = "Pengeluaran tetap bulanan")]
        public decimal? PengeluaranTetapBulanan { get;  set; }
        [Display(Name = "Penghasilan")]
        public decimal? Penghasilan { get;  set; }
        [Display(Name = "Penghasilan lain")]
        public decimal? Penghasilanlain { get;  set; }
        [Display(Name = "Penghasilan Pasangan")]
        public decimal? PenghasilanPasangan { get;  set; }
        [Display(Name = "Pernah mengajukan kredit")]
        public string PernahKredit { get;  set; }
        [Display(Name = "Propinsi")]
        public string PropinsiMendesak { get;  set; }
        [Display(Name = "Segmen Rumah")]
        public string SegmenRumah { get;  set; }
        [Display(Name = "Status tempat tinggal")]
        public string StatusTempatTinggal { get;  set; }

        public string SurveiId { get;  set; }
        [Display(Name = "Tagihan PDAM")]
        public decimal? TagihanPDAM { get;  set; }
        [Display(Name = "Tagihan PLN")]
        public decimal? TagihanPLN { get;  set; }
        [Display(Name = "Tagihian Telp")]
        public decimal? TagihanTelp { get;  set; }
        [Display(Name = "Taman Rumah")]
        public string TamanRumah { get;  set; }
        [Display(Name = "Tanggungan")]
        public int? Tanggungan { get;  set; }
        [Display(Name = "Televisi Rumah")]
        public string TelevisiRumah { get;  set; }
        [Display(Name = "Telepon")]
        public string TelpMendesak { get;  set; }
        [Display(Name = "Tinggal sejak")]
        public int? TinggalSejak { get;  set; }
        [Display(Name = "Toilet rumah")]
        public string ToiletRumah { get;  set; }
    }
}
