using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Features.Departments.Command.Post
{
    public class PostDepaetmentCommand : IRequest
    {
        public string Name { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
