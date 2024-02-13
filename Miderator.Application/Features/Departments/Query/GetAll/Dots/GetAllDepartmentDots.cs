using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Departments.Query.GetAll.Dots
{
    public class GetAllDepartmentDots
    {
        public Guid Id { set; get; }
        public string Name { get; set; }

        public List<string> UsersName { get; set; }
    }
}
