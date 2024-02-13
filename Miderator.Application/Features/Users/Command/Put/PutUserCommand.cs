using MediatR;
using Mediator.Application.Features.Departments.Command.Put.DTOs;
using Mediator.Application.Features.Users.Command.Put.DOTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Features.Users.Command.Put
{
    public class PutUserCommand : IRequest
    {
        public int Id { get; set; }

        public PutRequestUserDots PutRequestUserDots { get; set; }
    }
}
