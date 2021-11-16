using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeasingRazor.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataKonsumen",
                columns: table => new
                {
                    DataKonsumenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoRegisterKonsumen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TanggalRegister = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    NamaKonsumen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AlamatTinggalK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KelurahanK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KecamatanK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KotaK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropinsiK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePosTinggalK = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    TelpRumah = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    NoHandphone = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    NoHandphone2 = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    NoKTP = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    TempatLahir = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Tanggallahir = table.Column<DateTime>(type: "datetime", nullable: true),
                    TanggalExpireKTP = table.Column<DateTime>(type: "datetime", nullable: true),
                    AlamatKTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KelurahanKTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KecamatanKTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KotaKTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropinsiKTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePosKTP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    JenisKelamin = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    StatusNikah = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Agama = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    TingkatPendidikan = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePekerjaan = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    NamaPekerjaan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    JabatanPerusahaan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NamaKantor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AlamatKantor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KelurahanKantor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KecamatanKantor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KotaKantor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropinsiKantor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePosKantor = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    TelpKantor = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FaxKantor = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NamaUsaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AlamatUsaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KelurahanUsaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KecamatanUsaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KotaUsaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropinsiUsaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePosUsaha = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    TelpUsaha = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FaxUsaha = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NoNpwpusaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NoSiupusaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NoTDPusaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TanggalMulaiUsaha = table.Column<DateTime>(type: "datetime", nullable: true),
                    JumlahKaryawan = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    SkalaUsaha = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    KodeBidangUsaha = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    NamaBidangUsaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AlamatSurat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KelurahanSurat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KecamatanSurat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KotaSurat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropinsiSurat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePosSurat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    NamaIbuKandung = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePekerjaanIbuKandung = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    NamaPekerjaanIbuKandung = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodeBidangUsahaIbuKandung = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    NamaBidangUsahaIbuKandung = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NamaPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AlamatPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KelurahanPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KecamatanPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KotaPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropinsiPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePosPenjamin = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    TelpRumahPenjamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NoHandphonePenjamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NoHandphonePenjamin2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NoKTPPenjamin = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    TempatLahirPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TanggalLahirPenjamin = table.Column<DateTime>(type: "datetime", nullable: true),
                    TanggalExpireKTPPenjamin = table.Column<DateTime>(type: "datetime", nullable: true),
                    AlamatKtpPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KelurahanKtpPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KecamatanKtpPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KotaKtpPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropinsiKtpPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePosKTPPenjamin = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    JenisKelaminPenjamin = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    StatusNikahPenjamin = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    AgamaPenjamin = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    EmailPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodeBidangUsahaPenjamin = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    NamaBidangUsahaPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePekerjaanPenjamin = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    NamaPekerjaanPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TingkatPendidikanPenjamin = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    HubunganPenjamin = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    NamaKantorPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AlamatKantorPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KelurahanKantorPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KecamatanKantorPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KotaKantorPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropinsiKantorPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePosKantorPenjamin = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    TelpKantorPenjamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FaxKantorPenjamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NamaUsahaPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AlamatUsahaPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KelurahanUsahaPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KecamatanUsahaPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KotaUsahaPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropinsiUsahaPenjamin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePosUsahaPenjamin = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    TelpUsahaPenjamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FaxUsahaPenjamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NoNPWPUsahaPenjamin = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    NoSIUPusahaPenjamin = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    NoTDPUsahaPenjamin = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    JmlKaryawanPenjamin = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    SkalaUsahaPenjamin = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKonsumen", x => x.DataKonsumenId);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakAngsuran",
                columns: table => new
                {
                    DataKontrakAngsuranId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataKontrakKreditId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AngsuranKe = table.Column<int>(type: "int", unicode: false, maxLength: 4, nullable: true),
                    NoKwitansi = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    TanggalAngsuran = table.Column<DateTime>(type: "datetime", nullable: true),
                    Angsuran = table.Column<decimal>(type: "money", nullable: true),
                    Pokok = table.Column<decimal>(type: "money", nullable: true),
                    Bunga = table.Column<decimal>(type: "money", nullable: true),
                    SisaPokok = table.Column<decimal>(type: "money", nullable: true),
                    SisaBunga = table.Column<decimal>(type: "money", nullable: true),
                    Denda = table.Column<decimal>(type: "money", nullable: true),
                    DiskonDenda = table.Column<decimal>(type: "money", nullable: true),
                    TitipanAngsuran = table.Column<decimal>(type: "money", nullable: true),
                    TanggalBayarAngsuran = table.Column<DateTime>(type: "datetime", nullable: true),
                    JumlahPembayaran = table.Column<decimal>(type: "money", nullable: true),
                    CaraBayar = table.Column<int>(type: "int", unicode: false, maxLength: 3, nullable: true),
                    BiayaAdministrasi = table.Column<decimal>(type: "money", nullable: true),
                    PenagihId = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKontrakAngsuran", x => x.DataKontrakAngsuranId);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakAsuransi",
                columns: table => new
                {
                    DataKontrakAsuransiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataKontrakKreditId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MasterPerusahaanAsuransiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoRegistrasiKontrakAsuransi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodeAsuransi = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    JenisAsuransi = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: true),
                    TanggalMulaiAsuransi = table.Column<DateTime>(type: "datetime", nullable: true),
                    TanggalAkhirAsuransi = table.Column<DateTime>(type: "datetime", nullable: true),
                    LamaAsuransi = table.Column<int>(type: "int", unicode: false, maxLength: 4, nullable: true),
                    NilaiPertanggungan = table.Column<decimal>(type: "money", nullable: true),
                    BiayaAsuransi = table.Column<decimal>(type: "money", nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKontrakAsuransi", x => x.DataKontrakAsuransiId);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakKredit",
                columns: table => new
                {
                    DataKontrakKreditId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoRegisterKontrakKredit = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DataKontrakSurveiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TanggalKontrak = table.Column<DateTime>(type: "datetime", nullable: true),
                    PolaAngsuran = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    CaraBayar = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    HargaBarang = table.Column<decimal>(type: "money", nullable: true),
                    UangMuka = table.Column<decimal>(type: "money", nullable: true),
                    Asuransi = table.Column<decimal>(type: "money", nullable: true),
                    Administrasi = table.Column<decimal>(type: "money", nullable: true),
                    BungaEff = table.Column<decimal>(type: "decimal(8,5)", nullable: true),
                    BungaFlat = table.Column<decimal>(type: "decimal(8,5)", nullable: true),
                    LamaKredit = table.Column<int>(type: "int", unicode: false, maxLength: 30, nullable: true),
                    TanggalAngsuranBulanan = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    AngsuranDimuka = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    NilaiBunga = table.Column<decimal>(type: "money", nullable: true),
                    NilaiKontrak = table.Column<decimal>(type: "money", nullable: true),
                    PinjamanPokok = table.Column<decimal>(type: "money", nullable: true),
                    AngsuranBulanan = table.Column<decimal>(type: "money", nullable: true),
                    BiayaAdministrasiAngsuran = table.Column<decimal>(type: "money", nullable: true),
                    PenagihId = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKontrakKredit", x => x.DataKontrakKreditId);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakKreditAngsuranDemo",
                columns: table => new
                {
                    DataKontrakKreditAngsuranDemoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AngsKe = table.Column<int>(type: "int", nullable: true),
                    NoKwitansi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TglAngsuran = table.Column<DateTime>(type: "datetime", nullable: true),
                    Angsuran = table.Column<decimal>(type: "money", nullable: true),
                    Pokok = table.Column<decimal>(type: "money", nullable: true),
                    Bunga = table.Column<decimal>(type: "money", nullable: true),
                    SisaPokok = table.Column<decimal>(type: "money", nullable: true),
                    SisaBunga = table.Column<decimal>(type: "money", nullable: true),
                    Denda = table.Column<decimal>(type: "money", nullable: true),
                    DiskonDenda = table.Column<decimal>(type: "money", nullable: true),
                    TitipanAngsuran = table.Column<decimal>(type: "money", nullable: true),
                    TglByrAngsuran = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaraBayar = table.Column<int>(type: "int", unicode: false, maxLength: 1, nullable: true),
                    BiayaAdm = table.Column<decimal>(type: "money", nullable: true),
                    PenagihId = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKontrakKreditAngsuranDemo", x => x.DataKontrakKreditAngsuranDemoId);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakSurvei",
                columns: table => new
                {
                    DataKontrakSurveiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoRegistrasiDataSurvei = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    TanggalSurvei = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    DataKonsumenAvalistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Karakter = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Kerjasama = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Penghasilan = table.Column<decimal>(type: "money", nullable: true),
                    Penghasilanlain = table.Column<decimal>(type: "money", nullable: true),
                    PenghasilanPasangan = table.Column<decimal>(type: "money", nullable: true),
                    PengeluaranTetapBulanan = table.Column<decimal>(type: "money", nullable: true),
                    Tanggungan = table.Column<int>(type: "int", unicode: false, maxLength: 4, nullable: true),
                    StatusTempatTinggal = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    TinggalSejak = table.Column<int>(type: "int", unicode: false, maxLength: 3, nullable: true),
                    HasilSurvei = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    KodeBidangPekerjaan = table.Column<Guid>(type: "uniqueidentifier", unicode: false, maxLength: 2, nullable: false),
                    NamaBidangPekerjaan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodeBidangUsaha = table.Column<Guid>(type: "uniqueidentifier", unicode: false, maxLength: 2, nullable: false),
                    NamaBidangUsaha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    OmzetBulanan = table.Column<decimal>(type: "money", nullable: true),
                    PernahKredit = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    MasterBarangDBId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FasilitasKreditBank = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    JenisFasilitasbank = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NamaRekeningBank = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NoRekeningBank = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    LuasRumah = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    LuasTanah = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    LuasUsaha = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DayaListrikRumah = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TagihanPLN = table.Column<decimal>(type: "money", nullable: true),
                    TagihanTelp = table.Column<decimal>(type: "money", nullable: true),
                    TagihanPDAM = table.Column<decimal>(type: "money", nullable: true),
                    KondisiFisikRumah = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    SegmenRumah = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    KondisiJalanRumah = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    PagarRumah = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    TamanRumah = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    GarasiRumah = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    KapasitasGarasiRumah = table.Column<int>(type: "int", unicode: false, maxLength: 30, nullable: true),
                    DindingRumah = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    AtapRumah = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    LantaiRumah = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    ToiletRumah = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    TelevisiRumah = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Kulkas = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    LokasiSurvei = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    LokasiTempatTinggal = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    NamaMendesak = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AlamatMendesak = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KelurahanMendesak = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KecamatanMendesak = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KotaMendesak = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropinsiMendesak = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    KodePosMendesak = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    TelpMendesak = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    HandphoneMendesak = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    HandphoneMendesak2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    HubunganDenganMendesak = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    SurveiId = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    KeteranganLain = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKontrakSurvei", x => x.DataKontrakSurveiId);
                });

            migrationBuilder.CreateTable(
                name: "MasterBarang",
                columns: table => new
                {
                    MasterBarangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BBN = table.Column<decimal>(type: "money", nullable: true),
                    Cc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Harga = table.Column<decimal>(type: "money", nullable: true),
                    Merek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamaBarang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomorRangka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomorMesin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tahun = table.Column<int>(type: "int", nullable: true),
                    Tipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeKendaraan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aktif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBarang", x => x.MasterBarangId);
                });

            migrationBuilder.CreateTable(
                name: "MasterBidangPekerjaan",
                columns: table => new
                {
                    MasterBidangPekerjaanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterBidangPekerjaanKeterangan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangPekerjaan", x => x.MasterBidangPekerjaanId);
                });

            migrationBuilder.CreateTable(
                name: "MasterBidangUsaha",
                columns: table => new
                {
                    MasterBidangUsahaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterBidangUsahaKeterangan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangUsaha", x => x.MasterBidangUsahaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataKonsumen");

            migrationBuilder.DropTable(
                name: "DataKontrakAngsuran");

            migrationBuilder.DropTable(
                name: "DataKontrakAsuransi");

            migrationBuilder.DropTable(
                name: "DataKontrakKredit");

            migrationBuilder.DropTable(
                name: "DataKontrakKreditAngsuranDemo");

            migrationBuilder.DropTable(
                name: "DataKontrakSurvei");

            migrationBuilder.DropTable(
                name: "MasterBarang");

            migrationBuilder.DropTable(
                name: "MasterBidangPekerjaan");

            migrationBuilder.DropTable(
                name: "MasterBidangUsaha");
        }
    }
}
