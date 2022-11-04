using CrudCustomers.Api.Maps;
using Microsoft.EntityFrameworkCore;

namespace CrudCustomers.Api.Models{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
       : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new CustomerMap(modelBuilder.Entity<Customer>());
        }
    }
    #pragma warning restore CS1591
}
