using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClickCart.Data;
using ClickCart.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ClickCart.Pages.Customer.Products
{
	public class IndexModel : PageModel
	{
		private readonly ClickCartDbContext _context;

		public IndexModel(ClickCartDbContext context)
		{
			_context = context;
		}

		public IList<Product> Products { get; set; }  // Danh sách sản phẩm
		public IList<Category> Categories { get; set; }  // Danh sách các danh mục
		public int CurrentPage { get; set; }  // Trang hiện tại
		public int TotalPages { get; set; }  // Tổng số trang
		public int CategoryId { get; set; }  // Id của danh mục hiện tại
		public string ProductName { get; set; }  // Tìm kiếm theo tên sản phẩm

		public async Task OnGetAsync(int? categoryId, string name, string price, int pageNumber = 1)
		{
			Categories = await _context.Categories.ToListAsync();
			CategoryId = categoryId ?? 1;
			HttpContext.Session.SetInt32("CategoryId", categoryId ?? 1);
			await LoadProductsAsync(categoryId, name, price, pageNumber);
		}
		//public async Task OnPostAsync(string name, string price, int pageNumber = 1)
		//{
		//	Categories = await _context.Categories.ToListAsync();
		//	int categoryId = HttpContext.Session.GetInt32("CategoryId") ?? 1;
		//	await LoadProductsAsync(categoryId, name, price, pageNumber);
		//}
		private async Task LoadProductsAsync(int? categoryId, string name, string price, int pageNumber)
		{

			ProductName = name ?? string.Empty;
			const int pageSize = 6;
			var queryProducts = _context.Products.AsQueryable();

			queryProducts = queryProducts.Where(p => p.CategoryID == CategoryId);

			if (!string.IsNullOrEmpty(ProductName))
			{
				queryProducts = queryProducts.Where(p => p.ProductName.Contains(ProductName));
			}

			if (!string.IsNullOrEmpty(price))
			{
				string[] prices = price.Split('-');
				int minPrice = int.Parse(prices[0]);
				int maxPrice = int.Parse(prices[1]);
				queryProducts = queryProducts.Where(p => p.Price < maxPrice && p.Price >= minPrice);
			}

			TotalPages = (int)System.Math.Ceiling(await queryProducts.CountAsync() / (double)pageSize);
			CurrentPage = pageNumber;

			Products = await queryProducts
				.Skip((pageNumber - 1) * pageSize)
				.Take(pageSize)
				.ToListAsync();
		}
	}
}
