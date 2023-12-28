using FoodOrder.Models;
using FoodOrder.Models.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrder.Controllers
{

    [Authorize]
    public class PersonController : Controller
    {
        Context db = new Context();
       
        public IActionResult person()
        {
            User user= HttpContext.Session.getoo<User>("currentUser");
            return View(user);
        }

        [HttpPost]
        public IActionResult person(User comerUser)
        {
           User user = HttpContext.Session.getoo<User>("currentUser");
            user.adress = comerUser.adress;
            user.phone = comerUser.phone;
            user.name = comerUser.name;
            user.Email = comerUser.Email;
            db.Update(user);
            db.SaveChanges();

            ViewBag.message = "Başarıyla güncellenmiştir";
            return View(user);
        }
    }
}
