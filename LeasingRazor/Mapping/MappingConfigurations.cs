using LeasingRazor.Dto.DataKonsumen;
using LeasingRazor.Dto.DatakontrakAsuransi;
using LeasingRazor.Dto.DataKontrakKredit;
using LeasingRazor.Dto.DataKontrakKreditAngsuranDemo;
using LeasingRazor.Dto.DataKontrakSurvei;
using LeasingRazor.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen;
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
        public static CreateDataKonsumenCommand ToCommand(this CreateDataKonsumenRequest model)
        {
            return new CreateDataKonsumenCommand {
                Agama = model.Agama,
                AgamaPenjamin = model.AgamaPenjamin,
                AlamatKantor = model.AlamatKantor,
                AlamatKantorPenjamin = model.AlamatKantorPenjamin,
                AlamatKTP = model.AlamatKTP,
                AlamatKtpPenjamin = model.AlamatKtpPenjamin,
                AlamatPenjamin = model.AlamatPenjamin,
                AlamatSurat = model.AlamatSurat,
                AlamatTinggalK = model.AlamatTinggalK,
                AlamatUsaha = model.AlamatUsaha,
                AlamatUsahaPenjamin = model.AlamatUsahaPenjamin,
                Email = model.Email,
                EmailPenjamin = model.EmailPenjamin,
                FaxKantor = model.FaxKantor,
                FaxKantorPenjamin = model.FaxKantorPenjamin,
                FaxUsaha = model.FaxUsaha,
                FaxUsahaPenjamin = model.FaxUsahaPenjamin,
                HubunganPenjamin = model.HubunganPenjamin,
                JabatanPerusahaan = model.JabatanPerusahaan,
                JenisKelamin = model.JenisKelamin,
                JenisKelaminPenjamin= model.JenisKelaminPenjamin,
                JmlKaryawanPenjamin = model.JmlKaryawanPenjamin,
                JumlahKaryawan = model.JumlahKaryawan,
                KecamatanK = model.KecamatanK,
                KecamatanKantor = model.KecamatanKantor,
                KecamatanKantorPenjamin=model.KecamatanKantorPenjamin,
                KecamatanKTP = model.KecamatanKTP,
                KecamatanKtpPenjamin = model.KecamatanKtpPenjamin,
                KecamatanPenjamin= model.KecamatanPenjamin,
                KecamatanSurat=model.KecamatanSurat,
                KecamatanUsaha=model.KecamatanUsaha,
                KecamatanUsahaPenjamin=model.KecamatanUsahaPenjamin,
                KelurahanK = model.KelurahanK,
                TanggalRegister = model.TanggalRegister,
                KelurahanKantor = model.KelurahanKantor,
                KelurahanKantorPenjamin= model.KelurahanKantorPenjamin,
                KelurahanKTP = model.KelurahanKTP,
                KelurahanKtpPenjamin=model.KelurahanKtpPenjamin,
                KelurahanPenjamin = model.KelurahanPenjamin,
                KelurahanSurat=model.KelurahanSurat,
                KelurahanUsaha = model.KelurahanUsaha,
                KelurahanUsahaPenjamin = model.KelurahanUsahaPenjamin,
                KodeBidangUsaha=model.KodeBidangUsaha,
                KodeBidangUsahaIbuKandung=model.KodeBidangUsahaIbuKandung,
                KodeBidangUsahaPenjamin=model.KodeBidangUsahaPenjamin,
                KodePekerjaan = model.KodePekerjaan,
                KodePekerjaanIbuKandung=model.KodePekerjaanIbuKandung,
                KodePekerjaanPenjamin=model.KodePekerjaanPenjamin,
                KodePosKantor=model.KodePosKantor,
                 KodePosKantorPenjamin=model.KodePosKantorPenjamin,
                 KodePosKTP = model.KodePosKTP,
                 KodePosKTPPenjamin=model.KodePosKTPPenjamin,
                 KodePosPenjamin=model.KodePosPenjamin,
                 KodePosSurat=model.KodePosSurat,
                 KodePosTinggalK=model.KodePosTinggalK,
                 TanggalMulaiUsaha = model.TanggalMulaiUsaha,
                 KodePosUsaha=model.KodePosUsaha,
                 KodePosUsahaPenjamin=model.KodePosUsahaPenjamin,
                 KotaK=model.KodePosUsahaPenjamin,
                 KotaKantor=model.KotaKantor,
                 KotaKantorPenjamin=model.KotaKantorPenjamin,
                 KotaKTP=model.KotaKTP,
                 KotaKtpPenjamin=model.KotaKtpPenjamin,
                 KotaPenjamin=model.KotaPenjamin,
                 KotaSurat=model.KotaSurat,
                 KotaUsaha=model.KotaUsaha,
                 KotaUsahaPenjamin  =model.KotaUsahaPenjamin,
                 NamaBidangUsaha=model.NamaBidangUsaha,
                 NamaBidangUsahaIbuKandung=model.NamaBidangUsahaIbuKandung,
                 NamaBidangUsahaPenjamin = model.NamaBidangUsahaPenjamin,
                 NamaIbuKandung=model.NamaIbuKandung,
                 NamaKantor=model.NamaKantor,
                 NamaKantorPenjamin=model.NamaKantorPenjamin,
                 NamaKonsumen=model.NamaKonsumen,
                 NamaPekerjaan=model.NamaPekerjaan,
                 NamaPekerjaanIbuKandung=model.NamaPekerjaanIbuKandung,
                 NamaPekerjaanPenjamin=model.NamaPekerjaanPenjamin,
                 NamaPenjamin=model.NamaPenjamin,
                 NamaUsaha = model.NamaUsaha,
                 NamaUsahaPenjamin=model.NamaUsahaPenjamin,
                 NoHandphone=model.NoHandphone,
                 NoHandphone2=model.NoHandphone2,
                 NoHandphonePenjamin=model.NoHandphonePenjamin,
                 NoHandphonePenjamin2 = model.NoHandphonePenjamin2,
                 NoKTP=model.NoKTP,
                 NoKTPPenjamin=model.NoKTPPenjamin,
                 NoNpwpusaha=model.NoNpwpusaha,
                 NoNPWPUsahaPenjamin=model.NoNPWPUsahaPenjamin,
                 NoSiupusaha=model.NoSiupusaha,
                 NoSIUPusahaPenjamin=model.NoSIUPusahaPenjamin,
                 NoTDPusaha=model.NoTDPusaha,
                 NoTDPUsahaPenjamin=model.NoTDPUsahaPenjamin,
                 NoUrutKonsumen=model.NoUrutKonsumen,
                 PropinsiK=model.PropinsiK,
                 PropinsiKantor=model.PropinsiKantor,
                 PropinsiKantorPenjamin = model.PropinsiKantorPenjamin,
                 PropinsiKTP =model.PropinsiKTP,
                 PropinsiKtpPenjamin = model.PropinsiKtpPenjamin,
                 PropinsiPenjamin = model.PropinsiPenjamin,
                 PropinsiSurat = model.PropinsiSurat,
                 PropinsiUsaha = model.PropinsiUsaha,
                 PropinsiUsahaPenjamin =model.PropinsiUsahaPenjamin,
                 SkalaUsaha = model.SkalaUsaha,
                 SkalaUsahaPenjamin = model.SkalaUsahaPenjamin,
                 StatusNikah = model.StatusNikah,
                 StatusNikahPenjamin = model.StatusNikahPenjamin,
                 TanggalExpireKTP = model.TanggalExpireKTP,
                 TanggalExpireKTPPenjamin = model.TanggalExpireKTPPenjamin,
                 Tanggallahir = model.Tanggallahir,
                 TanggalLahirPenjamin = model.TanggalLahirPenjamin,
                 TelpKantor = model.TelpKantor, 
                 TelpKantorPenjamin = model.TelpKantorPenjamin,
                TelpRumah=model.TelpRumah,
                TelpRumahPenjamin=model.TelpRumahPenjamin,
                TelpUsaha=model.TelpUsaha,
                TelpUsahaPenjamin=model.TelpUsahaPenjamin,
                TempatLahir=model.TempatLahir,
                TempatLahirPenjamin=model.TempatLahirPenjamin,
                TingkatPendidikan = model.TingkatPendidikan,
                TingkatPendidikanPenjamin = model.TingkatPendidikanPenjamin





            };
        }
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
