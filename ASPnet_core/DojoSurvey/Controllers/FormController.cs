using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class FormController:Controller
    {
        [HttpGet("")]
        public IActionResult Index(){
            return View();
        } 

        [HttpPost("survey")]
        public IActionResult Survey(Survey formObj){

            if(ModelState.IsValid)
                {
                    return RedirectToAction("Result", formObj);
                }
                else
                {
                return View("Index");
            }
        }

        [HttpGet("result")] 
        public ViewResult Result(Survey FormObj){

            return View(FormObj);
            
        }
    }
}