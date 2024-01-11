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
        //builder.HasData(
        //        new ProductCategory
        //        {
        //            Id = 1,
        //            NameEnglish = "Tea",
        //            NameSinhala = "තේ",
        //            NameTamil = "",
        //            Description = "",
        //            IsDeleted = false,
        //            CreatedDate = DateTime.UtcNow,
        //            LastModifiedDate = DateTime.Now,
        //        },
        //        new ProductCategory
        //        {
        //            Id = 2,
        //            NameEnglish = "Rubber",
        //            NameSinhala = "රබර්",
        //            NameTamil = "",
        //            Description = "",
        //            IsDeleted = false,
        //            CreatedDate = DateTime.UtcNow,
        //            LastModifiedDate = DateTime.Now,
        //        },
        //        new ProductCategory
        //        {
        //            Id = 3,
        //            NameEnglish = "Coconut",
        //            NameSinhala = "පොල්",
        //            NameTamil = "",
        //            Description = "",
        //            IsDeleted = false,
        //            CreatedDate = DateTime.UtcNow,
        //            LastModifiedDate = DateTime.Now,
        //        },
        //        new ProductCategory
        //        {
        //            Id = 4,
        //            NameEnglish = "Spices",
        //            NameSinhala = "කුළුබඩු",
        //            NameTamil = "",
        //            Description = "",
        //            IsDeleted = false,
        //            CreatedDate = DateTime.UtcNow,
        //            LastModifiedDate = DateTime.Now,
        //        },
        //        new ProductCategory
        //        {
        //            Id = 5,
        //            NameEnglish = "Food, Feed & Beverage",
        //            NameSinhala = "ආහාර සහ පාන",
        //            NameTamil = "",
        //            Description = "",
        //            IsDeleted = false,
        //            CreatedDate = DateTime.UtcNow,
        //            LastModifiedDate = DateTime.Now,
        //        },
        //        new ProductCategory
        //        {
        //            Id = 6,
        //            NameEnglish = "Electrical & Electronic",
        //            NameSinhala = "විදුලි සහ ඉලෙක්ට්‍රොනික",
        //            NameTamil = "",
        //            Description = "",
        //            IsDeleted = false,
        //            CreatedDate = DateTime.UtcNow,
        //            LastModifiedDate = DateTime.Now,
        //        },
        //        new ProductCategory
        //        {
        //            Id = 7,
        //            NameEnglish = "Apparel & Textile",
        //            NameSinhala = "ඇඟලුම් සහ රෙදිපිළි",
        //            NameTamil = "",
        //            Description = "",
        //            IsDeleted = false,
        //            CreatedDate = DateTime.UtcNow,
        //            LastModifiedDate = DateTime.Now,
        //        },
        //        new ProductCategory
        //        {
        //            Id = 8,
        //            NameEnglish = "Gem & Jewellery",
        //            NameSinhala = "මැණික් සහ ස්වර්ණාභරණ",
        //            NameTamil = "",
        //            Description = "",
        //            IsDeleted = false,
        //            CreatedDate = DateTime.UtcNow,
        //            LastModifiedDate = DateTime.Now,
        //        },
        //        new ProductCategory
        //        {
        //            Id = 9,
        //            NameEnglish = "Other",
        //            NameSinhala = "අනික්",
        //            NameTamil = "",
        //            Description = "",
        //            IsDeleted = false,
        //            CreatedDate = DateTime.UtcNow,
        //            LastModifiedDate = DateTime.Now,
        //        }
        //    );
    }
}
