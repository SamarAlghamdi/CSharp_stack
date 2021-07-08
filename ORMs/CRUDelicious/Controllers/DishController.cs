using System.Linq;
using System;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDelicious.Controllers
{
    public class DishController : Controller
    {
        private MyContext _context;
        // here we can "inject" our context service into the constructor
        public DishController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllDishes = _context.Dishes.OrderByDescending(d=>d.CreatedAt).ToList();
            return View();
            }

        [HttpPost("create")]
        public IActionResult CreateUser(Dishe newDishe)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDishe);
                // OR dbContext.Users.Add(newUser);
                _context.SaveChanges();
                
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("new")]
        public IActionResult Form(){
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Detailes(int id){
            ViewBag.Dishe= _context.Dishes.FirstOrDefault(d => d.DisheId==id);
            return View();
        }
        [HttpGet("edit/{id}")]
        public IActionResult UpdateForm(int id){
            Dishe Dish= _context.Dishes.FirstOrDefault(d => d.DisheId==id);
            return View(Dish);
        }
        [HttpPost("update/{id}")]
        public IActionResult Update(Dishe updatedDishe, int id){
            Dishe Dish= _context.Dishes.FirstOrDefault(d => d.DisheId==id);

            if(ModelState.IsValid)
            {
                Dish.Name=updatedDishe.Name;
                Dish.Chef=updatedDishe.Chef;
                Dish.Desciption=updatedDishe.Desciption;
                Dish.Calories=updatedDishe.Calories;
                Dish.Tastiness=updatedDishe.Tastiness;
                Dish.UpdatedAt=DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Detailes", id);
            }
            else
            {
                return View("UpdateForm",updatedDishe);
            }
        }

        [HttpGet("delete/{id}")]
        public ActionResult Delete(int id){
            Dishe Dish= _context.Dishes.SingleOrDefault(d => d.DisheId==id);
            _context.Dishes.Remove(Dish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}