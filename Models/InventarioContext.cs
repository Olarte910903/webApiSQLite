using Microsoft.EntityFrameworkCore;

namespace practicaApiSQLite;

public class InventarioContext : DbContext
{
    public InventarioContext(DbContextOptions<InventarioContext> options):base(options){}

    public DbSet<Item> items {get;set;}
}
