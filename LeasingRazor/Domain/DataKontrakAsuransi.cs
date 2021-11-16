using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Domain
{
    public class DataKontrakAsuransi
    {
        public static DataKontrakAsuransi CreateDataKontrakAsuransi(Guid dataKontrakKreditId, Guid masterPerusahaanAsuransiId, string noRegistrasiKontrakAsuransi, string kodeAsuransi, int? jenisAsuransi, DateTime? tanggalMulaiAsuransi, DateTime? tanggalAkhirAsuransi, int? lamaAsuransi, decimal? nilaiPertanggungan, decimal? biayaAsuransi)
        {
            return new DataKontrakAsuransi(  dataKontrakKreditId,   masterPerusahaanAsuransiId,   noRegistrasiKontrakAsuransi,   kodeAsuransi,     jenisAsuransi,     tanggalMulaiAsuransi,     tanggalAkhirAsuransi,     lamaAsuransi,    nilaiPertanggungan,    biayaAsuransi);
        }
        private DataKontrakAsuransi(Guid dataKontrakKreditId, Guid masterPerusahaanAsuransiId, string noRegistrasiKontrakAsuransi, string kodeAsuransi, int? jenisAsuransi, DateTime? tanggalMulaiAsuransi, DateTime? tanggalAkhirAsuransi, int? lamaAsuransi, decimal? nilaiPertanggungan, decimal? biayaAsuransi)
        {
            DataKontrakAsuransiId = Guid.NewGuid();
            DataKontrakKreditId =dataKontrakKreditId;
            MasterPerusahaanAsuransiId=masterPerusahaanAsuransiId;
            NoRegistrasiKontrakAsuransi=noRegistrasiKontrakAsuransi;
            KodeAsuransi=kodeAsuransi;
            JenisAsuransi=jenisAsuransi;
            TanggalMulaiAsuransi=tanggalMulaiAsuransi;
            TanggalAkhirAsuransi=tanggalAkhirAsuransi;
            LamaAsuransi=lamaAsuransi;
            NilaiPertanggungan=nilaiPertanggungan;
            BiayaAsuransi=biayaAsuransi;
        }

        public Guid DataKontrakAsuransiId { get; private set; }
        public Guid DataKontrakKreditId { get; private set; }
        public Guid MasterPerusahaanAsuransiId { get; private set; }
        public string NoRegistrasiKontrakAsuransi { get; private set; }
        public string KodeAsuransi { get; private set; }
        public int? JenisAsuransi { get; private set; }
        public  DateTime? TanggalMulaiAsuransi { get; private set; }
        public DateTime? TanggalAkhirAsuransi { get; private set; }
        public int? LamaAsuransi { get; private set; }
        public decimal? NilaiPertanggungan { get; private set; }
        public decimal? BiayaAsuransi { get; private set; }
        public int NoUrutId { get; set; }
    }
}
