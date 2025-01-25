using ClickCart.Models;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Data
{
	public static class Seeder
	{
			public static void Seed(this ModelBuilder modelBuilder)
			{
				modelBuilder.Entity<User>().HasData(
					new User
					{
						UserID = 1,
						Username = "HaiAdmin",
						PasswordHash = PasswordHelper.ToHashPassword("123456"),
						FullName = "Lại Tuấn Hai",
						Email = "HaiLTHE172555@fpt.edu.vn",
						PhoneNumber = "0123456789",
						Role = "Admin",
						CreatedAt = DateTime.Now
					},
					new User
					{
						UserID = 2,
						Username = "HungAdmin",
						PasswordHash = PasswordHelper.ToHashPassword("123456"),
						FullName = "Phạm Việt Hưng",
						Email = "HungPVHE161180@fpt.edu.vn",
						PhoneNumber = "0123456789",
						Role = "Admin",
						CreatedAt = DateTime.Now
					},
					new User
					{
						UserID = 3,
						Username = "CongAdmin",
						PasswordHash = PasswordHelper.ToHashPassword("123456"),
						FullName = "Hoàng Thành Công",
						Email = "CongHTHE172673@fpt.edu.vn",
						PhoneNumber = "0123456789",
						Role = "Admin",
						CreatedAt = DateTime.Now
					},
					new User
					{
						UserID = 4,
						Username = "NhatAdmin",
						PasswordHash = PasswordHelper.ToHashPassword("123456"),
						FullName = "Lê Việt Nhật",
						Email = "NhatLVHE176909@fpt.edu.vn",
						PhoneNumber = "0123456789",
						Role = "Admin",
						CreatedAt = DateTime.Now
					},
					new User
					{
						UserID = 5,
						Username = "TrongAdmin",
						PasswordHash = PasswordHelper.ToHashPassword("123456"),
						FullName = "Lê Công Phú Trọng",
						Email = "TrongLCPHS176090@fpt.edu.vn",
						PhoneNumber = "0123456789",
						Role = "Admin",
						CreatedAt = DateTime.Now
					},
					new User
					{
						UserID = 6,
						Username = "DatAdmin",
						PasswordHash = PasswordHelper.ToHashPassword("123456"),
						FullName = "Vũ Tiến Đạt",
						Email = "DatVTHS176109@fpt.edu.vn",
						PhoneNumber = "0123456789",
						Role = "Admin",
						CreatedAt = DateTime.Now
					},
					new User
					{
						UserID = 7,
						Username = "TungUser",
						PasswordHash = PasswordHelper.ToHashPassword("123456"),
						FullName = "Nguyễn Việt Tùng",
						Email = "TungNVHE170677@fpt.edu.vn",
						PhoneNumber = "0987654321",
						Role = "User",
						CreatedAt = DateTime.Now
					},
					new User
					{
						UserID = 8,
						Username = "ToanUser",
						PasswordHash = PasswordHelper.ToHashPassword("123456"),
						FullName = "Phan Mạnh Toàn",
						Email = "ToanPMHE171369@fpt.edu.vn",
						PhoneNumber = "0987654321",
						Role = "User",
						CreatedAt = DateTime.Now
					},
					new User
					{
						UserID = 9,
						Username = "CuongUser",
						PasswordHash = PasswordHelper.ToHashPassword("123456"),
						FullName = "Phạm Xuân Cường",
						Email = "CuongPXHE172287@fpt.edu.vn",
						PhoneNumber = "0987654321",
						Role = "User",
						CreatedAt = DateTime.Now
					},
					new User
					{
						UserID = 10,
						Username = "AnhUser",
						PasswordHash = PasswordHelper.ToHashPassword("123456"),
						FullName = "Vũ Nam Anh",
						Email = "AnhVNHE151076@fpt.edu.vn",
						PhoneNumber = "0123456789",
						Role = "User",
						CreatedAt = DateTime.Now
					}
				);
			}
	}
}
