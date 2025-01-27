using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Pages.Customer.Products
{
    public class IndexModel : PageModel
    {
		private readonly ClickCartDbContext _context;

		public IndexModel(ClickCartDbContext context)
		{
			_context = context;
		}

		public List<Product> Products { get; set; } = new List<Product>();
		public int CurrentPage { get; set; }
		public int TotalPages { get; set; }

		public async Task OnGetAsync(int pageNumber = 1, int pageSize = 6)
		{
			// Tổng số sản phẩm
			var totalProducts = await _context.Products.CountAsync();

			// Tính tổng số trang
			TotalPages = (int)Math.Ceiling(totalProducts / (double)pageSize);

			// Lấy dữ liệu sản phẩm cho trang hiện tại
			Products = await _context.Products
				.OrderBy(p => p.ProductID)  // Sắp xếp theo ID sản phẩm (hoặc trường khác)
				.Skip((pageNumber - 1) * pageSize) // Bỏ qua sản phẩm của các trang trước
				.Take(pageSize) // Lấy sản phẩm cho trang hiện tại
				.ToListAsync();

			CurrentPage = pageNumber;
		}
	}
}
