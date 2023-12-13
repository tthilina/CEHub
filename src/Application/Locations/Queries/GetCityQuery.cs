using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Location;
using CEH.Domain.Models.Locations;
using CEH.Domain.Services.Locations;
using MediatR;

namespace CEH.Application.Locations.Queries;
public class GetCityQuery : IRequest<List<City>>
{
    public int districtId { get; set; }
}

internal class GetCityQueryHandler : IRequestHandler<GetCityQuery, List<City>>
{
    private readonly ILocationRepository _locationRepository;
    public GetCityQueryHandler(ILocationRepository locationRepository)
    {
        _locationRepository = locationRepository;
    }

    public async Task<List<City>> Handle(GetCityQuery request, CancellationToken cancellationToken)
    {
        var itemList = await _locationRepository.CitisToListAsync(request.districtId);

        return itemList;
    }
}
