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

namespace Miderator.Application.Features.Departments.Command.Delete
{
    public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand>
    {
        private readonly IManger<Department> manger;
        private readonly UniteOfWork uniteOfWork;
        private readonly IMapper mapper;

        public DeleteDepartmentCommandHandler(IManger<Department> manger, UniteOfWork uniteOfWork, IMapper mapper)
        {
            this.manger = manger;
            this.uniteOfWork = uniteOfWork;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await manger.GetById(request.Id);
             
            department.IsDeleted = true;
             manger.UpdateAync(department);
            return Unit.Value;
        }
    }
}
