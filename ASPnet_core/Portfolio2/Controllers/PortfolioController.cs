using Microsoft.AspNetCore.Mvc;

namespace Portfolio2.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public ViewResult Home(){
            return View();
        }

        [HttpGet("projects")]
        public ViewResult ProjectsPage(){
            return View();
        }

        [HttpGet("contact")]
        public ViewResult ContactPage(){
            return View();
        }
        
    }
}