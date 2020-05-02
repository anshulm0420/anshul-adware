using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Mvc.Models
{
    public class Meal_DishViewModel
    {
        [Key]
        public int Meal_Dish_Id { get; set; }
        public int Meal_Id { get; set; }
        public int Menu_Item_Id { get; set; }
        public int Quantity { get; set; }
    }
}