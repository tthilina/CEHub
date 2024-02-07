using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Suppliers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CEH.Infrastructure.Persistence.EntityFramework.SupplierConfiguration;
public class SupplierProductConfiguration : IEntityTypeConfiguration<SupplierProduct>
{
    public void Configure(EntityTypeBuilder<SupplierProduct> builder)
    {
        builder.ToTable("SupplierProducts");

        builder
            .HasOne(up => up.Product)
            .WithMany(p => p.SupplierProducts)
            .HasForeignKey(up => up.ProductId);

        builder
            .HasOne(up => up.Supplier)
            .WithMany(p => p.SupplierProducts)
            .HasForeignKey(up => up.SupplierId);
    }
}
