using Microsoft.AspNetCore.Mvc;

namespace InternTask2.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

