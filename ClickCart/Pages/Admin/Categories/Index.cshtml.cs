using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClickCart.Pages.Admin.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ClickCartDbContext _context;

        public IndexModel(ClickCartDbContext context) => _context = context;

        public List<Category> Categories { get; set; }
        [BindProperty] public Category NewCategory { get; set; }
        [BindProperty] public Category EditCategory { get; set; }
        public int PageNumber { get; set; } = 1;
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }

        public async Task OnGetAsync(int pageNumber = 1)
        {
            const int pageSize = 10;
            var query = _context.Categories.AsQueryable();
            TotalItems = await query.CountAsync();
            TotalPages = (int)Math.Ceiling(TotalItems / (double)pageSize);
            Categories = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            PageNumber = pageNumber;
        }

        public async Task<IActionResult> OnPostAddAsync()
        {
            _context.Categories.Add(NewCategory);
            await _context.SaveChangesAsync();
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostEditAsync()
        {
            _context.Categories.Update(EditCategory);
            await _context.SaveChangesAsync();
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}
