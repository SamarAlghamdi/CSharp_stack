using System.Linq;
using BankAccounts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BankAccounts.Controllers
{
    public class UserController : Controller
    {
        private MyContext _context;
        public UserController(MyContext context){
            _context=context;
        }
        [HttpGet("")]
        public IActionResult Register(){
            if(HttpContext.Session.GetInt32("UserId")==null){
                return View();
            } else {
                return RedirectToAction("Success");
            }
        }

        [HttpPost("create")]
        public IActionResult Create(User NewUser){
            if(ModelState.IsValid){
                if(_context.Users.Any(u=> u.Email==NewUser.Email)){
                    ModelState.AddModelError("Email","This Email is already registered");
                    return View("Register");
                } else {
                    PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
                    NewUser.Password = passwordHasher.HashPassword(NewUser,NewUser.Password);
                    _context.Users.Add(NewUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("UserId",NewUser.UserId);
                    return RedirectToAction("Success");
                }
            } else {
                return View("Register");
            }
        }
        [HttpGet("success")]
        public IActionResult Success(){
            int? UserId= HttpContext.Session.GetInt32("UserId");
            if(UserId !=null){
                ViewBag.user = _context.Users.FirstOrDefault(u => u.UserId==UserId);
                ViewBag.Alltra=_context.Transactions.Where(u=>u.UserId==UserId);
                return View("Success");
            } else {
                return RedirectToAction("LoginForm");
            }
            
        }

        [HttpGet("login")]
        public IActionResult LoginForm(){
            if(HttpContext.Session.GetInt32("UserId")==null){
            return View();
            } else {
                return RedirectToAction("Success");
            }
        }

        [HttpPost("check")]
        public IActionResult Login(LoginUser LoggedUser){
            if (ModelState.IsValid){
                User DbUser = _context.Users.FirstOrDefault(u => u.Email==LoggedUser.Email);
                if (DbUser == null){
                    ModelState.AddModelError("Email","Email or Password is Invalid");
                    return View("LoginForm");
                } else {
                    PasswordHasher<LoginUser> passwordHasher = new PasswordHasher<LoginUser>();
                    var result = passwordHasher.VerifyHashedPassword(LoggedUser,DbUser.Password,LoggedUser.Password);
                    if (result==0){
                        ModelState.AddModelError("Email","Email or Password is Invalid");
                        return View("LoginForm");
                    } else {
                        HttpContext.Session.SetInt32("UserId",DbUser.UserId);
                        return RedirectToAction("Success");
                    }
                }
            } else {
                return View("LoginForm");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("LoginForm");
        }

        [HttpPost("submit")]
        public IActionResult Submit(Transaction tra){
            int? Id =HttpContext.Session.GetInt32("UserId");
            ViewBag.user = _context.Users.FirstOrDefault(u => u.UserId==Id);
            if(Id==null){
                return RedirectToAction("LoginForm");
            } else {
                if(ModelState.IsValid){
                    User user = _context.Users.FirstOrDefault(u => u.UserId==Id);
                    tra.UserId=user.UserId;
                    user.balance+=tra.Amount;
                    if(user.balance<0){
                        user.balance-=tra.Amount;
                        ModelState.AddModelError("Amount","Balance cannot be less than zero");
                        return View("Success");
                    }
                        _context.Transactions.Add(tra);
                        _context.SaveChanges();
                        return RedirectToAction("Success");
                    
                }
                return View("Success");
            }
        }
        
    }
}