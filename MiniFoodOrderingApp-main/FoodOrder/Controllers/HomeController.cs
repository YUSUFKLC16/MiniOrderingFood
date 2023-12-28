using FoodOrder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;


namespace FoodOrder.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        Context db = new Context();
       

     
        public IActionResult Main()
        {

           
            return View(db);
            
        }

        
        public IActionResult Food(string data)
        {

            ViewBag.Data = data;

            return View(db);

        }

        public IActionResult GoBasket(string slm )
        {
            if (HttpContext.Session.getoo<Cart>("usercard") != null)
            {
                Cart cart = HttpContext.Session.getoo<Cart>("usercard");
               
                
                    float price = cart.totalPrice();
                    ViewData["totalPrice"] = price;
                
                List<Cartline> cartline = cart.GetCartlines();
                ViewBag.cartLine = cartline;
                return View(db);
            }
            return View(db);
         
         
        }


       
        
       

    }
}
