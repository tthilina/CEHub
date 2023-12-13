using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CEH.Infrastructure.Persistence.EntityFramework.ProductConfiguration;
public class ProductSubCategoryConfiguration : IEntityTypeConfiguration<ProductSubCategory>
{
    public void Configure(EntityTypeBuilder<ProductSubCategory> builder)
    {
        builder.ToTable("ProductSubCategories");
        builder.Property(c => c.NameEnglish)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(c => c.NameSinhala)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(c => c.NameTamil)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(100);
        builder.Property(c => c.Description)
            .UseCollation("SQL_Latin1_General_CP1_CI_AS")
            .HasMaxLength(500);
        builder.HasData(
            new ProductSubCategory() 
            {
                Id = 1,
                ProductCategoryId = 1,
                NameEnglish = "Tea bags",
                NameSinhala = "",
                NameTamil = "",
                Description = "",
                IsDeleted = false,
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.Now,
            },
            new ProductSubCategory()
            {
                Id = 2,
                ProductCategoryId = 1,
                NameEnglish = "Green tea",
                NameSinhala = "",
                NameTamil = "",
                Description = "",
                IsDeleted = false,
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.Now,
            }
        );
    }
}
