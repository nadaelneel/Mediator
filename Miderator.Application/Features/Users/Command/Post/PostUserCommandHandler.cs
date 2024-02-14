using AutoMapper;
using MediatR;
using Mediator.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Application.Interface;

namespace Mediator.Application.Features.Users.Command.Post
{
    public class PostUserCommandHandler : IRequestHandler<PostUserCommand>
    {
        private readonly IManger<User> manger;
        private readonly IUniteOfWork uniteOfWork;
        private readonly IMapper mapper;

        public PostUserCommandHandler(IManger<User> manger, IUniteOfWork uniteOfWork, IMapper mapper)
        {
            this.manger = manger;
            this.uniteOfWork = uniteOfWork;
            this.mapper = mapper;
        }

        public async Task Handle(PostUserCommand request, CancellationToken cancellationToken)
        {
            User user = mapper.Map<User>(request);
            this.manger.Add(user);
            this.uniteOfWork.Commit();

            return;
        }
    }
}
