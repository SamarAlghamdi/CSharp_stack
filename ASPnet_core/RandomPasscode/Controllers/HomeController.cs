using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index( string code)
        {
            int? passCount = HttpContext.Session.GetInt32("passCode");
            if (passCount==null){
                HttpContext.Session.SetInt32("passCode", 0);
                } 
            
            @ViewBag.code = code;
            
            @ViewBag.count= passCount;
            return View();
        }

        [HttpGet("rand")]
        public IActionResult Rand(){
            int? passCount = HttpContext.Session.GetInt32("passCode");
            string code="";
            passCount++;
                HttpContext.Session.SetInt32("passCode", (int)passCount);
                Random rand = new Random();
                string list = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                for (int i =0;i<14;i++){
                    code+= list[rand.Next(0,list.Length)];
                }
        
            return RedirectToAction("Index", new {code});
        }
    }
}
