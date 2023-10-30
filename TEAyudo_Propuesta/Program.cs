using Application.Interface.acompanantes;
using Application.Interface.Propuestas;
using Application.Interface.Tutores;
using Application.UseCase;
using Infrastructure.Command;
using Infrastructure.Persistence;
using Infrastructure.Querys;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// custom

var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<TEAyudoContext>(options => options.UseSqlServer(connectionString));

// inyecciones de dependencias

builder.Services.AddScoped<IPropuestaService, PropuestaService>();
builder.Services.AddScoped<IPropuestaCommand, PropuestaCommand>();
builder.Services.AddScoped<IPropuestaQuery, PropuestaQuery>();
builder.Services.AddScoped<IAcompananteQuery, AcompananteQuery>();
builder.Services.AddScoped<ITutorQuery, TutorQuery>();

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
