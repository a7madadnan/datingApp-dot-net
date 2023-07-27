using API.data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt=>
{

});

var app = builder.Build();

app.MapControllers();

app.Run();
