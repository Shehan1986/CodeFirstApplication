using CodeFirstApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApplication.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<OrderRow> OrderRows { get; set; }

    }
}
