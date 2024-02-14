using Mediator.Infrastracture;
using Mediator.Application;
using Microsoft.EntityFrameworkCore;
using Mediator.Infrastracture.Context;
using Mediator.Infrastracture.UniteOfWork;
using Mediator.Domains;
using WepAPI.Extension;
using Mediator.Application.Interface;

var builder = WebApplication.CreateBuilder(args);
//connection
// Add services to the container.

//builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(cb =>
//{
//    cb.RegisterAssemblyModules(typeof(Program).Assembly);
//})).ConfigureServices(services=>services.AddAutofac());

builder.Services.AddControllers();

//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

//builder.Services.AddAutoMapper(typeof(MappingProfile));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped(typeof(IUniteOfWork), typeof(UniteOfWork));
builder.Services.AddScoped(typeof(IManger<User>), typeof(UserManger));
builder.Services.AddScoped(typeof(IManger<Department>), typeof(DepartmentManeger));
builder.Services.AddAutoMapper(typeof(ApplicationLayer));
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining(typeof(ApplicationLayer)));

//builder.Services.AddUnitOfWorkRepository();
builder.Services.AddDbContext<MyDbContext>(i =>
{
    i.UseSqlServer(builder.Configuration.GetConnectionString("AppDB"));
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
