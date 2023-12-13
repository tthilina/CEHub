using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Location;
using Domain.Commons;

namespace CEH.Domain.Models.Locations;
public class City : AuditableEntity
{
    public int? DistrictId { get; set; }
    public virtual District District { get; set; }
    public string CityEnglish { get; set; }
    public string CitySinhala { get; set; }
    public string CityTamil { get; set; }
    public string? CitySubEnglish { get; set; }
    public string? CitySubSinhala { get; set; }
    public string? CitySubTamil { get; set; }
    public string? Postcode { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
}
