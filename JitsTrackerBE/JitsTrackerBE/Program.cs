using JitsTrackerBE.Data;
using JitsTrackerBE.Features.Techniques;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
//builder.Services.AddScoped<IMoveGeneratorHandler, MoveGeneratorHandler>();
builder.Services.AddScoped<ITechniqueGeneratorHandler, TechniqueGeneratorHandler>();

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