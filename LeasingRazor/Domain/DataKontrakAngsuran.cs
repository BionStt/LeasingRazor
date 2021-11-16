using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Domain
{
    public class DataKontrakAngsuran
    {
        public static DataKontrakAngsuran CreateDataKontrakAngsuran(Guid dataKontrakKreditId, int? angsuranKe, string noKwitansi, DateTime? tanggalAngsuran, double? angsuran, double? pokok, double? bunga, double? sisaPokok, double? sisaBunga, double? denda, double? diskonDenda, double? titipanAngsuran, DateTime? tanggalBayarAngsuran, double? jumlahPembayaran, int? caraBayar, double? biayaAdministrasi, string penagihId)
        {
            return new DataKontrakAngsuran(  dataKontrakKreditId,     angsuranKe,   noKwitansi,     tanggalAngsuran,     angsuran,     pokok,     bunga,     sisaPokok,     sisaBunga,     denda,     diskonDenda,     titipanAngsuran,     tanggalBayarAngsuran,     jumlahPembayaran,     caraBayar,     biayaAdministrasi,   penagihId);
        }
        private DataKontrakAngsuran( Guid dataKontrakKreditId, int? angsuranKe, string noKwitansi, DateTime? tanggalAngsuran, double? angsuran, double? pokok, double? bunga, double? sisaPokok, double? sisaBunga, double? denda, double? diskonDenda, double? titipanAngsuran, DateTime? tanggalBayarAngsuran, double? jumlahPembayaran, int? caraBayar, double? biayaAdministrasi, string penagihId)
        {
            DataKontrakAngsuranId=Guid.NewGuid();
            DataKontrakKreditId=dataKontrakKreditId;
            AngsuranKe=angsuranKe;
            NoKwitansi=noKwitansi;
            TanggalAngsuran=tanggalAngsuran;
            Angsuran=angsuran;
            Pokok=pokok;
            Bunga=bunga;
            SisaPokok=sisaPokok;
            SisaBunga=sisaBunga;
            Denda=denda;
            DiskonDenda=diskonDenda;
            TitipanAngsuran=titipanAngsuran;
            TanggalBayarAngsuran=tanggalBayarAngsuran;
            JumlahPembayaran=jumlahPembayaran;
            CaraBayar=caraBayar;
            BiayaAdministrasi=biayaAdministrasi;
            PenagihId=penagihId;
        }

        public Guid DataKontrakAngsuranId { get; private set; }

        public Guid DataKontrakKreditId { get; private set; }
        public int? AngsuranKe { get; private set; }
        public string NoKwitansi { get; private set; }
        public DateTime? TanggalAngsuran { get; private set; }
        public double? Angsuran { get; private set; }
        public double? Pokok { get; private set; }
        public double? Bunga { get; private set; }
        public double? SisaPokok { get; private set; }
        public double? SisaBunga { get; private set; }
        public double? Denda { get; private set; }
        public double? DiskonDenda { get; private set; }
        public double? TitipanAngsuran { get; private set; }
        public DateTime? TanggalBayarAngsuran { get; private set; }
        public double? JumlahPembayaran { get; private set; }
        public int? CaraBayar { get; private set; }
        public double? BiayaAdministrasi { get; private set; }
        public string PenagihId { get; private set; }

        public int NoUrutId { get; set; }

    }
}
