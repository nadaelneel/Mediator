using Mediator.Infrastracture;
using Mediator.Application;
using Microsoft.EntityFrameworkCore;
using Mediator.Infrastracture.Context;
using MediatR;
using System.Reflection;
using Mediator.Application.Mapping;
using Mediator.Infrastracture.Repository;
using Mediator.Infrastracture.UniteOfWork;
using Mediator.Domains;
using Mediator.Application.Manger;

var builder = WebApplication.CreateBuilder(args);
//connection
// Add services to the container.
builder.Services.AddDbContext<MyDbContext>(i =>
{
    i.UseSqlServer(builder.Configuration.GetConnectionString("AppDB"));
});
builder.Services.AddScoped(typeof(IUniteOfWork), typeof(UniteOfWork));
builder.Services.AddScoped(typeof(IManger<User>), typeof(UserManger));
builder.Services.AddScoped(typeof(IManger<Department>), typeof(DepartmentManeger));
builder.Services.AddControllers();

//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
//builder.Services.AddAutoMapper(typeof(MappingProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
