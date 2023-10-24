using Application.Devices.Queries;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DevicesController : BaseController
{
    //private IMediator _mediator;

    //protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    //public DevicesController(IMediator mediator)
    //{
    //    _mediator = mediator;
    //}


    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            return Ok(await Mediator.Send(new GetDeviceQuery()));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    //[HttpGet("{id}")]
    //public async Task<FileResult> Get(int id)
    //{
    //    var vm = await Mediator.Send(new ExportTodosQuery { ListId = id });

    //    return File(vm.Content, vm.ContentType, vm.FileName);
    //}

    //[HttpPost]
    //public async Task<ActionResult<int>> Create(CreateTodoListCommand command)
    //{
    //    return await Mediator.Send(command);
    //}

    //[HttpPut("{id}")]
    //public async Task<ActionResult> Update(int id, UpdateTodoListCommand command)
    //{
    //    if (id != command.Id)
    //    {
    //        return BadRequest();
    //    }

    //    await Mediator.Send(command);

    //    return NoContent();
    //}

    //[HttpDelete("{id}")]
    //public async Task<ActionResult> Delete(int id)
    //{
    //    await Mediator.Send(new DeleteTodoListCommand { Id = id });

    //    return NoContent();
    //}
}
