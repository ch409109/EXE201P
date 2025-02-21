using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClickCart.Models;
using ClickCart.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ClickCart.Services;

namespace ClickCart.Pages.Admin.Orders
{
	public class IndexModel : PageModel
	{
		private readonly ClickCartDbContext _context;
		private readonly EmailService _emailService;

		public IndexModel(ClickCartDbContext context, EmailService emailService)
		{
			_context = context;
			_emailService = emailService;
		}

		public IList<Order> Orders { get; set; } = new List<Order>();

		public async Task OnGetAsync()
		{
			Orders = await _context.Orders
				.Include(o => o.User)
				.OrderByDescending(o => o.CreatedAt)
				.ToListAsync();
		}
		private int GetUserId()
		{
			return int.TryParse(User.FindFirstValue("UserId"), out var userId) ? userId : 0;
		}
		public async Task<IActionResult> OnPostUpdateStatusAsync([FromBody] UpdateStatusModel model)
		{
			try
			{
				var userId = GetUserId();
				if (userId == 0)
				{
					return RedirectToPage("/Login");

				}
				var order = await _context.Orders.FindAsync(model.OrderId);
				if (order == null)
				{
					return new JsonResult(new { success = false, message = "Không tìm thấyy đơn hàng" });
				}

				order.Status = model.NewStatus;
				await _context.SaveChangesAsync();
				try
				{
					var customer = await _context.Users.FindAsync(order.UserID);
					if (customer != null)
					{
						var emailBody = $@"
							<html>
							<head>
								<style>
									.email-container {{
										font-family: Arial, sans-serif;
										line-height: 1.6;
										color: #333;
									}}
									.email-header {{
										background-color: #f1f1f1;
										padding: 10px;
										text-align: center;
									}}
									.email-body {{
										padding: 20px;
									}}
									.email-footer {{
										background-color: #f1f1f1;
										padding: 10px;
										text-align: center;
										font-size: 12px;
										color: #777;
									}}
								</style>
							</head>
							<body>
								<div class='email-container'>
									<div class='email-header'>
										<h1>ClickCart - Thông báo trạng thái đơn hàng</h1>
									</div>
									<div class='email-body'>
										<p>Gửi bạn {customer.FullName},</p>
										<p>Trạng thái đơn hàng của bạn đã được cập nhật.</p>
										<p>Trạng thái mới của đơn hàng: <strong>{order.Status}</strong>.</p>
									</div>
									<div class='email-footer'>
										<p>Cảm ơn bạn đã mua sắm tại ClickCart!</p>
									</div>
								</div>
							</body>
							</html>";
						await _emailService.SendEmailAsync(
							toEmail: customer.Email,
							subject: "Đơn hàng của bạn đã đặt thành công!!!",
							body: emailBody
						);
					}
				}
				catch (Exception ex)
				{
					return NotFound(ex.Message);
				}
				return new JsonResult(new { success = true });
			}
			catch (Exception ex)
			{
				// Log exception
				return new JsonResult(new { success = false, message = ex.Message });
			}
		}

		public class UpdateStatusModel
		{
			public int OrderId { get; set; }
			public string NewStatus { get; set; }
		}
	}
}