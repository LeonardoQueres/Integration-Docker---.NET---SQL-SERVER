using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;
using Thunders_Api.Configurations;
using Thunders_Api.Extensions;
using Thunders_Api.Middlewares;
using Thunders_Repositories.DataContext;

var builder = WebApplication.CreateBuilder(args);

var appConfig = builder.Configuration.LoadConfiguration();

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    }).ConfigureApiBehaviorOptions(options => options.InvalidModelStateResponseFactory = InvalidModelStateResponseFactory.CreateResponse); ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("Thunders_Repositories"));
});

builder.Services.AddSingleton(appConfig);
builder.Services.AddMemoryCache();
builder.Services.AddHttpContextAccessor();
builder.Services.AddUseCases();
builder.Services.AddRepositories();
builder.Services.AddScoped<IActionResultConverter, ActionResultConverter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
    // Utilizando o migration a execução do container docker não é necessario as linhas abaixo
    //using (var scope = app.Services.CreateScope())
    //{
    //    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    //    db?.Database.Migrate();
    //}    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<ErrorHandlingMiddleware>();

app.MapControllers();

app.Run();
