using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using FluentValidation.AspNetCore;
using FluentValidation;
using Infraestructure.Persistence;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Application.Mappings;
using Application.Validators.Almacen;
using AppLogic.Validators.Cliente;
using AppLogic.Validators.Direccion;
using AppLogic.Validators.Articulo;
using AppLogic.Validators.Inventario;
using AppLogic.Validators.Ubicacion;
using AppLogic.Mappings;
using AppLogic.Interfaces;
using AppLogic.Services;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("https://localhost:4499");

// Add services to the container.

builder.Services.AddControllers();

//FLUENT VALIDATION
builder.Services.AddFluentValidationAutoValidation(); // Middleware de validación automática
builder.Services.AddFluentValidationClientsideAdapters(); // Adaptador para validación en cliente (si hacés Blazor, Razor o MVC)

// Registra todos los validadores
builder.Services.AddValidatorsFromAssemblyContaining<CrearClienteDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateClienteDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CrearDireccionDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateDireccionDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CrearArticuloDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CrearAlmacenDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CrearInventarioDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CrearUbicacionDtoValidator>();

//AutoMapper
builder.Services.AddAutoMapper(typeof(ClienteProfile));
builder.Services.AddAutoMapper(typeof(DireccionProfile));
builder.Services.AddAutoMapper(typeof(ArticuloProfile));
builder.Services.AddAutoMapper(typeof(AlmacenProfile));
builder.Services.AddAutoMapper(typeof(UbicacionProfile));
builder.Services.AddAutoMapper(typeof(InventarioProfile));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("WebAPIContext");

builder.Services.AddDbContext<AppDbContext>(options => 
options.UseMySql(builder.Configuration.GetConnectionString("WebAPIContext"), ServerVersion.AutoDetect(connectionString)));

//CLIENTE
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();

//DIRECCION
builder.Services.AddScoped<IDireccionRepository, DireccionRepository>();
builder.Services.AddScoped<IDireccionService, DireccionService>();

//ARTICULO
builder.Services.AddScoped<IArticuloRepository, ArticuloRepository>();
builder.Services.AddScoped<IArticuloService, ArticuloService>();

//ALMACEN
builder.Services.AddScoped<IAlmacenRepository, AlmacenRepository>();
builder.Services.AddScoped<IAlmacenService, AlmacenService>();

//UBICACION
builder.Services.AddScoped<IUbicacionRepository, UbicacionRepository>();
builder.Services.AddScoped<IUbicacionService, UbicacionService>();

//INVENTARIO
builder.Services.AddScoped<IInventarioRepository, InventarioRepository>();
builder.Services.AddScoped<IInventarioService, InventarioService>();

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
