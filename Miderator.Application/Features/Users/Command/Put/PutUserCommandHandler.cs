using AutoMapper;
using MediatR;
using Mediator.Application.Features.Users.Command.Put;
using Mediator.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Application.Interface;

namespace Mediator.Application.Features.Users.Command.Put
{
    public class PutUserCommandHandler : IRequestHandler<PutUserCommand>
    {
        private readonly IManger<User> manger;
        private readonly IUniteOfWork uniteOfWork;
        private readonly IMapper mapper;

        public PutUserCommandHandler(IManger<User> manger, IUniteOfWork uniteOfWork, IMapper mapper)
        {
            this.manger = manger;
            this.uniteOfWork = uniteOfWork;
            this.mapper = mapper;
        }

        public async Task Handle(PutUserCommand request, CancellationToken cancellationToken)
        {
            User user = await manger.GetById(request.Id);

            user.Name = request.PutRequestUserDots.Name;
            user.IsDeleted = request.PutRequestUserDots.IsDelete;
            this.manger.Update(user);
            this.uniteOfWork.Commit();

            return;
        }
    }
}
