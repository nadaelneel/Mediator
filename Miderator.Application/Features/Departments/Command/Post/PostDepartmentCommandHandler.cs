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

namespace Miderator.Application.Features.Departments.Command.Post
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
            department = await this.manger.AddAync(department);
            this.uniteOfWork.Commit();

            return Unit.Value;

        }
    }
}
