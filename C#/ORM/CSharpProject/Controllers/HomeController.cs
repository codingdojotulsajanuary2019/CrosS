using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSharpProject.Models;

namespace CSharpProject.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpGet("registeruser")]
        public IActionResult SubmitUser()
        {
            return RedirectToAction("Success");
        }
        [HttpGet("Success")]
        public IActionResult Success()
        {
            return View("Success");
        }

        [HttpGet("registerdetails")]
        public IActionResult SubmitDetails()
        {
            return View("Stats");
        }
        [HttpGet("registerstats")]
        public IActionResult FinishSubmit()
        {
            return RedirectToAction("MainEvent");
        }

        [HttpGet("login")]
        public IActionResult LoginPage()
        {
            return View("Index");
        }
        [HttpGet("loggingin")]
        public IActionResult LoggingIn()
        {
            return RedirectToAction("MainEvent");
        }

        [HttpGet("mainevent")]
        public IActionResult MainEvent()
        {
            return View("mainevent");
        }

    }
}
