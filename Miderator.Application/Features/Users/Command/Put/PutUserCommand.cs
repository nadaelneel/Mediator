using MediatR;
using Miderator.Application.Features.Departments.Command.Put.DTOs;
using Miderator.Application.Features.Users.Command.Put.DOTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Users.Command.Put
{
    public class PutUserCommand : IRequest
    {
        public Guid Id { get; set; }

        public PutRequestUserDots PutRequestUserDots { get; set; }
    }
}
