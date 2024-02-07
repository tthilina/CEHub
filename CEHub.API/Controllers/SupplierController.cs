using CEH.Application.Suppliers.Commands;
using CEH.Domain.Models.Suppliers.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CEHub.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SupplierController : BaseController
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Post(SupplierDTO model)
    {
        try
        {
            return Ok(await Mediator.Send(new CreateSupplierCommand() { Supplier = model }));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
