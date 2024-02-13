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

namespace Miderator.Application.Features.Departments.Command.Put
{
    public class PutDepartmentCommandHandler : IRequestHandler<PutDepartmentCommand>
    {
        private readonly IManger<Department> manger;
        private readonly UniteOfWork uniteOfWork;
        private readonly IMapper mapper;

        public PutDepartmentCommandHandler(IManger<Department> manger, UniteOfWork uniteOfWork, IMapper mapper)
        {
            this.manger = manger;
            this.uniteOfWork = uniteOfWork;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(PutDepartmentCommand request, CancellationToken cancellationToken)
        {
            Department department = await manger.GetById(request.Id);
            
            department.Name = request.PutRequestDepartmentDots.Name;
            department.IsDeleted = request.PutRequestDepartmentDots.IsDelete;
            this.manger.UpdateAync(department);
            this.uniteOfWork.Commit();

            return Unit.Value;




        }
    }
}
