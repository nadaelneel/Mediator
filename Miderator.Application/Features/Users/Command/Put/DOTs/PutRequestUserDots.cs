using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Features.Users.Command.Put.DOTs
{
    public class PutRequestUserDots
    {
        public string Name { get; set; }

        public bool IsDelete { get; set; }
    }
}
