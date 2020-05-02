using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Repository.Domain{
    public class Meal{
        [Key]
        public int Meal_Id { get; set; }    
        public int Customer_Id { get; set; }
        public int Staff_id { get; set; }
        public DateTime Date_Of_Meal { get; set; }
        public int Cost_Of_Meal { get; set; }   
        public string Other_Details { get; set; }
    }
}