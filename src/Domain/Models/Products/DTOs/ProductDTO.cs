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
    public string? SupplyQuantity { get; set; }
    public string? OtherDetails { get; set; }
}
