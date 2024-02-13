using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Users.Command.Delete
{
    public class DeleteUserCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
