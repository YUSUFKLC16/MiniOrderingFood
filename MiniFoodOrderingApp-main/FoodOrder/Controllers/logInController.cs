using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using FoodOrder.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using FoodOrder.Models.Authentication;

namespace FoodOrder.Controllers
{


    public class logInController : Controller
    {
         Context context=new Context();
        public IActionResult LogIn()
        {
            
               
            
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> LogIn(string Username, string password)
        {
            User user=context.Users.FirstOrDefault(user => user.name == Username && user.password == password);
            if (!(user is null))
            { 
                HttpContext.Session.setoo("currentUser", user);
                List<Claim> claims = new List<Claim>()
                {    new Claim("username", Username),
                    new Claim("password",password),
                 };
              
                ClaimsIdentity ıdentity= new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(ıdentity);
                await HttpContext.SignInAsync(principal);

                Response.Cookies.Append("username",Username);
                return RedirectToAction("main", "Home");


            }

            else
            {
                ViewBag.succsess = false;
                return View();
                    

            }
             

       
        }
        public  async Task<IActionResult> logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Response.Cookies.Delete("username");
            HttpContext.Session.Clear();

               return RedirectToAction("main", "Home");
               
        }
    }

        








    


}
