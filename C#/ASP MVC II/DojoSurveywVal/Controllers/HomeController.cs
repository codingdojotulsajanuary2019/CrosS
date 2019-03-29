using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveywVal.Models;

namespace DojoSurveywVal.Controllers
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
        public IActionResult Success(User form)
        {
            if(ModelState.IsValid)
            {
                return View("Success", form);
            }
            else
            {
                return View("Index");
            }
        }
    }


}
