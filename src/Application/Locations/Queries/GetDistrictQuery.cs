using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Location;
using CEH.Domain.Services.Locations;
using MediatR;

namespace CEH.Application.Locations.Queries;
public class GetDistrictQuery : IRequest<List<District>>
{
    public int provinceId { get; set; }
}

internal class GetDistrictQueryHandler : IRequestHandler<GetDistrictQuery, List<District>>
{
    private readonly ILocationRepository _locationRepository;
    public GetDistrictQueryHandler(ILocationRepository locationRepository)
    {
        _locationRepository = locationRepository;
    }

    public async Task<List<District>> Handle(GetDistrictQuery request, CancellationToken cancellationToken)
    {
        var itemList = await _locationRepository.DistrictsToListAsync(request.provinceId);

        return itemList;
    }
}
