using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController
        public ActionResult Index()
        {
            var blogPosts = new List<BlogPost>
            {
                new BlogPost { Title = "Blog Yazısı 1", Summary = "Bu blog yazısının özeti 1.", ImageUrl = "https://picsum.photos/200/150?random=1" },
                new BlogPost { Title = "Blog Yazısı 2", Summary = "Bu blog yazısının özeti 2.", ImageUrl = "https://picsum.photos/200/150?random=2" },
                new BlogPost { Title = "Blog Yazısı 3", Summary = "Bu blog yazısının özeti 3.", ImageUrl = "https://picsum.photos/200/150?random=3" },
                new BlogPost { Title = "Blog Yazısı 4", Summary = "Bu blog yazısının özeti 4.", ImageUrl = "https://picsum.photos/200/150?random=4" },
                new BlogPost { Title = "Blog Yazısı 5", Summary = "Bu blog yazısının özeti 5.", ImageUrl = "https://picsum.photos/200/150?random=5" },
                new BlogPost { Title = "Blog Yazısı 6", Summary = "Bu blog yazısının özeti 6.", ImageUrl = "https://picsum.photos/200/150?random=6" },
                new BlogPost { Title = "Blog Yazısı 7", Summary = "Bu blog yazısının özeti 7.", ImageUrl = "https://picsum.photos/200/150?random=7" },
                new BlogPost { Title = "Blog Yazısı 8", Summary = "Bu blog yazısının özeti 8.", ImageUrl = "https://picsum.photos/200/150?random=8" },
                new BlogPost { Title = "Blog Yazısı 9", Summary = "Bu blog yazısının özeti 9.", ImageUrl = "https://picsum.photos/200/150?random=9" },
                new BlogPost { Title = "Blog Yazısı 10", Summary = "Bu blog yazısının özeti 10.", ImageUrl = "https://picsum.photos/200/150?random=10" },
            };
            return View(blogPosts);
        }

    }
    public class BlogPost
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
    }
}
