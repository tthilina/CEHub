using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Commons;

namespace CEH.Domain.Models.Location;
public class District : AuditableEntity
{
    public int? ProvinceId { get; set; }
    public virtual Province Province { get; set; }
    public string DistrictEnglish { get; set; }
    public string DistrictSinhala { get; set; }
    public string DistrictTamil { get; set; }
}
