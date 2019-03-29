using Microsoft.AspNetCore.Mvc;
namespace Portfolio2
{
    public class HomeController : Controller
    {
        //Requests
        //localhost:5000/
        [HttpGet("")]
        public IActionResult AboutMe()
        {
            return View("Index");
        }
        //localhost:5000/hello
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }
        
        //localhost:5000/users/????
        [HttpGet("contact")]
        public IActionResult HelloUser(string username)
        {
            return View("Contact");
        }
    }
}