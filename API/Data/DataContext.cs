using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions option) : base(option)
    {
        
    }

    public DbSet<AppUser> AppUsers { get; set; }
}
