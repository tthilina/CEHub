using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Location;
using CEH.Domain.Models.Locations;
using CEH.Domain.Models.Products.DTOs;

namespace CEH.Domain.Models.Suppliers.DTOs;
public class SupplierDTO
{
    public int? ProvinceId { get; set; }
    public int? DistrictId { get; set; }
    public int? CityId { get; set; }
    public string Name { get; set; }
    public string ContactNumber1 { get; set; }
    public string? ContactNumber2 { get; set; }
    public string? Email { get; set; }
    public YesNo IsRegisteredBusiness { get; set; } = YesNo.No;
    public BusinessType BusinessType { get; set; } = BusinessType.Solo_Proprietor;
    public YesNo IsQualityCertified { get; set; } = YesNo.No;
    public string? QualityCertificates { get; set; }
    public YesNo IsExporting { get; set; } = YesNo.No;
    public string? ExportingCountries { get; set; }
    public YesNo IsReadyToExport { get; set; } = YesNo.Yes;
    public ICollection<ProductDTO>? Products { get; set; }
}
