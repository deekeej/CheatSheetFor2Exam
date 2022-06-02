using Microsoft.EntityFrameworkCore;
using OrientationExamTryJava.Database;
using OrientationExamTryJava.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
ConfigureDb(builder.Services);
builder.Services.AddScoped<AliasService>();
var app = builder.Build();

app.MapControllers();   
app.Run();

static void ConfigureDb(IServiceCollection Services)
{
    var config = Services.BuildServiceProvider().GetService<IConfiguration>();
    var connectionString = config.GetConnectionString("DefaultConnection");
    Services.AddDbContext<ApplicationDbContext>(b => b.UseSqlServer(connectionString));

}