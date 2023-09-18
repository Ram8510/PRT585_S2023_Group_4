using _2DataAccessLayer.Context.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context
{   

    public class DBEntitiesContext : DbContext
    {
        public DBEntitiesContext(DbContextOptions<DBEntitiesContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Instrument> Instruments { get; set; }

        public DbSet<Building> Buildings { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Club>  Clubs { get; set; }

        //security models
        public DbSet<UserAccount> UserAccounts { get; set; }

        public DbSet<SystemAction> SystemActions { get; set; }

    }

}
