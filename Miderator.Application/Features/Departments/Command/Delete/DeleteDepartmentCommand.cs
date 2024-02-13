using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Departments.Command.Delete
{
    public class DeleteDepartmentCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
