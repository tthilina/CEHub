using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public string? SupplyQuantity { get; set; }
    public string? OtherDetails { get; set; }
}
