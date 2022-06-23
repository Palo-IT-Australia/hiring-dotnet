using Microsoft.EntityFrameworkCore;
using Wallboard.Models;

namespace Wallboard;

public class WallboardContext: DbContext
{
    public DbSet<Post> Posts { get; set; }

    public WallboardContext(DbContextOptions<WallboardContext> options): base(options)
    {
        
    }
}