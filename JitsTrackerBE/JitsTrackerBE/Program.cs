using JitsTrackerBE.Data;
using JitsTrackerBE.Features.Techniques.MoveGeneratorHandler;
using JitsTrackerBE.Features.Techniques.TechniqueGeneratorHandler;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<TechniqueGeneratorHandler>();
builder.Services.AddScoped<MoveGeneratorHandler>();

string connection = builder.Configuration.GetConnectionString("JitsTrackerBE");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connection, ServerVersion.AutoDetect(connection)));
        
// Add services to the container.
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
app.UseRouting();
app.MapControllers();

app.Run();