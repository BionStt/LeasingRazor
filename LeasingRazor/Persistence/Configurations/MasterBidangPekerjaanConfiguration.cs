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
    public class MasterBidangPekerjaanConfiguration : IEntityTypeConfiguration<MasterBidangPekerjaan>
    {
        public void Configure(EntityTypeBuilder<MasterBidangPekerjaan> builder)
        {
            builder.ToTable("MasterBidangPekerjaan");
            builder.HasKey(x => x.MasterBidangPekerjaanId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();


        }
    }
}
