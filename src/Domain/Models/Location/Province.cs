using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Commons;

namespace CEH.Domain.Models.Location;
public class Province : AuditableEntity
{
    public string ProvinceEnglish { get; set; }
    public string ProvinceSinhala { get; set; }
    public string ProvinceTamil { get; set; }
}
