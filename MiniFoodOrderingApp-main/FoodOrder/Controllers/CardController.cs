using FoodOrder.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Identity.Client;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;

namespace FoodOrder.Controllers
{
    [Authorize]
    public class CardController : Controller
    {

      
        public IActionResult  addtocart(int ıd, string type)
        {
            getcard();
            Cart cart = HttpContext.Session.getoo<Cart>("usercard");
            cart.addItems(ıd, type);
            HttpContext.Session.setoo("usercard",cart);

            return Redirect("/Home/main");
         }

        public IActionResult remevotocart(int ıd, string type)
        {
            getcard();
            Cart cart = HttpContext.Session.getoo<Cart>("usercard");
            cart.removeItem(ıd, type);
            HttpContext.Session.setoo("usercard", cart);
            return RedirectToAction("GoBasket", "home");
        }
        
        public void  getcard()

        {
            var isthereCard= HttpContext.Session.getoo<Liste>("usercard");

            if (isthereCard == null)
            {
                Cart liste = new Cart();
                HttpContext.Session.setoo("usercard", liste);
            }
        }
    }
}