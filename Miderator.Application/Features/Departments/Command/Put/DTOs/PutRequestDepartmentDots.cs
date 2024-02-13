using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Features.Departments.Command.Put.DTOs
{
    public class PutRequestDepartmentDots
    {
        public string Name { get; set; }

        public bool IsDelete { get; set; }
    }
}
