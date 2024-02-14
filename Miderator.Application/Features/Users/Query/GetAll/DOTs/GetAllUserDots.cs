using Mediator.Application.Features.Departments.Query.GetAll.Dots;
using Mediator.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Features.Users.Query.GetAll.DOTs
{
    public class GetAllUserDots
    {
        public int Id { set; get; }
        public string Name { get; set; }

        public String DepartmentName { get; set; }
    }
}
