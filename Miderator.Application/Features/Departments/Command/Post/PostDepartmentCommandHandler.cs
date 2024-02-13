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

namespace Mediator.Application.Features.Departments.Command.Post
{
    public class PostDepartmentCommandHandler : IRequestHandler<PostDepaetmentCommand>
    {
        private readonly IManger<Department> manger;
        private readonly UniteOfWork uniteOfWork;
        private readonly IMapper mapper;

        public PostDepartmentCommandHandler(IManger<Department> manger, UniteOfWork uniteOfWork, IMapper mapper)
        {
            this.manger = manger;
            this.uniteOfWork = uniteOfWork;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(PostDepaetmentCommand request, CancellationToken cancellationToken)
        {
            Department department = mapper.Map<Department>(request);
            this.manger.Add(department);
            this.uniteOfWork.Commit();

            return Unit.Value;

        }
    }
}
