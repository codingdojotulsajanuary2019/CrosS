using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;


namespace CExam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(User newUser)
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
                    int userid = User.UserId;
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

        [Route("logout")]
        [HttpGet]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
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
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(loginuser, userInDb.Password, loginuser.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Email/Password");
                    return View("Index");
                }
                int userid = userInDb.UserId;
                HttpContext.Session.SetInt32("userid", userid);
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            Both SignedIn = new Both
            {
                AllUsers = dbContext.Users.Where(u => u.UserId == HttpContext.Session.GetInt32("userid")).ToList(),
                AllMessages = dbContext.Messages.ToList()
            };
            return View("Bright", SignedIn);
        }

        [HttpPost("post")]
        public IActionResult Post(Message newMessage)
        {
            dbContext.Add(newMessage);
            dbContext.SaveChanges();
            return RedirectToAction("Success");
        }
    }
}
