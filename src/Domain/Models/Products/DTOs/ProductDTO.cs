using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Suppliers;

namespace CEH.Domain.Models.Products.DTOs;
public class ProductDTO
{
    public int? ProductCategoryId { get; set; }
    public int? ProductSubCategoryId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public int? SupplyQuantity { get; set; }
    public UnitType UnitType { get; set; } = UnitType.Kilogram_Kg;
    public int? MonthlySupplyQuantity { get; set; }
    public int? MonthlyMinimumQuantity { get; set; }
    public string? SupplyMonths { get; set; }
    public string OtherDetails { get; set; }
}
