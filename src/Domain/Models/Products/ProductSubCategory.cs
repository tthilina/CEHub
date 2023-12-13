using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Location;
using Domain.Commons;

namespace CEH.Domain.Models.Products;
public class ProductSubCategory : AuditableEntity
{
    public int? ProductCategoryId { get; set; }
    public virtual ProductCategory ProductCategory { get; set; }
    public string NameEnglish { get; set; }
    public string? NameSinhala { get; set; }
    public string? NameTamil { get; set; }
    public string? Description { get; set; }
}
