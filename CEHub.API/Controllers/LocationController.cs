using Application.Devices.Queries;
using CEH.Application.Locations.Queries;
using CEH.Domain.Models.Products;
using Microsoft.AspNetCore.Mvc;

namespace CEHub.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LocationController : BaseController
{
    [HttpGet("GetProvinces")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetProvinces()
    {
        try
        {
            return Ok(await Mediator.Send(new GetProvinceQuery()));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("GetDistricts/{provinceId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetDistricts(int provinceId)
    {
        try
        {
            return Ok(await Mediator.Send(new GetDistrictQuery
            { 
                provinceId = provinceId 
            }));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("GetCities/{districtId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCities(int districtId)
    {
        try
        {
            return Ok(await Mediator.Send(new GetCityQuery
            { 
                districtId = districtId
            }));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
