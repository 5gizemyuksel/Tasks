using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string fullName, string email, string subject, string message)
        {
            
            return RedirectToAction("Index", "Home");
        }

    }
}
