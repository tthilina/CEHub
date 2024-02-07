using CEH.Application.Products.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CEHub.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : BaseController
{
    [HttpGet("GetProductCategories")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetProductCategories()
    {
        try
        {
            return Ok(await Mediator.Send(new GetProductCategoryQuery()));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("GetProductSubCategories/{productCategoryId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetProductSubCategories(int productCategoryId)
    {
        try
        {
            return Ok(await Mediator.Send(new GetProductSubCategoryQuery()
            { 
                productCategoryId = productCategoryId
            }));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("GetAllCategories")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCategories()
    {
        try
        {
            return Ok(await Mediator.Send(new GetAllProductCategoryQuery()));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
