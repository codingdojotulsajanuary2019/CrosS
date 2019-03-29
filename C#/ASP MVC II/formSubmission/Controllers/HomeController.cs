using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formSubmission.Models;

namespace formSubmission.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("success")]
        public IActionResult Success(User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("GoodJob");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("GoodJob")]
        public IActionResult GoodJob()
        {
            return View("Success");
        }
    }
}
