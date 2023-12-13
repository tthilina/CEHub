using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Location;
using CEH.Domain.Models.Locations;
using Domain.Commons;
using Domain.Models;

namespace CEH.Domain.Services.Locations;
public interface ILocationRepository : IRepository<Province>, IRepository<District>, IRepository<City>
{
    Task<List<Province>> ProvincesToListAsync();
    Task<List<District>> DistrictsToListAsync(int ProvinceId);
    Task<List<City>> CitisToListAsync(int DistrictId);
}
