using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Domain
{
    public class DataKontrakKredit
    {
        public static DataKontrakKredit CreateDataKontrakKredit(string noRegisterKontrakKredit, Guid dataKontrakSurveiId, DateTime? tanggalKontrak, string polaAngsuran, string caraBayar, double? hargaBarang, double? uangMuka, double? asuransi, double? administrasi, decimal? bungaEff, decimal? bungaFlat, int? lamaKredit, string tanggalAngsuranBulanan, string angsuranDimuka, double? nilaiBunga, double? nilaiKontrak, double? pinjamanPokok, double? angsuranBulanan, double? biayaAdministrasiAngsuran, string penagihId)
        {
            return new DataKontrakKredit(  noRegisterKontrakKredit,   dataKontrakSurveiId,     tanggalKontrak,   polaAngsuran,   caraBayar,   hargaBarang,   uangMuka,   asuransi,   administrasi,    bungaEff,    bungaFlat,     lamaKredit,   tanggalAngsuranBulanan,   angsuranDimuka,   nilaiBunga,   nilaiKontrak,   pinjamanPokok,   angsuranBulanan,   biayaAdministrasiAngsuran,   penagihId);
        }
        private DataKontrakKredit(string noRegisterKontrakKredit, Guid dataKontrakSurveiId, DateTime? tanggalKontrak, string polaAngsuran, string caraBayar, double? hargaBarang, double? uangMuka, double? asuransi, double? administrasi, decimal? bungaEff, decimal? bungaFlat, int? lamaKredit, string tanggalAngsuranBulanan, string angsuranDimuka, double? nilaiBunga, double? nilaiKontrak, double? pinjamanPokok, double? angsuranBulanan, double? biayaAdministrasiAngsuran, string penagihId)
        {
            DataKontrakKreditId = Guid.NewGuid();
            NoRegisterKontrakKredit =noRegisterKontrakKredit;
            DataKontrakSurveiId=dataKontrakSurveiId;
            TanggalKontrak=tanggalKontrak;
            PolaAngsuran=polaAngsuran;
            CaraBayar=caraBayar;
            HargaBarang=hargaBarang;
            UangMuka=uangMuka;
            Asuransi=asuransi;
            Administrasi=administrasi;
            BungaEff=bungaEff;
            BungaFlat=bungaFlat;
            LamaKredit=lamaKredit;
            TanggalAngsuranBulanan=tanggalAngsuranBulanan;
            AngsuranDimuka=angsuranDimuka;
            NilaiBunga=nilaiBunga;
            NilaiKontrak=nilaiKontrak;
            PinjamanPokok=pinjamanPokok;
            AngsuranBulanan=angsuranBulanan;
            BiayaAdministrasiAngsuran=biayaAdministrasiAngsuran;
            PenagihId=penagihId;
        }

        public Guid DataKontrakKreditId { get; private set; }
        public string NoRegisterKontrakKredit { get; private set; }
        public Guid DataKontrakSurveiId { get; private set; }
        public DateTime? TanggalKontrak { get; private set; }
        public string PolaAngsuran { get; private set; }
        public string CaraBayar { get; private set; }
        public double? HargaBarang { get; private set; }
        public double? UangMuka { get; private set; }
        public double? Asuransi { get; private set; }
        public double? Administrasi { get; private set; }
        public decimal? BungaEff { get; private set; }
        public decimal? BungaFlat { get; private set; }
        public int? LamaKredit { get; private set; }
        public string TanggalAngsuranBulanan { get; private set; }
        public string AngsuranDimuka { get; private set; }
        public double? NilaiBunga { get; private set; }
        public double? NilaiKontrak { get; private set; }
        public double? PinjamanPokok { get; private set; }
        public double? AngsuranBulanan { get; private set; }
        public double? BiayaAdministrasiAngsuran { get; private set; }
        public string PenagihId { get; private set; }

        public int NoUrutId { get; set; }



    }
}
