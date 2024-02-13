using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Departments.Query.GetAll.Dots
{
    public class GetAllDepartmentQuery : IRequest<List<GetAllDepartmentDots>>
    {
    }
}
