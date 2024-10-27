using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//DataContext is the class that has inherited the DbContext and through dependency injection the options will be passed to the constructor
builder.Services.AddDbContext<DataContext>(opt => 
{

    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

//Middleware
// Configure the HTTP request pipeline.

app.MapControllers();

//Middleware end
app.Run();
