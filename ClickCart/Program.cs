using ClickCart.Models;
using ClickCart.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace ClickCart
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddDbContext<ClickCartDbContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("MyDB")));

			// Add services to the container.
			builder.Services.AddRazorPages();
			builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				 .AddCookie(options =>
				 {
					 options.LoginPath = "/Login";
				 });
			builder.Services.AddSession(options =>
			{
				options.IdleTimeout = TimeSpan.FromMinutes(30); // Thời gian hết hạn của session
				options.Cookie.HttpOnly = true;
				options.Cookie.IsEssential = true;
			});
			// Ánh xạ cấu hình EmailSettings từ appsettings.json
			builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

			// Đăng ký EmailService
			builder.Services.AddTransient<EmailService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

			app.UseHttpsRedirection();

			app.UseSession();

			app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

			app.UseAuthentication();

			app.MapRazorPages();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                SeedData.Initialize(services);
            }

            app.Run();
        }
    }
}