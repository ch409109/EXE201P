using ClickCart.Models;
using ClickCart.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace ClickCart.Pages
{
	public class VerifyCodeModel : PageModel
	{
		private readonly ClickCartDbContext _context;
		private readonly EmailService _emailService;

		public VerifyCodeModel(ClickCartDbContext context,EmailService emailService)
		{
			_context = context;
			_emailService = emailService;
		}

		[BindProperty]
		public string Code { get; set; }
		public void OnGet()
		{
			TempData["msg"] = "Mã xác nhận đã được gửi đến email của quý khách. Quý khách vui lòng kiểm tra email và nhập mã xác nhận.";
		}
		public async Task<IActionResult> OnPostVerifyAsync()
		{
			var userJson = HttpContext.Session.GetString("UserSignUp");
			var user = new User();
			if (!string.IsNullOrEmpty(userJson))
			{
				user = JsonSerializer.Deserialize<User>(userJson);
			}

			var code = HttpContext.Session.GetString("VerificationCode");
			if (code == Code)
			{
				_context.Users.Add(user);
				await _context.SaveChangesAsync();
				TempData["msg"] = "Đăng ký tài khoản thành công. Quý khách vui lòng đăng nhập.";
				return RedirectToPage("/Login");
			}
			else
			{
				TempData["msg"] = "Mã xác nhận không chính xác. Quý khách vui lòng nhập lại.";
				return Page();
			}
		}
	}
}
