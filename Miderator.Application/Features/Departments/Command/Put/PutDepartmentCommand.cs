using MediatR;
using Miderator.Application.Features.Departments.Command.Put.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Departments.Command.Put
{
    public class PutDepartmentCommand : IRequest
    {
        public Guid Id { get; set; }

        public PutRequestDepartmentDots PutRequestDepartmentDots { get; set; }
    }
}
