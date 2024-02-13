using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mediator.Application.Features.Departments.Query.GetAll.Dots;
using Mediator.Application.Features.Departments.Query.GetAll;
using Mediator.Application.Features.Departments.Command.Post;
using Mediator.Application.Features.Departments.Command.Put.DTOs;
using Mediator.Application.Features.Departments.Command.Put;
using Mediator.Application.Features.Departments.Command.Delete;

namespace WepAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class DepartmentController : ControllerBase
    {
        private IMediator mediator;

        public DepartmentController(IMediator mediator) 
        {
            this.mediator = mediator;
        }
        [HttpGet]
        [Route("GetAllDepartments")]
        public async Task<ActionResult<List<GetAllDepartmentDots>>> GetAll()
        {
            var departments = await mediator.Send(new GetAllDepartmentQuery());
            return Ok(departments);
        }
        [HttpPost]
        [Route("AddDepartment")]
        public async Task<IActionResult> Add(PostDepaetmentCommand depCommand)
        {
            await mediator.Send(depCommand);
            return Ok();

        }
        [HttpPut]
        [Route("UpdateDepartment/{id}")]
        public async Task<ActionResult> Update(int id, PutRequestDepartmentDots request)
        {
            await mediator.Send(new PutDepartmentCommand() { Id = id, PutRequestDepartmentDots = request });
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteDepartment/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await mediator.Send(new DeleteDepartmentCommand() { Id = id });
            return Ok();
        }
    }
}
