using Microsoft.AspNetCore.Mvc;
namespace WebAppI
{
    public class HomeController : Controller
    {
        //Requests
        //localhost:5000/
        [HttpGet("")]
        public IActionResult HiThere()
        {
            ViewBag.Example = "Hello World!";
            return View("Index");
        }
        //localhost:5000/hello
        [HttpGet("hello")]
        public RedirectToActionResult Hello()
        {
            return RedirectToAction("HelloUser", new{username="Cros"});
        }
        //localhost:5000/users/????
        [HttpGet("contact/{username}")]
        public IActionResult HelloUser(string username)
        {
            var response = new{user=username};
            if(username == "Cros")
                return Json(response);
            else if(username == "Jerry")
                return View("Index");

            return RedirectToAction("HiThere");
        }
    }
}