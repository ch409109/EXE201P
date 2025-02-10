using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ClickCart.Pages.Admin.Products
{


    public class IndexModel : PageModel
    {
        private readonly ClickCartDbContext _context;

        public IndexModel(ClickCartDbContext context) => _context = context;

        private const int PageSize = 10;

        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        [BindProperty] public Product NewProduct { get; set; }
        [BindProperty] public Product EditProduct { get; set; }
        public int PageNumber { get; set; } = 1;
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }
        private int GetUserId()
        {
            return int.TryParse(User.FindFirstValue("UserId"), out var userId) ? userId : 0;
        }

        public async Task<IActionResult> OnGetAsync(int pageNumber = 1)
        {
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            var userId = GetUserId();
            if (userRole == null || !userRole.Equals("Admin") || userId == 0)
            {
                return RedirectToPage("/Login");

            }
            Categories = _context.Categories.ToList();
            const int pageSize = 10;
            var query = _context.Products.Include(p => p.Category).AsQueryable();
            TotalItems = await query.CountAsync();
            TotalPages = (int)Math.Ceiling(TotalItems / (double)pageSize);
            Products = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            PageNumber = pageNumber;
            return Page();
        }

        public async Task<IActionResult> OnPostAddAsync()
        {
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            var userId = GetUserId();
            if (userRole == null || !userRole.Equals("Admin") || userId == 0)
            {
                return RedirectToPage("/Login");

            }
            _context.Products.Add(NewProduct);
            await _context.SaveChangesAsync();
            return RedirectToPage(new { pageNumber = PageNumber });
        }

        public async Task<IActionResult> OnPostEditAsync()
        {
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            var userId = GetUserId();
            if (userRole == null || !userRole.Equals("Admin") || userId == 0)
            {
                return RedirectToPage("/Login");

            }
            var product = await _context.Products.FindAsync(EditProduct.ProductID);
            if (product != null)
            {
                product.ProductName = EditProduct.ProductName;
                product.Price = EditProduct.Price;
                product.Stock = EditProduct.Stock;
                product.Description = EditProduct.Description;
                product.CategoryID = EditProduct.CategoryID;
                await _context.SaveChangesAsync();
            }
            return RedirectToPage(new { pageNumber = PageNumber });
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            var userId = GetUserId();
            if (userRole == null || !userRole.Equals("Admin") || userId == 0)
            {
                return RedirectToPage("/Login");

            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage(new { pageNumber = PageNumber });
        }
    }

}
