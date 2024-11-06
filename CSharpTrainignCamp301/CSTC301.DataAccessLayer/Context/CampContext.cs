using System.Data.Entity;
using CSTC301.EntityLayer.Concrete;

namespace CSTC301.DataAccessLayer.Context
{
    public class CampContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
