using System.Linq;
using LoginReg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginReg.Controllers
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
            if(HttpContext.Session.GetInt32("UserId")!=null){
                return View();
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
        
    }
}