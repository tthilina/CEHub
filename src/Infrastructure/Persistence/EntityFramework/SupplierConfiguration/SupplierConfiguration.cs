using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Locations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CEH.Domain.Models.Suppliers;

namespace CEH.Infrastructure.Persistence.EntityFramework.SupplierConfiguration;
public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.ToTable("Suppliers");
        builder.Property(c => c.Name)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(t => t.ContactNumber1)
            .HasMaxLength(15);
        builder.Property(t => t.ContactNumber2)
            .HasMaxLength(15);
        builder.Property(t => t.Email)
            .HasMaxLength(300);
    }
}
