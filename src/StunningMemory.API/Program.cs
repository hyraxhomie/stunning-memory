using Microsoft.EntityFrameworkCore;
using StunningMemory.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddControllers();
builder.Services.AddDbContext<StunningMemoryDbContext>( options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("StunningMemoryDb")));


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseHttpsRedirection();
app.Run();