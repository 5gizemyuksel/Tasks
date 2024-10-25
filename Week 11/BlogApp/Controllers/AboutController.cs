using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public ActionResult Index()
        {
            ViewBag.Bio= "İstanbul Medipol Üniversitesi'nde Psikoloji okuyorum, Acunmedya'da yazılım eğitimi alıyorum, Anadolu Üniversitesi'nde Bilgisayar Programcılığı okuyorum. 22 yaşındayım.";
            return View();
        }

    }
}
