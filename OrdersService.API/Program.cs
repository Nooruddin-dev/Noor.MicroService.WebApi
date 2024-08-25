using OrdersService.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using OrdersService.Application.Interfaces;
using OrdersService.Application.Services;
using OrdersService.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Register DbContexts
builder.Services.AddDbContext<ApplicationDbContext1>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString1")));


builder.Services.AddDbContext<ApplicationDbContext2>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString2")));

// Register repositories and services
builder.Services.AddScoped<OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();


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
