using FoodOrder.Models.Authentication;
using FoodOrder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace FoodOrder.Controllers
{
    [Authorize]
    public class Buy :Controller
    {
        public IActionResult buy()
        {
            User user = HttpContext.Session.getoo<User>("currentUser");
            return View(user);
           
        }
    }
}
