using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Pages.Customer
{
	public class OrderHistoryModel : PageModel
	{
		private readonly ClickCartDbContext _context;
		public List<Product> Products { get; set; } = new List<Product>();

		public OrderHistoryModel(ClickCartDbContext context)
		{
			_context = context;
			Products = _context.Products.ToList();
		}

		public List<Order> Orders { get; set; } = new List<Order>();
		public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
		[BindProperty]
		public User Customer { get; set; } = new User();
		[BindProperty]
		public int CurrentPage { get; set; }
		public int TotalPages { get; set; }

		public async Task<ActionResult> OnGetAsync()
		{
			if (!User.Identity.IsAuthenticated)
			{
				return RedirectToPage("/Login");
			}
			var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
			Customer = await _context.Users.FindAsync(int.Parse(userId));

			Orders = _context.Orders.Include(o => o.OrderDetails).Where(o => o.UserID == Customer.UserID).ToList();

			return Page();
		}
		[BindProperty]
		public int SelectedOrderId { get; set; } // Holds the currently selected order ID

		public List<OrderDetail> SelectedOrderDetails { get; set; } = new List<OrderDetail>();

		public async Task<IActionResult> OnPostViewDetailsAsync(int orderId)
		{

			SelectedOrderDetails = await _context.OrderDetails
				.Include(od => od.Order)
				.Where(od => od.OrderID == orderId)
				.ToListAsync();

			SelectedOrderId = orderId;

			return Page(); // Re-render the page with updated order details
		}
	}
}
