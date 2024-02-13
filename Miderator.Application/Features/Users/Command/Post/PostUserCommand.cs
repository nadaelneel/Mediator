using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Users.Command.Post
{
    public class PostUserCommand : IRequest
    {
        public string Name { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
