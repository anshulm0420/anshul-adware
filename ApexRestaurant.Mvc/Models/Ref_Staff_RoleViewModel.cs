using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Mvc.Models
{
    public class Ref_Staff_RoleViewModel{
        [Key]
        public int Staff_Role_Code {get; set;}
        public string Staff_Role_Description{get; set;}
        
    }
}
