using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [Route("user")]
        [HttpGet]
        public IActionResult Index()
        {
            User somePerson = new User()
            {
                FirstName = "Joey",
                LastName = "Steinfield"
            };

            return View(somePerson);
        }


        [HttpGet("")]
        public IActionResult Message()
        {
            Message someMessage = new Message()
            {
                Content = "Hey everybody! Lorem Ipsum Blah Blah!"
            };

            return View(someMessage);
        }


        [HttpGet("numbers")]
        public IActionResult MyArray()
        {
            int[] someArray = new int[]
            {
                1,2,3,4,5,8
            };
            return View(someArray);
        }

        [HttpGet("people")]
        public IActionResult People()
        {
            User Cros = new User()
            {
                FirstName = "Cros",
                LastName = "Sikes"
            };
            User Zach = new User()
            {
                FirstName = "Zach",
                LastName = "Sykes"
            };

            List<User> viewModel = new List<User>()
            {
                Cros, Zach
            };

            return View("ListofUsers", viewModel);
        }
    }
}
