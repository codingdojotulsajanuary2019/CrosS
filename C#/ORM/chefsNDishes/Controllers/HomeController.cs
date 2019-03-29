using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace chefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [Route("")]
        [HttpGet]
        public IActionResult Home()
        {
            return View("dishes");
        }
        [HttpGet("chefs")]
        public IActionResult ChefDisplay()
        {
            AllChefs theChefs = new AllChefs
            {
                theChefs = dbContext.Chefs.Include(chef => chef.CreatedDishes).ToList()
            };
            return View("chefs", theChefs);
        }



        [Route("addChef")]
        [HttpGet]
        public IActionResult AddChef()
        {
            return View("addChef");
        }
        [HttpPost("createChef")]
        public IActionResult CreateChef(Chef newChef)
        {
            dbContext.Add(newChef);
            dbContext.SaveChanges();
            return RedirectToAction("ChefDisplay");
        }



        [HttpGet("addDish")]
        public IActionResult AddDish()
        {
            All theChefs = new All()
            {
                theChefs = dbContext.Chefs.ToList()
            };

            return View("addDish", theChefs);
        }
        [HttpPost("createDish")]
        public IActionResult CreateDish(Dish newDish)
        {
            dbContext.Add(newDish);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }
    }
}
