using Microsoft.EntityFrameworkCore;
using API.Entity;
namespace API.Data;

// public class DataContext : DbContext
// {
//     protected DataContext(DbContextOptions options): base(options)
//     {
//     }
// }

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Users> ApplicationUsers {get; set;}
}
