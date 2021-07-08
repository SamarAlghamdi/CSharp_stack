using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductCat.Models;

namespace ProductCat.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context){
            _context=context;
        }

        [HttpGet("")]
        public IActionResult Product(){
            ViewBag.AllProducts = _context.Products.ToList();
            return View();
        }

        [HttpPost("Add/product")]
        public IActionResult AddProduct(Product Newproduct){
            if (ModelState.IsValid){
                _context.Add(Newproduct);
                _context.SaveChanges();
                return RedirectToAction("Product");
            } else {
                return RedirectToAction("Product");
            }
        }

        [HttpGet("categories")]
        public IActionResult Category(){
            ViewBag.AllCategories = _context.Categories.ToList();
            return View();
        }

        [HttpPost("Add/Category")]
        public IActionResult AddCat(Category NewCategory){
            if (ModelState.IsValid){
                _context.Add(NewCategory);
                _context.SaveChanges();
                return RedirectToAction("Category");
            } else {
                return RedirectToAction("Category");
            }
        }

        [HttpGet("product/{id}")]
        public IActionResult OnePro(int id){
            ViewBag.AllProCategories = _context.Products
            .Include(c=>c.CatsOfProduct)
            .ThenInclude(c=>c.Category)
            .SingleOrDefault(p=>p.ProductId==id);

            ViewBag.AllCategories = _context.Categories
            .Include(p=>p.ProductsInCat)
            .Where(p=> p.ProductsInCat.All(a=> a.ProductId != id))
            .ToList();

            return View();
        }

        [HttpPost("pro/{id}")]
        public IActionResult AddCatToPro(int id, int cat){
            // Product Mypro =_context.Products.FirstOrDefault(p=>p.ProductId==id);
            // Category Cat=_context.Categories.SingleOrDefault(c=>c.CategoryId == cat);
            Association Ass=new Association();
            Ass.CategoryId=cat;
            Ass.ProductId=id;
            _context.Associations.Add(Ass);
            _context.SaveChanges();
            return RedirectToAction("OnePro");
        }

        [HttpGet("category/{id}")]
        public IActionResult OneCat(int id){
            ViewBag.AllCatProducts = _context.Categories
            .Include(p=>p.ProductsInCat)
            .ThenInclude(p=>p.Product)
            .SingleOrDefault(c=>c.CategoryId == id);
            

            ViewBag.AllProducts = _context.Products
            .Include(p=>p.CatsOfProduct)
            .Where(p=> p.CatsOfProduct.All(a=> a.CategoryId != id))
            .ToList();
            return View();
        }

        [HttpPost("cat/{id}")]
        public IActionResult AddProToCat(int id, int pro){
            Product Mypro =_context.Products.FirstOrDefault(p=>p.ProductId==pro);
            Category Cat=_context.Categories.SingleOrDefault(c=>c.CategoryId == id);
            Association Ass=new Association();
            Ass.CategoryId=Cat.CategoryId;
            Ass.ProductId=Mypro.ProductId;
            _context.Associations.Add(Ass);
            _context.SaveChanges();
            return RedirectToAction("OneCat");
        }
    }
}
