using Microsoft.AspNetCore.Mvc;

namespace InternTask2.Controllers
{
    public class PageController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Styles()
        {
            return View();
        }

        public IActionResult SinglePost()
        {
            return View();
        }

        public IActionResult SingleProduct()
        {
            return View();
        }
    }
}

