using Microsoft.EntityFrameworkCore;

namespace CollectionTracker.Models
{
    public class CollectionTrackerDbContext : DbContext
    {

        private string? _connectionString;

        public DbSet<Collection> Collections { get; set; }
        public DbSet<Item> Items { get; set; }


        public CollectionTrackerDbContext()
        {

        }


        public CollectionTrackerDbContext(string connectionString)
        {
            _connectionString = connectionString;
            Database.Migrate();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={_connectionString}");
        }
    }
}