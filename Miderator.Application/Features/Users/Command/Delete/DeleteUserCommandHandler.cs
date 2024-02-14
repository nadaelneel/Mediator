using AutoMapper;
using MediatR;
using Mediator.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Application.Interface;

namespace Mediator.Application.Features.Users.Command.Delete
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly IManger<User> manger;
        private readonly IUniteOfWork uniteOfWork;
        private readonly IMapper mapper;

        public DeleteUserCommandHandler(IManger<User> manger, IUniteOfWork uniteOfWork, IMapper mapper)
        {
            this.manger = manger;
            this.uniteOfWork = uniteOfWork;
            this.mapper = mapper;
        }

        public async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await  manger.GetById(request.Id);

            user.IsDeleted = true;
            manger.Update(user);
            uniteOfWork.Commit();
            return;
        }
    }
}
