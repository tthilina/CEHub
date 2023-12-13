using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Location;
using CEH.Domain.Models.Locations;
using CEH.Domain.Services.Locations;
using Domain.Commons;
using Domain.Models;
using Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace CEH.Infrastructure.Repositories;
public class LocationRepository : ILocationRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public IUnitOfWork UnitOfWork => throw new NotImplementedException();

    public LocationRepository(
        ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
    }

    public async Task<List<Province>> ProvincesToListAsync()
    {
        return await _applicationDbContext
            .Provinces.AsNoTracking().ToListAsync();
    }

    public async Task<List<District>> DistrictsToListAsync(int ProvinceId)
    {
        return await _applicationDbContext
            .Districts
            .Where(x => x.ProvinceId == ProvinceId)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<List<City>> CitisToListAsync(int DistrictId)
    {
        return await _applicationDbContext
            .Cities
            .Where(x => x.DistrictId == DistrictId)
            .AsNoTracking()
            .ToListAsync();
    }
}
