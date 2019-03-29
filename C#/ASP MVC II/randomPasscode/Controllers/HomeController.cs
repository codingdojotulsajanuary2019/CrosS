using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using randomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace randomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            int? Count = HttpContext.Session.GetInt32("count");
            if(Count == null)
            {
                HttpContext.Session.SetInt32("count", 0);
            }
            else
            {
                Count = Count + 1;
                HttpContext.Session.SetInt32("count", (int)Count);
            }

            ViewBag.Count = HttpContext.Session.GetInt32("count");
            return View();
        }

        [Route("clear")]
        [HttpGet]
        public IActionResult Clear()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
