using Microsoft.EntityFrameworkCore;
using SalaryCalculator.Infrustructure.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<SalaryDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();