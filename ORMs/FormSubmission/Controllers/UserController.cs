using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;
using System;

namespace FormSubmission.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("")]
        public IActionResult UserForm(){
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(User user){
            Console.WriteLine(user.Age.GetType());
            if(ModelState.IsValid)
                return RedirectToAction("Result",user);
            else  return View("UserForm");
        }
        [HttpGet("result")]
        public IActionResult Result(User user){
            return View(user);
        }
    }
}