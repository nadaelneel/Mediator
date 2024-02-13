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

namespace Mediator.Application.Features.Users.Command.Delete
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly IManger<User> manger;
        private readonly UniteOfWork uniteOfWork;
        private readonly IMapper mapper;

        public DeleteUserCommandHandler(IManger<User> manger, UniteOfWork uniteOfWork, IMapper mapper)
        {
            this.manger = manger;
            this.uniteOfWork = uniteOfWork;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await  manger.GetById(request.Id);

            user.IsDeleted = true;
            manger.UpdateAync(user);
            uniteOfWork.Commit();
            return Unit.Value;
        }
    }
}
