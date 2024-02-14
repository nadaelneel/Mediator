using AutoMapper;
using MediatR;
using Mediator.Application.Features.Departments.Query.GetAll.Dots;
using Mediator.Domains;
using Mediator.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Features.Departments.Query.GetAll
{
    public class GetAllDepartmentQueryHandler : IRequestHandler<GetAllDepartmentQuery, List<GetAllDepartmentDots>>
    {
        private readonly IManger<Department> manger;
        private readonly IMapper mapper;

        public GetAllDepartmentQueryHandler(IManger<Department> manger, IMapper mapper)
        {
            this.manger = manger;
            this.mapper = mapper;
        }

        public async Task<List<GetAllDepartmentDots>> Handle(GetAllDepartmentQuery request, CancellationToken cancellationToken)
        {
            var departments = manger.GetAll().ToList();

            return mapper.Map<List<GetAllDepartmentDots>>(departments);
        }
    }
}
