using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Repository.Domain
{
    public class Ref_Staff_Role{
        [Key]
        public int Staff_Role_Code {get; set;}
        public string Staff_Role_Description{get; set;}
        
    }
}
