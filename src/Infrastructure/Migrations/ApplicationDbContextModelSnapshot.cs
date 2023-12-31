﻿// <auto-generated />
using System;
using Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CEH.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CEH.Domain.Models.Location.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DistrictEnglish")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DistrictSinhala")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("DistrictTamil")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Districts", (string)null);
                });

            modelBuilder.Entity("CEH.Domain.Models.Location.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ProvinceEnglish")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProvinceSinhala")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("ProvinceTamil")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("Provinces", (string)null);
                });

            modelBuilder.Entity("CEH.Domain.Models.Locations.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CityEnglish")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CitySinhala")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("CitySubEnglish")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CitySubSinhala")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("CitySubTamil")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("CityTamil")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Latitude")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Postcode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Cities", (string)null);
                });

            modelBuilder.Entity("CEH.Domain.Models.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("OtherDetails")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int?>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductSubCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("SupplyQuantity")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductSubCategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("CEH.Domain.Models.Products.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NameEnglish")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("NameSinhala")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("NameTamil")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 15, 23, 50, 34, DateTimeKind.Unspecified).AddTicks(3423), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            IsDeleted = false,
                            LastModifiedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 20, 53, 50, 34, DateTimeKind.Unspecified).AddTicks(3426), new TimeSpan(0, 5, 30, 0, 0)),
                            NameEnglish = "Tea",
                            NameSinhala = "",
                            NameTamil = ""
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 15, 23, 50, 34, DateTimeKind.Unspecified).AddTicks(3452), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            IsDeleted = false,
                            LastModifiedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 20, 53, 50, 34, DateTimeKind.Unspecified).AddTicks(3453), new TimeSpan(0, 5, 30, 0, 0)),
                            NameEnglish = "Rubber",
                            NameSinhala = "",
                            NameTamil = ""
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 15, 23, 50, 34, DateTimeKind.Unspecified).AddTicks(3457), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            IsDeleted = false,
                            LastModifiedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 20, 53, 50, 34, DateTimeKind.Unspecified).AddTicks(3457), new TimeSpan(0, 5, 30, 0, 0)),
                            NameEnglish = "Spices",
                            NameSinhala = "",
                            NameTamil = ""
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 15, 23, 50, 34, DateTimeKind.Unspecified).AddTicks(3460), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            IsDeleted = false,
                            LastModifiedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 20, 53, 50, 34, DateTimeKind.Unspecified).AddTicks(3461), new TimeSpan(0, 5, 30, 0, 0)),
                            NameEnglish = "Food, Feed & Beverage",
                            NameSinhala = "",
                            NameTamil = ""
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 15, 23, 50, 34, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            IsDeleted = false,
                            LastModifiedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 20, 53, 50, 34, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, 5, 30, 0, 0)),
                            NameEnglish = "Electrical & Electronic",
                            NameSinhala = "",
                            NameTamil = ""
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 15, 23, 50, 34, DateTimeKind.Unspecified).AddTicks(3467), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            IsDeleted = false,
                            LastModifiedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 20, 53, 50, 34, DateTimeKind.Unspecified).AddTicks(3468), new TimeSpan(0, 5, 30, 0, 0)),
                            NameEnglish = "Apparel & Textile",
                            NameSinhala = "",
                            NameTamil = ""
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 15, 23, 50, 34, DateTimeKind.Unspecified).AddTicks(3470), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            IsDeleted = false,
                            LastModifiedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 20, 53, 50, 34, DateTimeKind.Unspecified).AddTicks(3471), new TimeSpan(0, 5, 30, 0, 0)),
                            NameEnglish = "Gem & Jewellery",
                            NameSinhala = "",
                            NameTamil = ""
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 15, 23, 50, 34, DateTimeKind.Unspecified).AddTicks(3474), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            IsDeleted = false,
                            LastModifiedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 20, 53, 50, 34, DateTimeKind.Unspecified).AddTicks(3474), new TimeSpan(0, 5, 30, 0, 0)),
                            NameEnglish = "Other",
                            NameSinhala = "",
                            NameTamil = ""
                        });
                });

            modelBuilder.Entity("CEH.Domain.Models.Products.ProductSubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NameEnglish")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("NameSinhala")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("NameTamil")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int?>("ProductCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("ProductSubCategories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 15, 23, 50, 40, DateTimeKind.Unspecified).AddTicks(2931), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            IsDeleted = false,
                            LastModifiedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 20, 53, 50, 40, DateTimeKind.Unspecified).AddTicks(2933), new TimeSpan(0, 5, 30, 0, 0)),
                            NameEnglish = "Tea bags",
                            NameSinhala = "",
                            NameTamil = "",
                            ProductCategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 15, 23, 50, 40, DateTimeKind.Unspecified).AddTicks(2952), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            IsDeleted = false,
                            LastModifiedDate = new DateTimeOffset(new DateTime(2023, 11, 6, 20, 53, 50, 40, DateTimeKind.Unspecified).AddTicks(2954), new TimeSpan(0, 5, 30, 0, 0)),
                            NameEnglish = "Green tea",
                            NameSinhala = "",
                            NameTamil = "",
                            ProductCategoryId = 1
                        });
                });

            modelBuilder.Entity("CEH.Domain.Models.Suppliers.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BusinessType")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber1")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ContactNumber2")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ExportingCountries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("IsExporting")
                        .HasColumnType("int");

                    b.Property<int>("IsQualityCertified")
                        .HasColumnType("int");

                    b.Property<int>("IsReadyToExport")
                        .HasColumnType("int");

                    b.Property<int>("IsRegisteredBusiness")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<string>("QualityCertificates")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("CEH.Domain.Models.Location.District", b =>
                {
                    b.HasOne("CEH.Domain.Models.Location.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("CEH.Domain.Models.Locations.City", b =>
                {
                    b.HasOne("CEH.Domain.Models.Location.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.Navigation("District");
                });

            modelBuilder.Entity("CEH.Domain.Models.Products.Product", b =>
                {
                    b.HasOne("CEH.Domain.Models.Products.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId");

                    b.HasOne("CEH.Domain.Models.Products.ProductSubCategory", "ProductSubCategory")
                        .WithMany()
                        .HasForeignKey("ProductSubCategoryId");

                    b.HasOne("CEH.Domain.Models.Suppliers.Supplier", null)
                        .WithMany("SupplierProducts")
                        .HasForeignKey("SupplierId");

                    b.Navigation("ProductCategory");

                    b.Navigation("ProductSubCategory");
                });

            modelBuilder.Entity("CEH.Domain.Models.Products.ProductSubCategory", b =>
                {
                    b.HasOne("CEH.Domain.Models.Products.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("CEH.Domain.Models.Suppliers.Supplier", b =>
                {
                    b.HasOne("CEH.Domain.Models.Locations.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("CEH.Domain.Models.Location.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("CEH.Domain.Models.Location.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");

                    b.Navigation("City");

                    b.Navigation("District");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("CEH.Domain.Models.Suppliers.Supplier", b =>
                {
                    b.Navigation("SupplierProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
