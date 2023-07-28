using cinema_admin.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace cinema_admin.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Movie> Movie { get; set; }
        
    }
}