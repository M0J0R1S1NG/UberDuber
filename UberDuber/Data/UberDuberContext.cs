using UberDuber.Models;
using Microsoft.EntityFrameworkCore;


namespace UberDuber.Data
{
    public class UberDuberContext : DbContext
    {
        public UberDuberContext(DbContextOptions<UberDuberContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventorys { get; set; }
    }
}