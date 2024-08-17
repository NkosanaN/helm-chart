using Microsoft.EntityFrameworkCore;

namespace Docker7;

public class DataContext : DbContext
{
    public DataContext() { }
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Tag> Tag { get; set; }
    public DbSet<Company> Companies { get; set; }
}
