using API.Entities;
using Microsoft.EntityFrameworkCore;

//define the namespace for this class
namespace API.Data;

//create a primary constructor for this new class by passing 
public class DataContext(DbContextOptions options) : DbContext(options)
{
  public DbSet<AppUser> Users { get; set; }
}
