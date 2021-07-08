using Microsoft.AspNetCore.Mvc;
using Validating.Models;

namespace Validating.Controllers
{
    public class FormController:Controller
    {
        [HttpGet("")]
        public IActionResult Index(){
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(User user){
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", user);
            }
            else
            {
            return View("Index");
        }
        
    }

        [HttpGet("result")]
        public IActionResult Result(User user){
            return View(user);
        }
}
}