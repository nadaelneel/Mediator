using MediatR;
using Miderator.Application.Features.Users.Query.GetAll.DOTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Application.Features.Users.Query.GetAll
{
    public class GetAllUserQuery : IRequest<List<GetAllUserDots>>
    {
    }
}
