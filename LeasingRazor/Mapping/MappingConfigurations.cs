using LeasingRazor.Dto.DatakontrakAsuransi;
using LeasingRazor.Dto.DataKontrakKredit;
using LeasingRazor.Dto.DataKontrakKreditAngsuranDemo;
using LeasingRazor.Dto.DataKontrakSurvei;
using LeasingRazor.ServiceApplication.DataKontrakAsuransi.Commands.CreateDataKontrakAsuransi;
using LeasingRazor.ServiceApplication.DataKontrakKredit.Commands.CreateDataKontrakKredit;
using LeasingRazor.ServiceApplication.DataKontrakKreditAngsuranDemo.Commands.CreateDataKontrakKreditAngsuranDemo;
using LeasingRazor.ServiceApplication.DataKontrakSurvei.Commands.CreateDataKontrakSurvei;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Mapping
{
    public static class MappingConfigurations
    {
        public static CreateDataKontrakKreditAngsuranDemoCommand ToCommand(this CreateDataKontrakKreditAngsuranDemoRequest model)
        {
            return new CreateDataKontrakKreditAngsuranDemoCommand { 
            Administrasi = model.Administrasi,
            UangMuka = model.UangMuka,
                PolaAngsuran = model.PolaAngsuran,
            Angsuran = model.Angsuran,
            AngsuranBulanan = model.AngsuranBulanan,
            AngsuranDimuka = model.AngsuranDimuka,
            Asuransi=model.Asuransi,
            BungaEff = model.BungaEff,
            BungaFlat = model.BungaFlat,
            HargaBarang = model.HargaBarang,
            LamaKredit=model.LamaKredit,
            NilaiBunga=model.NilaiBunga,
            NilaiKontrak=model.NilaiKontrak,
            NoUrutDataKontrakKredit = model.NoUrutDataKontrakKredit,
            TanggalJatuhTempoBulanan=model.TanggalJatuhTempoBulanan

            };
        }
            public static CreateDataKontrakKreditCommand ToCommand(this CreateDataKontrakKreditRequest model) {
            return new CreateDataKontrakKreditCommand
            { 
            Administrasi= model.Administrasi,
            AngsuranBulanan = model.AngsuranBulanan,
            AngsuranDimuka = model.AngsuranDimuka,
            Asuransi = model.Asuransi,
            BiayaAdministrasiAngsuran = model.BiayaAdministrasiAngsuran,
            BungaEff = model.BungaEff,
            BungaFlat = model.BungaFlat,
            CaraBayar = model.CaraBayar,
            HargaBarang = model.HargaBarang,
            LamaKredit = model.LamaKredit,
            NilaiBunga = model.NilaiBunga,
            NilaiKontrak = model.NilaiKontrak,
            NoRegisterSurvei = model.NoRegisterSurvei,
            NoUrutDataKontrakKredit = model.NoUrutDataKontrakKredit,
            PenagihId = model.PenagihId,
            PinjamanPokok = model.PinjamanPokok,
            PolaAngsuran = model.PolaAngsuran,
            TanggalAngsuranBulanan = model.TanggalAngsuranBulanan,
            TanggalKontrak = model.TanggalKontrak,
            UangMuka = model.UangMuka
            
            


            };
        }
        public static CreateDataKontrakAsuransiCommand ToCommand(this CreateDataKontrakAsuransiRequest model)
        {
            return new CreateDataKontrakAsuransiCommand { 
            BiayaAsuransi = model.BiayaAsuransi,
            JenisAsuransi = model.JenisAsuransi,
            KodeAsuransi = model.KodeAsuransi,
            LamaAsuransi = model.LamaAsuransi,
            NilaiPertanggungan = model.NilaiPertanggungan,
            NoRegistrasiKontrakKredit = model.NoRegistrasiKontrakKredit,
            NoUrutDataAsuransi = model.NoUrutDataAsuransi,
            TanggalAkhirAsuransi = model.TanggalAkhirAsuransi,
            TanggalMulaiAsuransi = model.TanggalMulaiAsuransi



            };
        }
        public static CreateDataKontrakSurveiCommand ToCommand(this DataKontrakSurveiRequest model)
        {
            return new CreateDataKontrakSurveiCommand 
            {
                    AlamatMendesak = model.AlamatMendesak,
                    AtapRumah = model.AtapRumah,
                    DayaListrikRumah = model.DayaListrikRumah,
                    DindingRumah = model.DindingRumah,
                    FasilitasKreditBank = model.FasilitasKreditBank,
                    GarasiRumah = model.GarasiRumah,
                    HandphoneMendesak = model.HandphoneMendesak,
                    HandphoneMendesak2 = model.HandphoneMendesak2,
                    HasilSurvei = model.HasilSurvei,
                    HubunganDenganMendesak = model.HubunganDenganMendesak,
                    JenisFasilitasbank = model.JenisFasilitasbank,
                    KapasitasGarasiRumah = model.KapasitasGarasiRumah,
                    Karakter = model.Karakter,
                    KecamatanMendesak = model.KecamatanMendesak,
                    KelurahanMendesak = model.KelurahanMendesak,
                    Kerjasama = model.Kerjasama,
                    KeteranganLain = model.KeteranganLain,
                    KodeBidangPekerjaan = model.KodeBidangPekerjaan,
                    KodeBidangUsaha = model.KodeBidangUsaha,
                    KodePosMendesak = model.KodePosMendesak,
                    KondisiFisikRumah = model.KondisiFisikRumah,
                    KondisiJalanRumah = model.KondisiJalanRumah,
                    KotaMendesak = model.KotaMendesak,
                    Kulkas = model.Kulkas,
                    LantaiRumah = model.LantaiRumah,
                    LokasiSurvei = model.LokasiSurvei,
                    LokasiTempatTinggal = model.LokasiTempatTinggal,
                    LuasRumah = model.LuasRumah,
                    LuasTanah = model.LuasTanah,
                    LuasUsaha = model.LuasUsaha,
                    NamaBidangPekerjaan = model.NamaBidangPekerjaan,
                    NamaBidangUsaha = model.NamaBidangUsaha,
                    NamaMendesak = model.NamaMendesak,
                    NamaRekeningBank = model.NamaRekeningBank,
                    NoRegistrasiKonsumen = model.NoRegistrasiKonsumen,
                    NoRekeningBank = model.NoRekeningBank,
                    NoUrutDataSurvei = model.NoUrutDataSurvei,
                    NoUrutMasterBarang = model.NoUrutMasterBarang,
                OmzetBulanan = model.OmzetBulanan,
                PagarRumah = model.PagarRumah,
                PengeluaranTetapBulanan = model.PengeluaranTetapBulanan,
                Penghasilan = model.Penghasilan,
                Penghasilanlain = model.Penghasilanlain,
                PenghasilanPasangan = model.PenghasilanPasangan,
                PernahKredit = model.PernahKredit,
                PropinsiMendesak = model.PropinsiMendesak,
                SegmenRumah = model.SegmenRumah,
                StatusTempatTinggal = model.StatusTempatTinggal,
                SurveiId = model.SurveiId,
                TagihanPDAM = model.TagihanPDAM,
                TagihanPLN = model.TagihanPLN,
                TagihanTelp = model.TagihanTelp,
                TamanRumah = model.TamanRumah,
                Tanggungan = model.Tanggungan,
                TelevisiRumah = model.TelevisiRumah,
                TelpMendesak = model.TelpMendesak,
                TinggalSejak = model.TinggalSejak,
                ToiletRumah = model.ToiletRumah





            };
        }



    }
}
