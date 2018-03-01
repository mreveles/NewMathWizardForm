using System;
using Microsoft.AspNetCore.Mvc;
using NewMathWizardForm.Models;
using System.Linq;

namespace NewMathWizrdForm.Controllers {

    public class HomeController : Controller {

        public ViewResult Index() {
            return View("RsvpForm");
        }

        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public IActionResult ShowResults([FromForm] UserResponse userResponse)
        {

            if(userResponse == null)
            {
                return View("Error");
            }
            else
            {
                switch(userResponse.Function){
                    case "Add":
                        userResponse.Result = 
                        userResponse.Left + userResponse.Right;
                        break;
                    
                    case "Subtract":
                        userResponse.Result = 
                        userResponse.Left - userResponse.Right;                
                        break;

                    case "Multiply":
                        userResponse.Result = 
                        userResponse.Left * userResponse.Right;                
                        break;
                    
                    case "Divide":
                        userResponse.Result = 
                        userResponse.Left / userResponse.Right;                
                        break;

                    case "Modulus":
                        userResponse.Result = 
                        userResponse.Left % userResponse.Right;                
                        break;

                    default:
                        return View("Contact");
                        //break;
                        
                    
                }
            }
            return View(userResponse);
        }

    }
}