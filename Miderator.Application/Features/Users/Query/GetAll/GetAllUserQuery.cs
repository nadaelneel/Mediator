using MediatR;
using Mediator.Application.Features.Users.Query.GetAll.DOTs;

namespace Mediator.Application.Features.Users.Query.GetAll
{
    public class GetAllUserQuery : IRequest<List<GetAllUserDots>>
    {
    }
}
