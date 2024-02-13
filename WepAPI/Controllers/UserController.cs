using MediatR;
using Microsoft.AspNetCore.Mvc;
using Mediator.Application.Features.Users.Command.Delete;
using Mediator.Application.Features.Users.Command.Post;
using Mediator.Application.Features.Users.Command.Put;
using Mediator.Application.Features.Users.Command.Put.DOTs;
using Mediator.Application.Features.Users.Query.GetAll;
using Mediator.Application.Features.Users.Query.GetAll.DOTs;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<ActionResult<List<GetAllUserDots>>> GetAll()
        {
            var Users = await mediator.Send(new GetAllUserQuery());
            return Ok(Users);
        }
        [HttpPost]
        [Route("AddUser")]
        public async Task<IActionResult> Add(PostUserCommand userCommand)
        {
             await mediator.Send(userCommand);
            return Ok();
          
        }
        [HttpPut]
        [Route("UpdateUser/{id}")]
        public async Task<ActionResult> Update(int id, PutRequestUserDots request)
        {
            await mediator.Send(new PutUserCommand() { Id =id, PutRequestUserDots = request});
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
             await mediator.Send(new DeleteUserCommand() { Id = id });
            return Ok();
        }
    }
}
