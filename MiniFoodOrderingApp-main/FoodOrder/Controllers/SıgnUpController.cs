using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Security;

namespace FoodOrder.Controllers
{
    public class SıgnUpController: Controller
    {
        public IActionResult sıgnUp(string Username,string Password,string RepeatPassword,string Emailadress)
        {
           var ctrl= registerControl(Password, RepeatPassword);
            if (ctrl)
            {
                return RedirectToAction("LogIn", "logIn");
            }
            else
            {
                ViewBag.ctrl = ctrl;
                return View();
            }
            
        }



        public bool registerControl( string Password, string RepeatPassword)
        {
            if (Password == RepeatPassword)
            {
                return true;
            }

            return false;
        }
    }
}
