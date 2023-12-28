using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;


namespace FoodOrder.Controllers
{
    public class LogoutController : Controller
    {
    
        public  async  Task<IActionResult> logout()
        {

        
            HttpContext.Response.Cookies.Delete("username");
            HttpContext.Session.Remove("currentUser");
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("LogIn", "logIn");
        }
    }
}
