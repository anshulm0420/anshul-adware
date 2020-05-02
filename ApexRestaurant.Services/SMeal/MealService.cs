using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMeal;
namespace ApexRestaurant.Services.SMeal{
    public class MealService:GenericService<Meal>,IMealService{
        public MealService(IMealRepository mealRepository): base(mealRepository)
        {
            
        }
    }
}
