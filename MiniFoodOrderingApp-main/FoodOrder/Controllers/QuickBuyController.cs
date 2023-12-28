using FoodOrder.Models.Authentication;
using FoodOrder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace FoodOrder.Controllers
{
    [Authorize]
    public class QuickBuyController : Controller
    {
        public IActionResult Quickbuy(int ıd , string type,string price)
        {
            ViewBag.ıd = ıd;
            ViewBag.type = type;
            ViewBag.price = price;
            User user = HttpContext.Session.getoo<User>("currentUser");
            return View(user);
        }
    }
}
