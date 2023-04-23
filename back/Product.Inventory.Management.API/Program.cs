using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Product.Inventory.Management.API.Mappers;
using Product.Inventory.Management.Infrastructure;
using MediatR;
using Product.Inventory.Management.Infrastructure.Interfaces;
using Product.Inventory.Management.Infrastructure.PostgreSQL.Repositories;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureMappings();
builder.Services.AddMediatR(AppDomain.CurrentDomain.Load("Product.Inventory.Management.Application"));

#region Repositories
builder.Services.AddTransient<IProductRepository, ProductRepository>();
#endregion

#region DbConnection
var connectionString = builder.Configuration.GetConnectionString("SampleDbConnection");
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Product.Inventory.Management.Infrastructure.DbContext>(opt =>
        opt.UseNpgsql(connectionString, b => b.MigrationsAssembly("Product.Inventory.Management.API")), ServiceLifetime.Transient);
#endregion
#endregion
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

