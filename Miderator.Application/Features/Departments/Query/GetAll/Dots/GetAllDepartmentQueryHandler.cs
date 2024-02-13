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

namespace Miderator.Application.Features.Departments.Query.GetAll.Dots
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
