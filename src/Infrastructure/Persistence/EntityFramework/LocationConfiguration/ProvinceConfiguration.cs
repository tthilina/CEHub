using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CEH.Domain.Models.Location;
using System.Reflection.Emit;

namespace CEH.Infrastructure.Persistence.EntityFramework.Location;
internal class ProvinceConfiguration : IEntityTypeConfiguration<Province>
{
    public void Configure(EntityTypeBuilder<Province> builder)
    {
        builder.ToTable("Provinces");
        builder.Property(c => c.ProvinceSinhala)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(c => c.ProvinceTamil)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(t => t.ProvinceEnglish)
            .HasMaxLength(100);
    }
}
