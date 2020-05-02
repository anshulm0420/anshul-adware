using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Repository.Domain{
    public class Menu{
        [Key]
        public int Menu_Id { get; set; }
        public string Menu_Name { get; set; }
        public DateTime Available_Date_From { get; set; }
        public DateTime Available_Date_To { get; set; }
        public string Other_Details { get; set; }
    }
}