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
builder.Services.AddCors();
var app = builder.Build();

//Middleware
// Configure the HTTP request pipeline.
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200","https://localhost:4200"));
//Cors Cross origin resourse sharing a security feature in web pages to differnt requests 
//Api Servr 6000
//Angular server 4200
app.MapControllers();

//Middleware end
app.Run();
