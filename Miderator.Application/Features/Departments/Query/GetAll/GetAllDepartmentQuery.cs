using MediatR;
using Mediator.Application.Features.Departments.Query.GetAll.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Features.Departments.Query.GetAll
{
    public class GetAllDepartmentQuery : IRequest<List<GetAllDepartmentDots>>
    {
    }
}
