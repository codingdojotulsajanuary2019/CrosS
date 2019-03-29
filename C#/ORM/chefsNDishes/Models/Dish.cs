using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace chefsNDishes.Models
{
    public class Dish
    {
       [Key]
        public int DishId {get;set;}
        public string DishName {get;set;}
        public int Calories {get;set;}
        public string Description {get;set;}
        public int Tastiness {get;set;}
        public int ChefId {get;set;}
        public Chef Creator {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
    public class AllDishes
    {
        public List<Dish> alldish {get;set;}
    }
}