using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context){
            _context=context;
        }

        [HttpGet("")]
        public IActionResult Index(){
            ViewBag.AllChefs= _context.Chefs.Include(d=>d.Dishes).ToList();
            return View();
        }

        [HttpGet("new")]
        public IActionResult AddChef(){
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(Chef NewChef){
            if(ModelState.IsValid){
                _context.Add(NewChef);
                _context.SaveChanges(); 
                return RedirectToAction("Index");
            }
            else  return View("AddChef");
        }

        [HttpGet("dishes")]
        public IActionResult IndexDishe(){
            ViewBag.AllDishes= _context.Dishes.Include(c=>c.Creator).ToList();
            return View();
        }

        [HttpGet("dishes/new")]
        public IActionResult AddDishe(){
            ViewBag.AllChefs= _context.Chefs.ToList();
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Dishe NewDishe){
            ViewBag.AllChefs= _context.Chefs.ToList();
            if(ModelState.IsValid){
                _context.Add(NewDishe);
                _context.SaveChanges(); 
                return RedirectToAction("IndexDishe");
            }
            else  return View("AddDishe");
        }
    }
}
