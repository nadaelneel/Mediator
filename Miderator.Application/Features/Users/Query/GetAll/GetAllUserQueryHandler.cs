using AutoMapper;
using MediatR;
using Mediator.Application.Features.Departments.Query.GetAll.Dots;
using Mediator.Application.Features.Users.Query.GetAll.DOTs;
using Mediator.Domains;
using Mediator.Infrastracture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Features.Users.Query.GetAll
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<GetAllUserDots>>
    {
        private readonly IManger<User> manger;
        private readonly IMapper mapper;

        public GetAllUserQueryHandler(IManger<User> manger, IMapper mapper)
        {
            this.manger = manger;
            this.mapper = mapper;
        }

        public async Task<List<GetAllUserDots>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = manger.GetAll().ToList();

            var result = mapper.Map<List<GetAllUserDots>>(users);

            return result;
        }
    }
}
