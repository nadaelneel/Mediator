using AutoMapper;
using MediatR;
using Mediator.Domains;
using Mediator.Infrastracture.Repository;
using Mediator.Infrastracture.UniteOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Features.Users.Command.Post
{
    public class PostUserCommandHandler : IRequestHandler<PostUserCommand>
    {
        private readonly IManger<User> manger;
        private readonly UniteOfWork uniteOfWork;
        private readonly IMapper mapper;

        public PostUserCommandHandler(IManger<User> manger, UniteOfWork uniteOfWork, IMapper mapper)
        {
            this.manger = manger;
            this.uniteOfWork = uniteOfWork;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(PostUserCommand request, CancellationToken cancellationToken)
        {
            User user = mapper.Map<User>(request);
            this.manger.AddAync(user);
            this.uniteOfWork.Commit();

            return Unit.Value;
        }
    }
}
