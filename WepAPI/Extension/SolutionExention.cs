using Mediator.Application;
using Mediator.Domains;
using Mediator.Application.Interface;
using Mediator.Infrastracture.UniteOfWork;

namespace WepAPI.Extension
{
    public static class SolutionExention
    {
        public static void AddUnitOfWorkRepository(this IServiceCollection service)
        {
            //service.AddScoped(typeof(IUniteOfWork), typeof(UniteOfWork));
            //service.AddScoped(typeof(IManger<User>), typeof(UserManger));
            //service.AddScoped(typeof(IManger<Department>), typeof(DepartmentManeger));
            //service.AddAutoMapper(typeof(ApplicationLayer));
            //service.AddMediatR(config => config.RegisterServicesFromAssemblyContaining(typeof(ApplicationLayer)));
            //service.AddHttpContextAccessor();
            //service.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
