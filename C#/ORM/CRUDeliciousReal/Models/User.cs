using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace CRUDeliciousReal.Models
{
    public class User
    {
        [Key]
        public int dish_id {get;set;}

        [Required(ErrorMessage = "Chef Name required!")]
        public string ChefName {get;set;}

        [Required(ErrorMessage = "Dish Name is Required!")]
        [MinLength(3)]
        public string DishName {get;set;}

        public string Calories {get;set;}

        [Range(1,10)]
        public int Tastiness {get;set;}

        [MinLength(20)]
        [MaxLength(500)]
        public string Description {get;set;}
        public DateTime created_at {get;set;} = DateTime.Now;
    }

       public class User2
       {
            public List<User> AllDishes {get;set;}
       }
}