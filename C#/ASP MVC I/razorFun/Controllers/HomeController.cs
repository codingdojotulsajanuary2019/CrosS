using Microsoft.AspNetCore.Mvc;
namespace razorFun
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Render()
        {
            return View("index");
        }
    }
}