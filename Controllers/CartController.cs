using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternTask2.Models;
using InternTask2.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace InternTask2.Controllers
{
    [Authorize] // All actions require login
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);

        public async Task<IActionResult> Index()
        {
            var userId = GetUserId();

            if (string.IsNullOrEmpty(userId))
            {
                // Just in case, redirect to login if not authenticated
                return RedirectToAction("Login", "Account", new { returnUrl = "/Cart" });
            }

            var cart = await _context.CartItems
                .Include(c => c.Product)
                .Where(c => c.UserId == userId)
                .ToListAsync();

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId)
        {
            var userId = GetUserId();

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "Account", new { returnUrl = "/Cart" });
            }

            var product = await _context.Products.FindAsync(productId);
            if (product == null) return NotFound();

            var existingItem = await _context.CartItems
                .FirstOrDefaultAsync(c => c.UserId == userId && c.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity++;
                _context.CartItems.Update(existingItem);
            }
            else
            {
                var newItem = new CartItem
                {
                    UserId = userId,
                    ProductId = productId,
                    Quantity = 1
                };
                _context.CartItems.Add(newItem);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int productId)
        {
            var userId = GetUserId();
            var item = await _context.CartItems
                .FirstOrDefaultAsync(c => c.UserId == userId && c.ProductId == productId);

            if (item != null)
            {
                _context.CartItems.Remove(item);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int productId, int quantity)
        {
            var userId = GetUserId();
            var item = await _context.CartItems
                .FirstOrDefaultAsync(c => c.UserId == userId && c.ProductId == productId);

            if (item != null)
            {
                if (quantity > 0)
                {
                    item.Quantity = quantity;
                    _context.CartItems.Update(item);
                }
                else
                {
                    _context.CartItems.Remove(item);
                }
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}





