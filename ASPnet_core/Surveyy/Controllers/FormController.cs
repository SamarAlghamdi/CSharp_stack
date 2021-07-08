using Microsoft.AspNetCore.Mvc;
using Survey.Models;

namespace Survey.Controllers
{
    public class FormController:Controller
    {
        [HttpGet("")]
        public IActionResult Index(){
            return View();
        } 

        [HttpPost("survey")]
        public IActionResult Survey(SurveyClass formObj){

        return View("Result", formObj);
        }

        [HttpGet("result")] 
        public ViewResult Result(SurveyClass FormObj){

            return View(FormObj);
            
        }
     }

}