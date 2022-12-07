using eETC.Models;
using Microsoft.EntityFrameworkCore;

namespace eETC.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }


        public DbSet<Product> Products { get; set; }
        public DbSet<State> States { get; set; }


        //orders

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems{ get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<AdditionalData> AdditionalDatas { get; set; }

    }
}
