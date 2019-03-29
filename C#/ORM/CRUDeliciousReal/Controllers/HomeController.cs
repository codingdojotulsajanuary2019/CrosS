using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDeliciousReal.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDeliciousReal.Controllers
{
    public class HomeController : Controller
    {
        private CRUDContext dbContext;

        public HomeController(CRUDContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
           User2 AllDishes = new User2()
           {
               AllDishes = dbContext.dishes.ToList()
           };
            return View("Index", AllDishes);
        }

        [HttpPost("create")]
        public IActionResult CreateUser(User newUser)
        {
            if(ModelState.IsValid)
            {
                dbContext.dishes.Add(newUser);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New");
            }
        }

        [HttpPost("edit/{dishid}")]
        public IActionResult UpdateUser(int dishid, User newUser)
        {
            User AllDishes = dbContext.dishes.FirstOrDefault(user => user.dish_id == dishid);
            Console.WriteLine(AllDishes);
            if(ModelState.IsValid)
            {
                AllDishes.ChefName = newUser.ChefName;
                AllDishes.DishName = newUser.DishName;
                AllDishes.Calories = newUser.Calories;
                AllDishes.Tastiness = newUser.Tastiness;
                AllDishes.Description = newUser.Description;
                AllDishes.created_at = DateTime.Now;
                dbContext.SaveChanges();
            }
            else{
                return View("Edit");
            }
            return RedirectToAction("Index");
        }

        [HttpGet("delete/{dishid}")]
        public IActionResult DeleteUser(int dishid)
        {
            User AllDishes = dbContext.dishes.SingleOrDefault(user => user.dish_id == dishid);
            dbContext.dishes.Remove(AllDishes);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View("New");
        }

        [HttpGet("{dishid}")]
        public IActionResult ViewDish(int dishid)
        {
            User AllDishes =  dbContext.dishes.FirstOrDefault(dish => dish.dish_id == dishid);
            return View("View", AllDishes);
        }
         [HttpGet("startedit/{dishid}")]
         public IActionResult StartEdit(int dishid)
         {
            User AllDishes = dbContext.dishes.FirstOrDefault(user => user.dish_id == dishid);
            return View("Edit", AllDishes);
         }
    }
}
