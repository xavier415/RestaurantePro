using Microsoft.EntityFrameworkCore;
using RestaurantePro.Pedido.IOC.Dependencies;
using RestaurantePro.Pedido.Persistance.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RestauranteContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("RestauranteContext")));

// Agregar las dependencias del modulo de pedidos
builder.Services.AddPedidoDependency();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews().ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
