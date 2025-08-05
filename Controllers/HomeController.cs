using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InternTask2.Models;
using InternTask2.Data;  // <-- to access ApplicationDbContext
using Microsoft.EntityFrameworkCore;
using InternTask2.ViewModels;
namespace InternTask2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMessage(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Contact", model);
            }

            var contactMessage = new ContactMessage
            {
                FullName = model.FullName,
                Email = model.Email,
                Message = model.Message
            };

            _context.ContactMessages.Add(contactMessage);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Thank you for your message!";
            return RedirectToAction("Contact");
        }


        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Men()
        {
            var menProducts = _context.Products.Include(p => p.Category)
                                   .Where(p => p.Category.Name == "Men")
                                   .ToList();
            return View(menProducts);
        }

        public IActionResult Women()
        {

            var womenProducts = _context.Products.Include(p => p.Category)
                                                 .Where(p => p.Category.Name == "Women")
                                                 .ToList();
            return View(womenProducts);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult About() => View();
        public IActionResult Shop() => View();
        public IActionResult Blog() => View();
        public IActionResult SingleProduct() => View();
        public IActionResult SinglePost() => View();
        public IActionResult Styles() => View();
        public IActionResult Cart() => View();
        public IActionResult Login() => View();
        public IActionResult Sale()
        {
            var saleProducts = _context.Products
                .Where(p => p.CategoryId == 3)
                .ToList();

            return View(saleProducts);
        }


    }
}

