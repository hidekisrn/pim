using Microsoft.EntityFrameworkCore;
using Product.Inventory.Management.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("SampleDbConnection");
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ProductContext>(opt =>
        opt.UseNpgsql(connectionString, b => b.MigrationsAssembly("Product.Inventory.Management.API")), ServiceLifetime.Transient);

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

