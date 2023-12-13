using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Devices.Queries;
using CEH.Domain.Models.Location;
using CEH.Domain.Services.Locations;
using Domain.Models;
using MediatR;

namespace CEH.Application.Locations.Queries;
public class GetProvinceQuery : IRequest<List<Province>>
{
    public class GetProvinceQueryHandler : IRequestHandler<GetProvinceQuery, List<Province>>
    {
        private readonly ILocationRepository _locationRepository;
        public GetProvinceQueryHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<List<Province>> Handle(GetProvinceQuery request, CancellationToken cancellationToken)
        {
            var itemList = await _locationRepository.ProvincesToListAsync();

            return itemList;
        }
    }
}
