using DbConfigLib;
using Microsoft.EntityFrameworkCore;

namespace EF_MySql_Demo;

public class DB : DbContext
{
    public DbSet<Person> TablePersons => Set<Person>();
    
    public DB()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(DbConfig.ImportFromJson("db.json").ToString());
    }
}