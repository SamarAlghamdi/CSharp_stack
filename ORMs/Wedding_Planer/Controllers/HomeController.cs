using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Wedding_Planer.Models;
using Microsoft.EntityFrameworkCore;

namespace Wedding_Planer.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context){
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("uid") == null){
                return View("Index");
            }else{
                return RedirectToAction("Dashboard");
            }
          
        }
        [HttpPost("create")]
        public IActionResult Create(User user){
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u=> u.Email == user.Email)){
                    ModelState.AddModelError("Email", "This Email already Exists!");
                    return View("Index", user);
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                _context.Add(user);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("uid", user.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("Dashboard")]
        public IActionResult Dashboard(){
            if(HttpContext.Session.GetInt32("uid") == null){
                return RedirectToAction("Index");
            }else{
               ViewBag.AllWeddings = _context.Weddings
               .Include(g => g.Guests)
               .ThenInclude(u => u.User)
               .ToList();
            //    .Where(w => w.Date > DateTime.Now)
               ViewBag.LoggedUser = HttpContext.Session.GetInt32("uid");
               ViewBag.IsRSVP= _context.Weddings
               .Include(w => w.Guests)
               .ThenInclude(g => g.User)
               .Where(l => l.Guests.All(u => u.UserId == HttpContext.Session.GetInt32("uid"))).ToList();

               List<Wedding> Weddings = _context.Weddings
               .Include(g => g.Guests).Where(w => w.Date < DateTime.Now).ToList();
               _context.Weddings.RemoveRange(Weddings);
               _context.SaveChanges();
            //    foreach(Wedding w in hi){ 
            //        Console.WriteLine(w.WeddingId);
            //    }
            //    Console.WriteLine(hi.Count + "hhhhhhhhhhhhhhhhhhhhh");
               
               
               return View("Dashboard"); 
            }
            
        }
     
        [HttpPost("loginform")]
        public IActionResult LoginForm(UserLogin LogUser){
            var userInDb = _context.Users.FirstOrDefault(u => u.Email == LogUser.EmailLogin);
            if(ModelState.IsValid){
if(userInDb == null)
            {
                ModelState.AddModelError("EmailLogin", "Email or password is invalid!");
                return View("Index", LogUser);
            }
            else
            {
                var hasher = new PasswordHasher<UserLogin>();
                var result = hasher.VerifyHashedPassword(LogUser,userInDb.Password,LogUser.PasswordLogin);
                if(result == 0){
                    ModelState.AddModelError("EmailLogin", "Email or Password is Invalid");
                    return View("Index", LogUser);
                }
                HttpContext.Session.SetInt32("uid", userInDb.UserId);
                
            }
            return RedirectToAction("Dashboard");
            }else{
                return View("Index");
            }
            
        }

        // Wedding stuff
        [HttpGet("new")]
        public IActionResult NewWedding(){
            if(HttpContext.Session.GetInt32("uid") == null){
                return RedirectToAction("Index");
            }else{

               return View();
            }
        }
        [HttpPost("weddingform")]
        public IActionResult WeddingForm(Wedding newWedding){
            int? userId = HttpContext.Session.GetInt32("uid");
 
            if(ModelState.IsValid){
                newWedding.UserId = (int)userId;
                _context.Add(newWedding);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("NewWedding"); 
            }
        }
        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            if(HttpContext.Session.GetInt32("uid") == null){
                return RedirectToAction("Index");
            }else{
               Wedding WeddingDetails = _context.Weddings
               .Include(g => g.Guests)
               .ThenInclude(u => u.User)
               .FirstOrDefault(w => w.WeddingId == id);
               return View("Details", WeddingDetails);
            }

        }
        [HttpGet("addguest/{id}")]
        public IActionResult AddGuest(int id){
            Association Aso = new Association();
            Aso.UserId = (int)HttpContext.Session.GetInt32("uid");
            Aso.WeddingId = id;
            _context.Associations.Add(Aso);
            _context.SaveChanges();
            return RedirectToAction("DashBoard");

        }
        [HttpGet("removeguest/{id}")]
        public IActionResult RemoveGuest(int id){
            Association Aso = _context.Associations
            .FirstOrDefault(a => a.WeddingId == id && a.UserId == (int)HttpContext.Session.GetInt32("uid"));
            _context.Associations.Remove(Aso);
            _context.SaveChanges();
            return RedirectToAction("DashBoard");
        }
        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id){
            Wedding wedding = _context.Weddings.FirstOrDefault(a => a.WeddingId == id);
            _context.Weddings.Remove(wedding);
            _context.SaveChanges();
            return RedirectToAction("DashBoard");
        }

    }
 
}
