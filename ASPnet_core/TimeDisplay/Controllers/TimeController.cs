using System;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
    public class TimeController : Controller
    {
        [HttpGet("")]
        public ActionResult CurrentTime(){
            string nowD = DateTime.Now.ToString("MMMM dd, yyyy");
            @ViewBag.date= nowD;
            string nowT = DateTime.Now.ToString("h:mm tt");
            @ViewBag.time= nowT;
            return View();
        }
        
    }
}