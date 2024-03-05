using Fusca.Dashboard.Services.Stiba;
using System.Text;
using Fusca.Dashboard.Repository;


var key = Encoding.ASCII.GetBytes("d8cf9a98-bfb2-4e0a-85b3-7c94f8e908ad");

var builder = WebApplication.CreateBuilder(args);
var configBuilder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = configBuilder.Build();



// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IStibaService, StibaService>();
builder.Services.AddScoped<IStibaRepository>(_ => new StibaRepository(configuration["DB_CONFIG"]));

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
