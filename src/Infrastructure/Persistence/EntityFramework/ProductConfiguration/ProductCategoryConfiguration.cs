using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CEH.Infrastructure.Persistence.EntityFramework.ProductConfiguration;
public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategories");
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
                new ProductCategory
                {
                    Id = 1,
                    NameEnglish = "Tea",
                    NameSinhala = "",
                    NameTamil = "",
                    Description = "",
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.Now,
                },
                new ProductCategory
                {
                    Id = 2,
                    NameEnglish = "Rubber",
                    NameSinhala = "",
                    NameTamil = "",
                    Description = "",
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.Now,
                },
                new ProductCategory
                {
                    Id = 3,
                    NameEnglish = "Spices",
                    NameSinhala = "",
                    NameTamil = "",
                    Description = "",
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.Now,
                },
                new ProductCategory
                {
                    Id = 4,
                    NameEnglish = "Food, Feed & Beverage",
                    NameSinhala = "",
                    NameTamil = "",
                    Description = "",
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.Now,
                },
                new ProductCategory
                {
                    Id = 5,
                    NameEnglish = "Electrical & Electronic",
                    NameSinhala = "",
                    NameTamil = "",
                    Description = "",
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.Now,
                },
                new ProductCategory
                {
                    Id = 6,
                    NameEnglish = "Apparel & Textile",
                    NameSinhala = "",
                    NameTamil = "",
                    Description = "",
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.Now,
                },
                new ProductCategory
                {
                    Id = 7,
                    NameEnglish = "Gem & Jewellery",
                    NameSinhala = "",
                    NameTamil = "",
                    Description = "",
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.Now,
                },
                new ProductCategory
                {
                    Id = 8,
                    NameEnglish = "Other",
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
