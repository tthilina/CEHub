using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Commons;

namespace CEH.Domain.Models.Products;
public class ProductCategory : AuditableEntity
{
    public string NameEnglish { get; set; }
    public string? NameSinhala { get; set; }
    public string? NameTamil { get; set; }
    public string? Description { get; set; }
}
