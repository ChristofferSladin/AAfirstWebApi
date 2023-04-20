using AAfirstWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AAfirstWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }

}
