using ClickCart.Data;
using ClickCart.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Pages.Customer
{
	public class UserProfileModel : PageModel
	{
		private readonly ClickCartDbContext _context;
		public List<Product> Products { get; set; } = new List<Product>();
		public UserProfileModel(ClickCartDbContext context)
		{
			_context = context;
			Products = _context.Products.ToList();
		}
		public List<Order> Orders { get; set; } = new List<Order>();
		public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
		[BindProperty]
		public User Customer { get; set; } = new User();
		public int CurrentPage { get; set; }
		public int TotalPages { get; set; }

		[BindProperty]
		public string CurrentPassword { get; set; }

		[BindProperty]
		public string NewPassword { get; set; }

		[BindProperty]
		public string ConfirmPassword { get; set; }
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
		public async Task<IActionResult> OnPostChangeInformationAsync()
		{

			var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;

			var user = await _context.Users.FindAsync(int.Parse(userId));

			user.FullName = Customer.FullName;
			user.Email = Customer.Email;
			user.PhoneNumber = Customer.PhoneNumber;

			_context.Users.Update(user);
			await _context.SaveChangesAsync();

			TempData["msg"] = "Cập nhật thông tin thành công!";
			return RedirectToPage();
		}

		public async Task<IActionResult> OnPostChangePasswordAsync()
		{
			if (string.IsNullOrEmpty(CurrentPassword) || string.IsNullOrEmpty(NewPassword) || string.IsNullOrEmpty(ConfirmPassword))
			{
				TempData["msg"] = "Vui lòng điền đầy đủ thông tin!";
				return Page();
			}

			if (NewPassword != ConfirmPassword)
			{
				TempData["msg"] = "Mật khẩu mới và xác nhận mật khẩu không khớp!";
				return Page();
			}

			var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;

			var user = await _context.Users.FindAsync(int.Parse(userId));

			// Kiểm tra mật khẩu hiện tại
			if (!PasswordHelper.VerifyPassword(CurrentPassword, user.PasswordHash))
			{
				TempData["msg"] = "Mật khẩu hiện tại không chính xác!";
				return Page();
			}

			// Cập nhật mật khẩu mới
			user.PasswordHash = PasswordHelper.ToHashPassword(NewPassword);

			_context.Users.Update(user);
			await _context.SaveChangesAsync();

			TempData["msg"] = "Thay đổi mật khẩu thành công!";
			return RedirectToPage();
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

