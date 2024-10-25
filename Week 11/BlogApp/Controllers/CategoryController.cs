using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {

            ViewBag.Categories = new List<string>{
                "Teknoloji",
                "Seyahat",
                "Sağlık"
            };
            return View();
        }

    }
}
