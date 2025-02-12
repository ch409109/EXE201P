﻿using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly ClickCartDbContext _context;

        public DetailsModel(ClickCartDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.ProductID == id);

            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
