using Miderator.Infrastracture;
using Miderator.Application;
var builder = WebApplication.CreateBuilder(args);
//connection
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();
// Add services to the container.
//builder.Services.AddDbContext<my>(i =>
//{
//    i.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("AppDB"));
//});
builder.Services.AddControllers();

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
