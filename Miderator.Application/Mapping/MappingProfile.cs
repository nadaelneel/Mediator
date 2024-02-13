using AutoMapper;
using Mediator.Application.Features.Departments.Command.Delete;
using Mediator.Application.Features.Departments.Command.Post;
using Mediator.Application.Features.Departments.Command.Put;
using Mediator.Application.Features.Departments.Query.GetAll.Dots;
using Mediator.Application.Features.Users.Command.Delete;
using Mediator.Application.Features.Users.Command.Post;
using Mediator.Application.Features.Users.Command.Put;
using Mediator.Application.Features.Users.Query.GetAll.DOTs;
using Mediator.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            #region Department
            CreateMap<Department, GetAllDepartmentDots>();
            CreateMap<PostDepaetmentCommand, Department>();
            //CreateMap<PutDepartmentCommand,Department>();
            CreateMap<DeleteDepartmentCommand,Department>();
            #endregion

            #region User
            CreateMap<User, GetAllUserDots>();
            CreateMap<PostUserCommand, User>();
            //CreateMap<PutUserCommand, User>();
            CreateMap<DeleteUserCommand, User>();
            #endregion
        }

    }
}
