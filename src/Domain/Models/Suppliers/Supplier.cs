using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Location;
using CEH.Domain.Models.Locations;
using CEH.Domain.Models.Products;
using Domain.Commons;

namespace CEH.Domain.Models.Suppliers;
public class Supplier : AuditableEntity
{
    public int? ProvinceId { get; set; }
    public virtual Province Province { get; set; }
    public int? DistrictId { get; set; }
    public virtual District District { get; set; }
    public int? CityId { get; set; }
    public virtual City City { get; set; }
    public string Name { get; set; }
    public string ContactNumber1 { get; set; }
    public string? ContactNumber2 { get; set; }
    public string? Email { get; set; }
    public YesNo IsRegisteredBusiness { get; set; } = YesNo.No;
    public BusinessType BusinessType { get; set; } = BusinessType.Solo_Proprietor;
    public YesNo IsQualityCertified { get; set; } = YesNo.No;
    public string? QualityCertificates  { get; set; }
    public YesNo IsExporting { get; set; } = YesNo.No;
    public string? ExportingCountries { get; set; }
    public YesNo IsReadyToExport { get; set; } = YesNo.Yes;
    public virtual ICollection<Product>? SupplierProducts { get; set; }
}

public enum YesNo
{
    Yes = 0,
    No = 1
}

public enum BusinessType
{
    Solo_Proprietor = 0,
    Partnership = 1,
    Private_Limited_Company = 2
}
