using ClickCart.Models;
using ClickCart.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ClickCart.Pages
{
	public class StepOneModel : PageModel
	{
		private readonly ClickCartDbContext _context;
		private readonly EmailService _emailService;

		public StepOneModel(ClickCartDbContext context, EmailService emailService)
		{
			_context = context;
			_emailService = emailService;
		}
		public User Customer { get; set; }
		[BindProperty]
		public int TotalPrice { get; set; }
		[BindProperty]
		public int? CartID { get; set; }
		[BindProperty]
		public bool isChecked { get; set; }
		[BindProperty]
		public int ShippingFee { get; set; }
		private int GetUserId()
		{
			return int.TryParse(User.FindFirstValue("UserId"), out var userId) ? userId : 0;
		}
		public async Task<IActionResult> OnGetAsync()
		{
			var userId = GetUserId();
			if (userId == 0)
			{
				return RedirectToPage("/Login");

			}
			Customer = _context.Users.Find(userId);
			TotalPrice = Int32.Parse(HttpContext.Session.GetString("TotalPrice"));
			return Page();
		}
		public async Task<IActionResult> OnPostSubmitAsync()
		{
			TotalPrice = Int32.Parse(HttpContext.Session.GetString("TotalPrice"));
			var userId = GetUserId();
			Customer = _context.Users.Find(userId);
			CartID = HttpContext.Session.GetInt32("CartID");
			var CustomerName = Request.Form["FullName"];
			var CustomerPhone = Request.Form["PhoneNumber"];
			var CustomerAddress = Request.Form["ShippingAddress"];
			var PaymentMethod = Request.Form["PaymentMethod"];
			ShippingFee = 5000;
			if (isChecked)
			{
				ShippingFee = 0;
				Customer!.FreeShipCount--;
			}
			
			List<OrderDetail> orderDetails = new List<OrderDetail>();
			var newOrder = new Order();
			newOrder.UserID = Customer.UserID;
			if (newOrder.CreatedAt < new DateTime(DateTime.Now.Year, 3, 3))
			{
				ShippingFee = 0;
			}
			newOrder.TotalAmount = TotalPrice + ShippingFee;
			newOrder.FullName = CustomerName;
			newOrder.PhoneNumber = CustomerPhone;
			newOrder.ShippingAddress = CustomerAddress;
			newOrder.PaymentStatus = "Pending";
			newOrder.PaymentGateway = PaymentMethod;
            newOrder.Status = "Pending";
            _context.Orders.Add(newOrder);
			_context.SaveChanges();

			var cartItems = _context.CartItems
				.Where(ct => ct.CartID == CartID)
				.Include(ct => ct.Product)
				.ToList();


			foreach (var cartItem in cartItems)
			{
				var newOD = new OrderDetail();
				newOD.OrderID = newOrder.OrderID;
				newOD.ProductID = cartItem.ProductID;
				newOD.Note = cartItem.Note;
				newOD.Quantity = cartItem.Quantity;
				newOD.Price = cartItem.Product.Price;
				_context.OrderDetails.Add(newOD);
				_context.CartItems.Remove(cartItem);
				_context.SaveChanges();
			}
			var cart = _context.Carts.Find(CartID);
			_context.Carts.Remove(cart);
			_context.SaveChanges();
			try
			{
				orderDetails = _context.OrderDetails.Where(o => o.OrderID == newOrder.OrderID).Include(p => p.Product).ToList();
				string emailBody = $@"
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
					.table {{
						width: 100%;
						border-collapse: collapse;
						margin-top: 20px;
					}}
					.table, .table th, .table td {{
						border: 1px solid #ddd;
					}}
					.table th, .table td {{
						padding: 10px;
						text-align: left;
					}}
					.table th {{
						background-color: #f1f1f1;
					}}
				</style>
			</head>
			<body>
				<div class='email-container'>
					<div class='email-header'>
						<h1>ClickCart - Xác nhận đơn hàng</h1>
					</div>
					<div class='email-body'>
						<p>Gửi bạn {Customer.FullName},</p>
						<p>Cảm ơn bạn đã đặt hàng tại ClickCart. Dưới đây là thông tin đơn hàng của bạn:</p>
            
						<table class='table'>
							<thead>
								<tr>
									<th>Tên sản phẩm</th>
									<th>Số lượng</th>
									<th>Đơn giá</th>
									<th>Thành tiền</th>
								</tr>
							</thead>
							<tbody>";

				foreach (var ods in orderDetails)
				{
					emailBody += $@"
								<tr>
									<td>{ods.Product.ProductName}({ods.Note})</td>
									<td>{ods.Product.Price.ToString("N0")} VND</td>
									<td>{ods.Quantity}</td>
									<td>{ods.Price.ToString("N0")} VND</td>
								</tr>";
				}

				emailBody += $@"
							</tbody>
						</table>
						<p><strong>Phí vận chuyển:</strong> {ShippingFee.ToString("N0")} VND</p>
						<p><strong>Tổng tiền:</strong> {(TotalPrice + ShippingFee).ToString("N0")} VND</p>
						<p style='color: red;'><strong>Lưu ý:</strong> Đơn hàng của bạn sẽ được giao đến trong vòng 60 phút từ <b>{newOrder.CreatedAt}</b> 
							đến <b>{newOrder.CreatedAt.AddMinutes(60)}</b>. Vui lòng giữ liên lạc để không bỏ lỡ đơn hàng từ chúng tôi.</p>
						<p>Hãy kiểm tra kỹ thông tin đơn hàng và nếu có bất kỳ câu hỏi nào, vui lòng liên hệ với chúng tôi qua Fanpage Facebook: 
						   <a href='https://www.facebook.com/profile.php?id=61571964152044' target='_blank' style='color: blue; text-decoration: none; font-weight: bold;'>
							  ClickCart Fanpage
						   </a>.
						</p>
						<p>Chúc bạn có một ngày tốt lành và trải nghiệm mua sắm tuyệt vời trên trang web của chúng tôi.♥♥♥</p>
					</div>
					<div class='email-footer'>
						<p>&copy; 2025 ClickCart. All rights reserved.</p>
					</div>
				</div>
			</body>
			</html>";
				await _emailService.SendEmailAsync(
						toEmail: Customer.Email,
						subject: "Đơn hàng của bạn đã đặt thành công!!!",
						body: emailBody
					);
			}
			catch (Exception ex)
			{
				return NotFound(ex.Message);
			}
			if (newOrder.PaymentGateway.Equals("Thanh toán khi nhận hàng"))
			{
				return RedirectToPage("/Index");
			}
			TempData["TotalAmount"] = $"Đơn hàng của bạn hết {newOrder.TotalAmount.ToString("N0")} VND.";
			return RedirectToPage("/Payment/Payment");
		}
	}
}
