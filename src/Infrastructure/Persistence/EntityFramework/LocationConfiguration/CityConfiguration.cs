using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Location;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CEH.Domain.Models.Locations;

namespace CEH.Infrastructure.Persistence.EntityFramework.Location;
internal class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("Cities");
        builder.Property(c => c.CitySinhala)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(c => c.CityTamil)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(t => t.CityEnglish)
            .HasMaxLength(100);
        builder.Property(c => c.CitySubSinhala)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(c => c.CitySubTamil)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(t => t.CitySubEnglish)
            .HasMaxLength(100);
        builder.Property(t => t.Postcode)
            .HasMaxLength(10);
        builder.Property(t => t.Longitude)
            .HasMaxLength(12);
        builder.Property(t => t.Latitude)
            .HasMaxLength(12);
    }
}
