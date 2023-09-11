using Microsoft.EntityFrameworkCore;
using WebApplication_API.Models;

namespace WebApplication_API.Data
{
    public class WebApiDbContext : DbContext
    {
        private DbSet<Book> myProperty;

        public WebApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }         
    }
}
    