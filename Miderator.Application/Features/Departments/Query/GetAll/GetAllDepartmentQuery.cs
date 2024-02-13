using MediatR;
using Miderator.Application.Features.Departments.Query.GetAll.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Departments.Query.GetAll
{
    public class GetAllDepartmentQuery : IRequest<List<GetAllDepartmentDots>>
    {
    }
}
