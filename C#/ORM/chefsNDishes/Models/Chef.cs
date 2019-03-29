using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace chefsNDishes.Models
{
    public class Chef
    {
       [Key]
        public int ChefId {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public DateTime DOB {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Dish> CreatedDishes {get;set;}
    }
    public class AllChefs
    {
        public List<Chef> theChefs {get;set;}
    }
}