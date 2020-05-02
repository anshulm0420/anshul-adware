using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Mvc.Models{
    public class Menu_ItemViewModel{
        [Key]
        public int Menu_Item_Id { get; set; }
        public int Menu_Id { get; set; }
        public string Menu_Item_Name { get; set; }
        public string Other_Details { get; set; }
        
    }
}