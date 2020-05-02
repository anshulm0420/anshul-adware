using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Repository.RCustomer;
using ApexRestaurant.Repository.RMeal;
using ApexRestaurant.Repository.RMeal_Dish;
using ApexRestaurant.Repository.RMenu;
using ApexRestaurant.Repository.RMenu_Item;
using ApexRestaurant.Repository.RRef_Staff_Role;
using ApexRestaurant.Repository.RStaff;
namespace ApexRestaurant.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection,string migrationsAssembly)
        {
            services.AddDbContext<RestaurantContext>(options =>
            options.UseSqlServer(connection, builder =>
            builder.MigrationsAssembly(migrationsAssembly)));
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IMealRepository, MealRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();
            services.AddTransient<IMeal_DishRepository, Meal_DishRepository>();
            services.AddTransient<IMenu_ItemRepository, Menu_ItemRepository>();
            services.AddTransient<IRef_Staff_RoleRepository, Ref_Staff_RoleRepository>();

        }
    }
}