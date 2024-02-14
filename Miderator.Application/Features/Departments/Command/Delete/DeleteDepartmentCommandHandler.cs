using AutoMapper;
using MediatR;
using Mediator.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Application.Interface;

namespace Mediator.Application.Features.Departments.Command.Delete
{
    public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand>
    {
        private readonly IManger<Department> manger;
        private readonly IUniteOfWork uniteOfWork;
        private readonly IMapper mapper;

        public DeleteDepartmentCommandHandler(IManger<Department> manger, IUniteOfWork uniteOfWork, IMapper mapper)
        {
            this.manger = manger;
            this.uniteOfWork = uniteOfWork;
            this.mapper = mapper;
        }

        public async Task Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await manger.GetById(request.Id);
             
            department.IsDeleted = true;
             manger.Update(department);
            uniteOfWork.Commit();
            return;
        }
    }
}
