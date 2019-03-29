using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace chefsNDishes.Models
{
    public class All
    {
        public List<Chef> theChefs {get;set;}
        public Dish newDish {get;set;}
    }
}