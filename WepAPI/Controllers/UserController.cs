using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Miderator.Application.Features.Users.Command.Delete;
using Miderator.Application.Features.Users.Command.Post;
using Miderator.Application.Features.Users.Command.Put;
using Miderator.Application.Features.Users.Command.Put.DOTs;
using Miderator.Application.Features.Users.Query.GetAll;
using Miderator.Application.Features.Users.Query.GetAll.DOTs;
using Miderator.Infrastracture.ResponseDots;

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
        [HttpGet( Name = "GetAllUsers")]
        public async Task<ActionResult<List<GetAllUserDots>>> GetAllPosts()
        {
            var Users = await mediator.Send(new GetAllUserQuery());
            return Ok(Users);
        }
        [HttpPost(Name = "AddUser")]
        public async Task<IActionResult> AddPost(PostUserCommand userCommand)
        {
             await mediator.Send(userCommand);
            return Ok();
          
        }
        [HttpPut(Name = "UpdateUser")]
        [Route("{id}")]
        public async Task<ActionResult> Update(Guid id, PutRequestUserDots request)
        {
            await mediator.Send(new PutUserCommand() { Id =id, PutRequestUserDots = request});
            return Ok();
        }

        [HttpDelete(Name = "DeleteUser")]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
             await mediator.Send(new DeleteUserCommand() { Id = id });
            return Ok();
        }
    }
}
