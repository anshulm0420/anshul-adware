using ApexRestaurant.Repository.Domain;
namespace ApexRestaurant.Repository.RMeal{
    public class MealRepository:GenericRepository<Meal>,IMealRepository{
        public MealRepository(RestaurantContext dbContext)
        {
            DbContext=dbContext;
        }
    }
}