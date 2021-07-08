using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class Fun : Controller
    {
        [HttpGet("")]
        public IActionResult Index(){
            string text="Lorem ipsum dolor sit amet, consectetur adipiscing Lorem ipsum dolor sit amet, consectetur adipiscin Lorem ipsum dolor sit amet, consectetur adipiscin";
            return View("Index",text);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers(){
            int [] numbers = new int[]{1,2,3,10,43,5};
            return View(numbers);
        }

        [HttpGet("users")]
        public IActionResult Users(){
            User user = new User(){
                FirstName="Samar",
                LastName="Alghamdi"
            };

            User user2 = new User(){
                FirstName="Norah",
                LastName=""
            };

            User user3 = new User(){
                FirstName="Faisal",
                LastName="Waffels"
            };
            User user4 = new User(){
                FirstName="Anfal",
                LastName="Brownees"
            };

            List<User> users = new List<User>(){
                user,user2,user3,user4
            };
            return View(users);
        }

        [HttpGet("user")]
        public ActionResult UserP(){
            User userV = new User(){
                FirstName="Samar",
                LastName="Alghamdi"
            };

            return View(userV);
        }
    }
}