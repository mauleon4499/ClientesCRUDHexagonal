using Application.Interfaces;
using Application.Services;
using Application.Validators;
using Domain.Interfaces;
using FluentValidation.AspNetCore;
using FluentValidation;
using Infraestructure.Persistence;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//FLUENT VALIDATION
builder.Services.AddFluentValidationAutoValidation(); // Middleware de validación automática
builder.Services.AddFluentValidationClientsideAdapters(); // Adaptador para validación en cliente (si hacés Blazor, Razor o MVC)
builder.Services.AddValidatorsFromAssemblyContaining<CrearClienteDtoValidator>(); // Registra todos los validadores

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(
    builder.Configuration.GetConnectionString("WebAPIContext")));

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();

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
