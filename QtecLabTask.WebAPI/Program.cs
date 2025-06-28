using Microsoft.EntityFrameworkCore;
using QtecLabTask.Core;
using QtecLabTask.Core.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DB Connection using DI
builder.Services.AddInfrastructure(builder.Configuration);

//DB Connection
//builder.Services.AddDbContext<QtecLabDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnectionString"));
//});

//IOC

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
