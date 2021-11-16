using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Domain
{
    public class DataKontrakKreditAngsuranDemo
    {
        public static DataKontrakKreditAngsuranDemo CreateDataKontrakKreditAngsuranDemo(int? angsKe, string noKwitansi, DateTime? tglAngsuran, double? angsuran, double? pokok, double? bunga, double? sisaPokok, double? sisaBunga, double? denda, double? diskonDenda, double? titipanAngsuran, DateTime? tglByrAngsuran, int? caraBayar, double? biayaAdm, string penagihId)
        {
            return new DataKontrakKreditAngsuranDemo(  angsKe,  noKwitansi,   tglAngsuran,   angsuran,   pokok,   bunga,   sisaPokok,   sisaBunga,   denda,   diskonDenda,   titipanAngsuran,   tglByrAngsuran,   caraBayar,   biayaAdm,  penagihId);
        }
        private DataKontrakKreditAngsuranDemo(int? angsKe, string noKwitansi, DateTime? tglAngsuran, double? angsuran, double? pokok, double? bunga, double? sisaPokok, double? sisaBunga, double? denda, double? diskonDenda, double? titipanAngsuran, DateTime? tglByrAngsuran, int? caraBayar, double? biayaAdm, string penagihId)
        {
            DataKontrakKreditAngsuranDemoId = Guid.NewGuid();
            AngsKe =angsKe;
            NoKwitansi=noKwitansi;
            TglAngsuran=tglAngsuran;
            Angsuran=angsuran;
            Pokok=pokok;
            Bunga=bunga;
            SisaPokok=sisaPokok;
            SisaBunga=sisaBunga;
            Denda=denda;
            DiskonDenda=diskonDenda;
            TitipanAngsuran=titipanAngsuran;
            TglByrAngsuran=tglByrAngsuran;
            CaraBayar=caraBayar;
            BiayaAdm=biayaAdm;
            PenagihId=penagihId;
        }

        public Guid DataKontrakKreditAngsuranDemoId { get; private set; }
        public int? AngsKe { get; private set; }
        public string NoKwitansi { get; private set; }
        public DateTime? TglAngsuran { get; private set; }
        public Double? Angsuran { get; private set; }

        public Double? Pokok { get; private set; }
        public Double? Bunga { get; private set; }
        public Double? SisaPokok { get; private set; }
        public Double? SisaBunga { get; private set; }
        public Double? Denda { get; private set; }
        public Double? DiskonDenda { get; private set; }
        public Double? TitipanAngsuran { get; private set; }
        public DateTime? TglByrAngsuran { get; private set; }
        public int? CaraBayar { get; private set; }
        public Double? BiayaAdm { get; private set; }
        public string PenagihId { get; private set; }
        public int NoUrutId { get; set; }
    }
}
