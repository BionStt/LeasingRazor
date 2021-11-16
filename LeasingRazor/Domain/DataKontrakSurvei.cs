using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Domain
{
    public class DataKontrakSurvei
    {
        public static DataKontrakSurvei CreateDataKontrakSurvei(string noRegistrasiDataSurvei, DateTime? tanggalSurvei, Guid dataKonsumenAvalistId, string karakter, string kerjasama, decimal? penghasilan, decimal? penghasilanlain, decimal? penghasilanPasangan, decimal? pengeluaranTetapBulanan, int? tanggungan, string statusTempatTinggal, int? tinggalSejak, string hasilSurvei, Guid kodeBidangPekerjaan, string namaBidangPekerjaan, Guid kodeBidangUsaha, string namaBidangUsaha, decimal? omzetBulanan, string pernahKredit, Guid masterBarangDBId, string fasilitasKreditBank, string jenisFasilitasbank, string namaRekeningBank, string noRekeningBank, string luasRumah, string luasTanah, string luasUsaha, string dayaListrikRumah, decimal? tagihanPLN, decimal? tagihanTelp, decimal? tagihanPDAM, string kondisiFisikRumah, string segmenRumah, string kondisiJalanRumah, string pagarRumah, string tamanRumah, string garasiRumah, int? kapasitasGarasiRumah, string dindingRumah, string atapRumah, string lantaiRumah, string toiletRumah, string televisiRumah, string kulkas, string lokasiSurvei, string lokasiTempatTinggal, string namaMendesak, string alamatMendesak, string kelurahanMendesak, string kecamatanMendesak, string kotaMendesak, string propinsiMendesak, string kodePosMendesak, string telpMendesak, string handphoneMendesak, string handphoneMendesak2, string hubunganDenganMendesak, string surveiId, string keteranganLain)
        {
            return new DataKontrakSurvei( noRegistrasiDataSurvei,   tanggalSurvei,  dataKonsumenAvalistId,  karakter,  kerjasama,   penghasilan,   penghasilanlain,   penghasilanPasangan,   pengeluaranTetapBulanan,   tanggungan,  statusTempatTinggal,   tinggalSejak,  hasilSurvei,  kodeBidangPekerjaan,  namaBidangPekerjaan,  kodeBidangUsaha,  namaBidangUsaha,   omzetBulanan,  pernahKredit,  masterBarangDBId,  fasilitasKreditBank,  jenisFasilitasbank,  namaRekeningBank,  noRekeningBank,  luasRumah,  luasTanah,  luasUsaha,  dayaListrikRumah,   tagihanPLN,   tagihanTelp,   tagihanPDAM,  kondisiFisikRumah,  segmenRumah,  kondisiJalanRumah,  pagarRumah,  tamanRumah,  garasiRumah,   kapasitasGarasiRumah,  dindingRumah,  atapRumah,  lantaiRumah,  toiletRumah,  televisiRumah,  kulkas,  lokasiSurvei,  lokasiTempatTinggal,  namaMendesak,  alamatMendesak,  kelurahanMendesak,  kecamatanMendesak,  kotaMendesak,  propinsiMendesak,  kodePosMendesak,  telpMendesak,  handphoneMendesak,  handphoneMendesak2,  hubunganDenganMendesak,  surveiId,  keteranganLain);
        }
        private DataKontrakSurvei(string noRegistrasiDataSurvei, DateTime? tanggalSurvei, Guid dataKonsumenAvalistId, string karakter, string kerjasama, decimal? penghasilan, decimal? penghasilanlain, decimal? penghasilanPasangan, decimal? pengeluaranTetapBulanan, int? tanggungan, string statusTempatTinggal, int? tinggalSejak, string hasilSurvei, Guid kodeBidangPekerjaan, string namaBidangPekerjaan, Guid kodeBidangUsaha, string namaBidangUsaha, decimal? omzetBulanan, string pernahKredit, Guid masterBarangDBId, string fasilitasKreditBank, string jenisFasilitasbank, string namaRekeningBank, string noRekeningBank, string luasRumah, string luasTanah, string luasUsaha, string dayaListrikRumah, decimal? tagihanPLN, decimal? tagihanTelp, decimal? tagihanPDAM, string kondisiFisikRumah, string segmenRumah, string kondisiJalanRumah, string pagarRumah, string tamanRumah, string garasiRumah, int? kapasitasGarasiRumah, string dindingRumah, string atapRumah, string lantaiRumah, string toiletRumah, string televisiRumah, string kulkas, string lokasiSurvei, string lokasiTempatTinggal, string namaMendesak, string alamatMendesak, string kelurahanMendesak, string kecamatanMendesak, string kotaMendesak, string propinsiMendesak, string kodePosMendesak, string telpMendesak, string handphoneMendesak, string handphoneMendesak2, string hubunganDenganMendesak, string surveiId, string keteranganLain)
        {
            DataKontrakSurveiId=Guid.NewGuid();

            NoRegistrasiDataSurvei =noRegistrasiDataSurvei;
            TanggalSurvei=tanggalSurvei;
            DataKonsumenAvalistId=dataKonsumenAvalistId;
            Karakter=karakter;
            Kerjasama=kerjasama;
            Penghasilan=penghasilan;
            Penghasilanlain=penghasilanlain;
            PenghasilanPasangan=penghasilanPasangan;
            PengeluaranTetapBulanan=pengeluaranTetapBulanan;
            Tanggungan=tanggungan;
            StatusTempatTinggal=statusTempatTinggal;
            TinggalSejak=tinggalSejak;
            HasilSurvei=hasilSurvei;
            KodeBidangPekerjaan=kodeBidangPekerjaan;
            NamaBidangPekerjaan=namaBidangPekerjaan;
            KodeBidangUsaha=kodeBidangUsaha;
            NamaBidangUsaha=namaBidangUsaha;
            OmzetBulanan=omzetBulanan;
            PernahKredit=pernahKredit;
            MasterBarangDBId=masterBarangDBId;
            FasilitasKreditBank=fasilitasKreditBank;
            JenisFasilitasbank=jenisFasilitasbank;
            NamaRekeningBank=namaRekeningBank;
            NoRekeningBank=noRekeningBank;
            LuasRumah=luasRumah;
            LuasTanah=luasTanah;
            LuasUsaha=luasUsaha;
            DayaListrikRumah=dayaListrikRumah;
            TagihanPLN=tagihanPLN;
            TagihanTelp=tagihanTelp;
            TagihanPDAM=tagihanPDAM;
            KondisiFisikRumah=kondisiFisikRumah;
            SegmenRumah=segmenRumah;
            KondisiJalanRumah=kondisiJalanRumah;
            PagarRumah=pagarRumah;
            TamanRumah=tamanRumah;
            GarasiRumah=garasiRumah;
            KapasitasGarasiRumah=kapasitasGarasiRumah;
            DindingRumah=dindingRumah;
            AtapRumah=atapRumah;
            LantaiRumah=lantaiRumah;
            ToiletRumah=toiletRumah;
            TelevisiRumah=televisiRumah;
            Kulkas=kulkas;
            LokasiSurvei=lokasiSurvei;
            LokasiTempatTinggal=lokasiTempatTinggal;
            NamaMendesak=namaMendesak;
            AlamatMendesak=alamatMendesak;
            KelurahanMendesak=kelurahanMendesak;
            KecamatanMendesak=kecamatanMendesak;
            KotaMendesak=kotaMendesak;
            PropinsiMendesak=propinsiMendesak;
            KodePosMendesak=kodePosMendesak;
            TelpMendesak=telpMendesak;
            HandphoneMendesak=handphoneMendesak;
            HandphoneMendesak2=handphoneMendesak2;
            HubunganDenganMendesak=hubunganDenganMendesak;
            SurveiId=surveiId;
            KeteranganLain=keteranganLain;
        }

        public Guid DataKontrakSurveiId { get; private set; }

        public string NoRegistrasiDataSurvei { get; private set; }
        public DateTime? TanggalSurvei { get; private set; }
        public Guid DataKonsumenAvalistId { get; private set; }
        public string Karakter { get; private set; }
        public string Kerjasama { get; private set; }
        public decimal? Penghasilan { get; private set; }
        public decimal? Penghasilanlain { get; private set; }
        public decimal? PenghasilanPasangan { get; private set; }
        public decimal? PengeluaranTetapBulanan { get; private set; }
        public int? Tanggungan { get; private set; }
        public string StatusTempatTinggal { get; private set; }
        public int? TinggalSejak { get; private set; }
        public string HasilSurvei { get; private set; }
        public Guid KodeBidangPekerjaan { get; private set; }
        public string NamaBidangPekerjaan { get; private set; }
        public Guid KodeBidangUsaha { get; private set; }
        public string NamaBidangUsaha { get; private set; }
        public decimal? OmzetBulanan { get; private set; }
        public string PernahKredit { get; private set; }
        public Guid MasterBarangDBId { get; private set; }
        public string FasilitasKreditBank { get; private set; }
        public string JenisFasilitasbank { get; private set; }
        public string NamaRekeningBank { get; private set; }
        public string NoRekeningBank { get; private set; }
        public string LuasRumah { get; private set; }
        public string LuasTanah { get; private set; }
        public string LuasUsaha { get; private set; }
        public string DayaListrikRumah { get; private set; }
        public decimal? TagihanPLN { get; private set; }
        public decimal? TagihanTelp { get; private set; }
        public decimal? TagihanPDAM { get; private set; }
        public string KondisiFisikRumah { get; private set; }
        public string SegmenRumah { get; private set; }
        public string KondisiJalanRumah { get; private set; }
        public string PagarRumah { get; private set; }
        public string TamanRumah { get; private set; }
        public string GarasiRumah { get; private set; }
        public int? KapasitasGarasiRumah { get; private set; }
        public string DindingRumah { get; private set; }
        public string AtapRumah { get; private set; }
        public string LantaiRumah { get; private set; }
        public string ToiletRumah { get; private set; }
        public string TelevisiRumah { get; private set; }
        public string Kulkas { get; private set; }
        public string LokasiSurvei { get; private set; }
        public string LokasiTempatTinggal { get; private set; }
        public string NamaMendesak { get; private set; }
        public string AlamatMendesak { get; private set; }
        public string KelurahanMendesak { get; private set; }
        public string KecamatanMendesak { get; private set; }
        public string KotaMendesak { get; private set; }
        public string PropinsiMendesak { get; private set; }
        public string KodePosMendesak { get; private set; }
        public string TelpMendesak { get; private set; }
        public string HandphoneMendesak { get; private set; }
        public string HandphoneMendesak2 { get; private set; }
        public string HubunganDenganMendesak { get; private set; }
        public string SurveiId { get; private set; }
        public string KeteranganLain { get; private set; }
        public int NoUrutId { get; set; }



    }
}
