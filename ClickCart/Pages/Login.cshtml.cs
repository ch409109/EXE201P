using ClickCart.Data;
using ClickCart.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Principal;
using ClickCart.Services;
using System.Text.Json;

namespace ClickCart.Pages
{
	public class LoginModel : PageModel
	{
		private readonly ClickCartDbContext _context;
		private readonly EmailService _emailService;

		public LoginModel(ClickCartDbContext context, EmailService emailService)
		{
			_context = context;
			_emailService = emailService;
		}

		[BindProperty]
		public User UserLogin { get; set; } = new Models.User();
		[BindProperty]
		public User UserSignUp { get; set; } = new Models.User();

		[BindProperty]
		public bool isKeepSignin { get; set; }


		public void OnGet()
		{
			if (Request.Cookies.ContainsKey("Username")
					&& Request.Cookies.ContainsKey("Password")
						&& Request.Cookies.ContainsKey("isKeepSignin"))
			{
				UserLogin.Username = Request.Cookies["Username"];
				UserLogin.PasswordHash = Request.Cookies["Password"];
				isKeepSignin = bool.Parse(Request.Cookies["isKeepSignin"]);
			}
		}
		public async Task<IActionResult> OnPostLoginAsync(string returnUrl)
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.Username.Equals(UserLogin.Username));
			if (user == null)
			{
				TempData["msg"] = "Tài khoản không tồn tại. Quý khách vui lòng đăng ký tài khoàn.";
				return Page();
			}
			if (!PasswordHelper.VerifyPassword(UserLogin.PasswordHash, user.PasswordHash))
			{
				TempData["msg"] = "Mật khẩu không chính xác. Quý khách vui lòng đăng nhập lại.";
				return Page();
			}
			var claims = new List<Claim>
			{	
				new Claim("UserId",user.UserID.ToString()),
				new Claim("Username", user.FullName),
				new Claim("Password", user.PasswordHash),
				new Claim(ClaimTypes.Name, user.FullName),
				new Claim("Email", user.Email),
				new Claim("PhoneNumber", user.PhoneNumber),
				new Claim(ClaimTypes.Role, user.Role)
			};
			var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
				new ClaimsPrincipal(claimsIdentity));
			if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
			{
				return Redirect(returnUrl);
			}
			if (isKeepSignin)
			{
				CookieOptions options = new CookieOptions
				{
					Expires = DateTime.Now.AddDays(30),
					HttpOnly = true,
					Secure = true
				};
				Response.Cookies.Append("UserName", UserLogin.Username, options);
				Response.Cookies.Append("Password", UserLogin.PasswordHash, options);
				Response.Cookies.Append("isKeepSignin", isKeepSignin.ToString(), options);
			}
			else
			{
				Response.Cookies.Delete("UserName");
				Response.Cookies.Delete("Password");
				Response.Cookies.Delete("isKeepSignin");
			}
			return RedirectToPage("/Index");
		}

		public async Task<IActionResult> OnPostSignUpAsync()
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.Username.Equals(UserSignUp.Username) || u.Email.Equals(UserSignUp.Email));
			if (user != null)
			{
				TempData["msg"] = "Tài khoản đã tồn tại. Quý khách vui lòng chọn tài khoản khác.";
				return Page();
			}
			UserSignUp.PasswordHash = PasswordHelper.ToHashPassword(UserSignUp.PasswordHash);
			UserSignUp.Role = "Customer";
			UserSignUp.CreatedAt = DateTime.Now;
			string verificationCode = GenerateVerificationCode();
			try
			{
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
                        </style>
                    </head>
                    <body>
                        <div class='email-container'>
                            <div class='email-header'>
                                <h1>ClickCart</h1>
                            </div>
                            <div class='email-body'>
                                <p>Gửi bạn {UserSignUp.FullName},</p>
                                <p>Cảm ơn bạn vì đã đăng ký mở tài khoản. Mã xác thực của bạn là:</p>
                                <h2>{verificationCode}</h2>
                                <p>Hãy nhập mã xác thực trên và hoàn tất việc đăng ký.</p> 
								<p> Chúc bạn có một ngày tốt lành và trải nghiệm mua sắm tuyệt vời trên trang web của chúng tôi.♥♥♥ </p>
                            </div>
                            <div class='email-footer'>
                                <p>&copy; 2025 ClickCart. All rights reserved.</p>
                            </div>
                        </div>
                    </body>
                    </html>";

				await _emailService.SendEmailAsync(
					toEmail: UserSignUp.Email,
					subject: $"Mã xác thực của bạn là: {verificationCode}",
					body: emailBody
				);
			}
			catch (Exception ex)
			{
				return NotFound(ex.Message);
			}
			HttpContext.Session.SetString("VerificationCode", verificationCode);
			HttpContext.Session.SetString("UserSignUp", JsonSerializer.Serialize(UserSignUp));
			return RedirectToPage("/VerifyCode");
		}

		private string GenerateVerificationCode()
		{
			var random = new Random();
			return random.Next(1000, 9999).ToString();
		}
	}
}
