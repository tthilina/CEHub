using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CEH.Domain.Models.Products;

namespace CEH.Infrastructure.Persistence.EntityFramework.ProductConfiguration;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.Property(c => c.Name)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(c => c.Description)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(500);
        builder.Property(c => c.OtherDetails)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(500);
    }
}
