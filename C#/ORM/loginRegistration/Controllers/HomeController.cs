using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using loginRegistration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace loginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Begin()
        {
            List<User> AllUsers = dbContext.Users.ToList();
            return View("Index");
        }


        [Route("register")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        [Route("login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View("login");
        }

        [HttpPost("signup")]
        public IActionResult Signup(User newUser)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == newUser.Email);
                if(userInDb == null)
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();

                    User User = dbContext.Users.LastOrDefault();
                    int userid = User.user_id;
                    HttpContext.Session.SetInt32("userid", userid);
                    return RedirectToAction("success");
                }
                else
                {
                    ModelState.AddModelError("Email", "Email Already in use!");
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("signin")]
        public IActionResult SignIn(LoginUser loginuser)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == loginuser.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(loginuser, userInDb.Password, loginuser.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid EMail/Password");
                    return View("login");
                }
                int userid = userInDb.user_id;
                HttpContext.Session.SetInt32("userid", userid);
                return RedirectToAction("success");
            }
            else
            {
                return View("login");
            }
        }

        [HttpGet("success")]
        public IActionResult success()
        {
            int? currentuser = HttpContext.Session.GetInt32("userid");
            if(currentuser == null)
            {
                return RedirectToAction("LogIn");
            }
            else
            {
                return View("success");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");

        }


    }
}
