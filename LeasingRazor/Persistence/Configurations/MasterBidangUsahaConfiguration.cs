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
    public class MasterBidangUsahaConfiguration : IEntityTypeConfiguration<MasterBidangUsaha>
    {
        public void Configure(EntityTypeBuilder<MasterBidangUsaha> builder)
        {
            builder.ToTable("MasterBidangUsaha");
            builder.HasKey(x => x.MasterBidangUsahaId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
