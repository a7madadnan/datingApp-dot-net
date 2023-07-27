using API.data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt=>
{
opt.UseSqlite(builder.Configuration.GetConnectionString("DefaulConnection"));
});

var app = builder.Build();

app.MapControllers();

app.Run();
