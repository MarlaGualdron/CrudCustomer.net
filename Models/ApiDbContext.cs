using Microsoft.EntityFrameworkCore;

namespace CrudCustomers.Api.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public Dbset<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CustomerMap(modelBuilder.Entity<Customer>());
        }

    }
}
