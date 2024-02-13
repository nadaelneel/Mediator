using AutoMapper;
using MediatR;
using Miderator.Domains;
using Miderator.Infrastracture.Repository;
using Miderator.Infrastracture.UniteOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Users.Command.Post
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
            user =await  this.manger.AddAync(user);
            this.uniteOfWork.Commit();

            return Unit.Value;
        }
    }
}
