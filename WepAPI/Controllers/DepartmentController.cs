using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Miderator.Application.Features.Users.Command.Delete;
using Miderator.Application.Features.Users.Command.Post;
using Miderator.Application.Features.Users.Command.Put.DOTs;
using Miderator.Application.Features.Users.Command.Put;
using Miderator.Application.Features.Users.Query.GetAll.DOTs;
using Miderator.Application.Features.Users.Query.GetAll;
using Miderator.Application.Features.Departments.Query.GetAll.Dots;
using Miderator.Application.Features.Departments.Query.GetAll;
using Miderator.Application.Features.Departments.Command.Post;
using Miderator.Application.Features.Departments.Command.Put.DTOs;
using Miderator.Application.Features.Departments.Command.Put;
using Miderator.Application.Features.Departments.Command.Delete;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private IMediator mediator;

        public DepartmentController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet(Name = "GetAllDepartments")]
        public async Task<ActionResult<List<GetAllDepartmentDots>>> GetAll()
        {
            var departments = await mediator.Send(new GetAllDepartmentQuery());
            return Ok(departments);
        }
        [HttpPost(Name = "AddDepartment")]
        public async Task<IActionResult> Add(PostDepaetmentCommand depCommand)
        {
            await mediator.Send(depCommand);
            return Ok();

        }
        [HttpPut(Name = "UpdateDepartment")]
        [Route("{id}")]
        public async Task<ActionResult> Update(Guid id, PutRequestDepartmentDots request)
        {
            await mediator.Send(new PutDepartmentCommand() { Id = id, PutRequestDepartmentDots = request });
            return Ok();
        }

        [HttpDelete(Name = "DeleteDepartment")]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await mediator.Send(new DeleteDepartmentCommand() { Id = id });
            return Ok();
        }
    }
}
