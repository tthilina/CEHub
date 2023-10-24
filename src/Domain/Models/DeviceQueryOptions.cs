using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Commons;
using Domain.Models;
using MediatR;

public class DeviceQueryOptions : IRequest<Device>
{
    public bool AsNoTracking { get; set; }
}
