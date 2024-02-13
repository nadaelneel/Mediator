using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Users.Query.GetAll.DOTs
{
    public class GetAllUserDots
    {
        public Guid Id { set; get; }
        public string Name { get; set; }

        public string DepartmentName { get; set; }
    }
}
