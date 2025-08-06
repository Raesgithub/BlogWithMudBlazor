using BlazorAppSamsar.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppSamsar.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
