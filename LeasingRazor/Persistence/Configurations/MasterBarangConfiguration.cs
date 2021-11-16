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
    public class MasterBarangConfiguration : IEntityTypeConfiguration<MasterBarang>
    {
        public void Configure(EntityTypeBuilder<MasterBarang> builder)
        {
            builder.ToTable("MasterBarang");

            builder.HasKey(x => x.MasterBarangId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(x => x.BBN).HasColumnType("money");
            builder.Property(x => x.Harga).HasColumnType("money");


        }
    }
}
