using DDD.PatientDetails.Application.API;
using DDD.PatientDetails.Application.API.Queries;
using DDD.PatientDetails.Domain.Interfaces.Repository;
using DDD.PatientDetails.Domain.Interfaces.Services;
using DDD.PatientDetails.Domain.Services;
using DDD.PatientDetails.Infrastructure;
using DDD.PatientDetails.Infrastructure.Models;
using DDD.PatientDetails.Infrastructure.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

builder.Services.AddDbContext<userDbContext>(option => option
.UseSqlServer(builder.Configuration.GetConnectionString("DataBaseConnectionString")));

builder.Services.AddMediatR(Assembly.GetCallingAssembly());

builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(options => options.WithOrigins("http://localhost:3000/").
    AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());

app.UseHttpsRedirection();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

