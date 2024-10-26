using MediatR;
using Microsoft.EntityFrameworkCore;
using Serilog;
using ShippingService.Features.Shipments.GetShipmentByNumber;
using ShippingService.Infrastructure.Database;
using ShippingService.Infrastructure.Seeding;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((context, loggerConfig) => loggerConfig.ReadFrom.Configuration(context.Configuration));

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddFeatures(builder.Configuration);

builder.Services.AddScoped<ShipmentService>();
builder.Services
	.AddEndpointsApiExplorer()
	.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{   // Required for first run of API if data is not presented.
    //var dbContext = scope.ServiceProvider.GetRequiredService<ShippingDbContext>();
    //await dbContext.Database.MigrateAsync();

    //var seedService = scope.ServiceProvider.GetRequiredService<SeedService>();
    //await seedService.SeedDataAsync();
    
    //
    var shipmentService = scope.ServiceProvider.GetRequiredService<ShipmentService>();
    var shipmentResponse = await shipmentService.GetShipmentByNumberAsync("0");
    Console.WriteLine("API warmed up successfully.");
}

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapFeatures();

app.Run();
