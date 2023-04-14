using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SalaryCalculator.Application.Services;
using SalaryCalculator.Contract.IServices;
using SalaryCalculator.Contract.MappingConfiguration;
using SalaryCalculator.Infrustructure.Contexts;
using SalaryCalculator.Infrustructure.IRepositories;
using SalaryCalculator.Infrustructure.Repositories;
using SalaryCalculator.OvertimePolicies;
using SalaryCalculator.UI.Convertors;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Ordering HTTP API",
        Version = "v1",
        Description = "The Ordering Service HTTP API",
    });
});


builder.Services.AddHttpClient();

RegisterServices(builder);


builder.Services.AddDbContext<SalaryDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));


builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();
app.UseRouting();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseEndpoints(options =>
{
    options.Map("/", context =>
    {
        context.Response.Redirect("/Swagger");
        return Task.CompletedTask;
    });
    options.MapControllers();
});

app.Run();

static void RegisterServices(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<IWriteRepository, WriteRepository>();
    builder.Services.AddScoped<IReadRepository, ReadRepository>();
    builder.Services.AddScoped<ISalaryService, SalaryService>();
    builder.Services.AddSingleton<ConvertFactory>();
    builder.Services.AddTransient<ICalculatorSelector, OverTimeCalculatorA>();
    builder.Services.AddTransient<ICalculatorSelector, OverTimeCalculatorB>();
    builder.Services.AddTransient<ICalculatorSelector, OverTimeCalculatorC>();
    builder.Services.AddTransient<ICalculatorInvoker, CalculatorInvoker>();

}