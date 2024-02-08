using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Suppliers;
using Domain.Commons;

namespace CEH.Domain.Models.Products;
public class Product : AuditableEntity
{
    public int? ProductCategoryId { get; set; }
    public virtual ProductCategory ProductCategory { get; set; }
    public int? ProductSubCategoryId { get; set; }
    public virtual ProductSubCategory ProductSubCategory { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; } = 0;
    public int? SupplyQuantity { get; set; }
    public UnitType UnitType { get; set; } = UnitType.Kilogram_Kg;
    public int? MonthlySupplyQuantity { get; set; }
    public int? MonthlyMinimumQuantity { get; set; }
    public string? SupplyMonths { get; set; }
    public string OtherDetails { get; set; }
    public ICollection<SupplierProduct>? SupplierProducts { get; set; }
}

public enum UnitType
{
    Kilogram_Kg = 0,
    Gram_g = 1,
    Miligram_mg = 2,
    Liter_l = 3,
    Milileter_ml = 4,
    Packet = 5,
    Unit = 6
}
