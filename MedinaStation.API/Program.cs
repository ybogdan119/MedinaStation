using MedinaStation.API.Extensions;
using MedinaStation.Data;
using MedinaStation.Domain.Settings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MedinaDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.Configure<RingSettings>(
    builder.Configuration.GetSection("RingSettings"));

builder.Services.AddIdentityInfrastructure(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();