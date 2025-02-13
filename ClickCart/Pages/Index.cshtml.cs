using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ClickCartDbContext _context;

		public IndexModel(ClickCartDbContext context)
		{
			_context = context;
		}

		public List<Category> Categories { get; set; }
		public List<Combo> Combos { get; set; }
		public List<Product> FeaturedProducts { get; set; }
		public void OnGet()
		{
			FeaturedProducts = _context.Products.OrderByDescending(p => p.ProductID).Take(6).ToList();
			Categories = _context.Categories.Include(p => p.Products.Take(8)).ToList();
			Combos = _context.Combos.Take(4).ToList();
		}
	}
}
