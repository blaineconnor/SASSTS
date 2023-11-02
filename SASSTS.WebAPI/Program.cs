using SASSTS.Business;
using SASSTS.Business.Implementations;
using SASSTS.Business.Interfaces;
using SASSTS.DataAccess;
using SASSTS.DataAccess.EntityFramework;
using SASSTS.DataAccess.EntityFramework.Repositories;
using SASSTS.DataAccess.Interfaces;
using SASSTS.WebAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddApiServices(builder.Configuration);
builder.Services.AddBusinessServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
