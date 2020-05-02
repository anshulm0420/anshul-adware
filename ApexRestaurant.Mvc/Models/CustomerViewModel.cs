using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Mvc.Models
{
 public class CustomerViewModel
 {
     [Key]
     [ScaffoldColumn(false)]
    public int Customer_Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PhoneRes { get; set; }
    public string PhoneMob { get; set; }
    public DateTime EnrollDate { get; set; }
    public bool IsActive { get; set; }
    [ScaffoldColumn(false)]
    public string CreatedBy { get; set; }
    [ScaffoldColumn(false)]
    public DateTime CreatedOn { get; set; }
    [ScaffoldColumn(false)]
    public string UpdatedBy { get; set; }
    [ScaffoldColumn(false)]
    public DateTime UpdatedOn { get; set; }
 }
}