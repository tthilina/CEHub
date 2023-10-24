using System;
using Application.Commons.Exceptions;
using CEH.Application.Commons.Queries;
using Domain.Models;
using MediatR;

namespace Application.Devices.Queries;

//public class GetDeviceQueryHandler : IRequestHandler<DeviceQueryOptions, Device>
//{
//    private readonly IDeviceRepository _deviceRepository;

//    public GetDeviceQueryHandler(IDeviceRepository _deviceRepository)
//    {
//        _deviceRepository = _deviceRepository;
//    }

//    public async Task<Device> Handle(DeviceQueryOptions request, CancellationToken cancellationToken)
//    {
//        return await _deviceRepository.ToListAsync();
//    }
//}

public class GetDeviceQuery : IRequest<Device>
{
    public class GetDeviceQueryHandler : IRequestHandler<GetDeviceQuery, Device>
    {
        private readonly IDeviceRepository _deviceRepository;
        public GetDeviceQueryHandler(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public async Task<Device> Handle(GetDeviceQuery request, CancellationToken cancellationToken)
        {
            var itemList = await _deviceRepository.ToListAsync();

            return itemList.FirstOrDefault();

            throw new NotImplementedException();
        }
    }
}
