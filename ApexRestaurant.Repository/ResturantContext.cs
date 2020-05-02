using Microsoft.EntityFrameworkCore;
using ApexRestaurant.Repository.Domain;
namespace ApexRestaurant.Repository
{
    public class RestaurantContext : DbContext
    {

        public RestaurantContext(DbContextOptions<RestaurantContext> options) :
        base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Meal_Dish> Meal_Dishes{ get; set; }
        public DbSet<Meal> Meals{ get; set; }
        public DbSet<Menu_Item> Menu_Items { get; set; }
        public DbSet<Menu> Menus { get; set; }  
        public DbSet<Ref_Staff_Role> Ref_Staff_Roles { get; set; }
        public DbSet<Staff> Staff { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}