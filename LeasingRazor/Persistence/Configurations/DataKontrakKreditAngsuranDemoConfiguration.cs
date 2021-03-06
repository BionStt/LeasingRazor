using LeasingRazor.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Persistence.Configurations
{
    public class DataKontrakKreditAngsuranDemoConfiguration : IEntityTypeConfiguration<DataKontrakKreditAngsuranDemo>
    {
        public void Configure(EntityTypeBuilder<DataKontrakKreditAngsuranDemo> builder)
        {
            builder.ToTable("DataKontrakKreditAngsuranDemo");
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();
            builder.HasKey(x=> x.DataKontrakKreditAngsuranDemoId);

            builder.Property(e => e.AngsKe).HasColumnName("AngsKe");
            builder.Property(e => e.NoKwitansi).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.TglAngsuran).HasColumnType("datetime");
            builder.Property(e => e.Angsuran).HasColumnType("money");
            builder.Property(e => e.Pokok).HasColumnType("money");
            builder.Property(e => e.Bunga).HasColumnType("money");
            builder.Property(e => e.SisaPokok).HasColumnType("money");
            builder.Property(e => e.SisaBunga).HasColumnType("money");
            builder.Property(e => e.Denda).HasColumnType("money");
            builder.Property(e => e.DiskonDenda).HasColumnType("money");
            builder.Property(e => e.TitipanAngsuran).HasColumnType("money");
            builder.Property(e => e.BiayaAdm).HasColumnType("money");
            builder.Property(e => e.TglByrAngsuran).HasColumnType("datetime");
            builder.Property(e => e.CaraBayar).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.PenagihId).HasMaxLength(1).IsUnicode(false);


        }
    }
}
