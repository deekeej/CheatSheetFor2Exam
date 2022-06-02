using ExerciseWithManyToManyAtd.Database;
using ExerciseWithManyToManyAtd.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddScoped<ServiceForEverything>();
ConfigureDb(builder.Services);
var app = builder.Build();


app.UseRouting();
app.MapControllers();
app.Run();

static void ConfigureDb(IServiceCollection Services)
{
    var config = Services.BuildServiceProvider().GetService<IConfiguration>();
    var connectionString = config.GetConnectionString("DefaultConnection");
    Services.AddDbContext<ApplicationDbContext>(b => b.UseSqlServer(connectionString));

}