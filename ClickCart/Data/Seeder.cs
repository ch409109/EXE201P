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
					Role = "Customer",
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
					Role = "Customer",
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
					Role = "Customer",
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
					Role = "Customer",
					CreatedAt = DateTime.Now
				}
			);
			modelBuilder.Entity<Category>().HasData(
				new Category
				{
					CategoryID = 1,
					CategoryName = "Đồ ăn vặt",
					Description = "Đồ ăn vặt"
				},
				new Category
				{
					CategoryID = 2,
					CategoryName = "Gia vị",
					Description = "Gia vị"
				},
				new Category
				{
					CategoryID = 3,
					CategoryName = "Nước giải khát",
					Description = "Nước giải khát"
				},
				new Category
				{
					CategoryID = 4,
					CategoryName = "Thực phẩm ăn liền",
					Description = "Thực phẩm ăn liền"
				},
				new Category
				{
					CategoryID = 5,
					CategoryName = "Thực phẩm tươi sống",
					Description = "Thực phẩm tươi sống"
				},
				new Category
				{
					CategoryID = 6,
					CategoryName = "Dụng cụ nhà bếp",
					Description = "Dụng cụ nhà bếp"
				}
			);
			modelBuilder.Entity<Product>().HasData(
			   new Product
			   {
				   ProductID = 1,
				   ProductName = "Bánh gạo Jinju cốm sữa",
				   CategoryID = 1,
				   Price = 20000,
				   Stock = 50,
				   Description = "Snack khoai tây giòn rụm, vị phô mai thơm ngon.",
				   ImageUrl = "Do_An_Vat/Bánh gạo Jinju cốm sữa.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 2,
				   ProductName = "Bánh quế Oreo vị vani hộp 54g",
				   CategoryID = 1,
				   Price = 10000,
				   Stock = 100,
				   Description = "Bánh quế Oreo vị vani hộp 54g.",
				   ImageUrl = "Do_An_Vat/Bánh quế Oreo vị vani hộp 54g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 3,
				   ProductName = "Bánh quy bơ Cosy thập cẩm rắc hạt hộp 336g",
				   CategoryID = 1,
				   Price = 15000,
				   Stock = 200,
				   Description = "Bánh quy bơ Cosy thập cẩm rắc hạt hộp 336g.",
				   ImageUrl = "Do_An_Vat/Bánh quy bơ Cosy thập cẩm rắc hạt hộp 336g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 4,
				   ProductName = "Bánh quy bơ Danisa hộp 908g",
				   CategoryID = 1,
				   Price = 12000,
				   Stock = 150,
				   Description = "Bánh quy bơ Danisa hộp 908g.",
				   ImageUrl = "Do_An_Vat/Bánh quy bơ Danisa hộp 908g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 5,
				   ProductName = "Hộp Bánh Pocky Glico 118g",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Hộp Bánh Pocky Glico 118g.",
				   ImageUrl = "Do_An_Vat/Hộp Bánh Pocky Glico 118g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 6,
				   ProductName = "Hộp quà Tết Hamper 1 x 6H 727.2g",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Hộp quà Tết Hamper 1 x 6H 727.2g",
				   ImageUrl = "Do_An_Vat/Hộp quà Tết Hamper 1 x 6H 727.2g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 7,
				   ProductName = "Kẹo sing gum hương bạc hà và khuynh diệp CooL Air Wrigley's hộp 58,4g",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Kẹo sing gum hương bạc hà và khuynh diệp CooL Air Wrigley's hộp 58,4g.",
				   ImageUrl = "Do_An_Vat/Kẹo sing gum hương bạc hà và khuynh diệp CooL Air Wrigley's hộp 58,4g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 8,
				   ProductName = "Kẹo Socola Snickers Túi 3 thanh 51g",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Kẹo Socola Snickers Túi 3 thanh 51g",
				   ImageUrl = "Do_An_Vat/Kẹo Socola Snickers Túi 3 thanh 51g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 9,
				   ProductName = "Kẹo Socola Sữa Popit Tết 90.1g",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Kẹo Socola Sữa Popit Tết 90.1g.",
				   ImageUrl = "Do_An_Vat/Kẹo Socola Sữa Popit Tết 90.1g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 10,
				   ProductName = "Khoai tây LAY'S vị tự nhiên classic 150g",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Khoai tây LAY'S vị tự nhiên classic 150g.",
				   ImageUrl = "Do_An_Vat/Khoai tây LAY'S vị tự nhiên classic 150g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 11,
				   ProductName = "Mít sấy Vinamit gói 100g",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Mít sấy Vinamit gói 100g.",
				   ImageUrl = "Do_An_Vat/Mít sấy Vinamit gói 100g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 12,
				   ProductName = "Snach khoai tây Lay's tôm hùm cay lon 105 g",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Snach khoai tây Lay's tôm hùm cay lon 105 g.",
				   ImageUrl = "Do_An_Vat/Snach khoai tây Lay's tôm hùm cay lon 105 g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 13,
				   ProductName = "Snack Lay Stax khoai tây vị tự nhiên 160g",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Snack Lay Stax khoai tây vị tự nhiên 160g.",
				   ImageUrl = "Do_An_Vat/Snack Lay Stax khoai tây vị tự nhiên 160g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 14,
				   ProductName = "Bột canh i-ốt Hải Châu gói 190g",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Bột canh i-ốt Hải Châu gói 190g.",
				   ImageUrl = "Gia_Vi/Bột canh i-ốt Hải Châu gói 190g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 15,
				   ProductName = "Bột ngọt (mì chính) Ajinomoto 2kg",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Bột ngọt (mì chính) Ajinomoto 2kg.",
				   ImageUrl = "Gia_Vi/Bột ngọt (mì chính) Ajinomoto 2kg.png",
				   IsAlcoholic = false
			   },
				new Product
				{
					ProductID = 16,
					ProductName = "Bột ngọt (mì chính) Ajinomoto 400g",
					CategoryID = 2,
					Price = 120000,
					Stock = 30,
					Description = "Bột ngọt (mì chính) Ajinomoto 400g.",
					ImageUrl = "Gia_Vi/Bột ngọt (mì chính) Ajinomoto 400g.png",
					IsAlcoholic = false
				},
			   new Product
			   {
				   ProductID = 17,
				   ProductName = "Dầu hào Lee Kum Kee Kum Chun chai 255g",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Dầu hào Lee Kum Kee Kum Chun chai 255g.",
				   ImageUrl = "Gia_Vi/Dầu hào Lee Kum Kee Kum Chun chai 255g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 18,
				   ProductName = "Dầu hào Maggi chai 350g",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Dầu hào Maggi chai 350g.",
				   ImageUrl = "Gia_Vi/Dầu hào Maggi chai 350g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 19,
				   ProductName = "Gia vị nêm sẵn lẩu Thái Aji-Quick gói 50g",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Gia vị nêm sẵn lẩu Thái Aji-Quick gói 50g.",
				   ImageUrl = "Gia_Vi/Gia vị nêm sẵn lẩu Thái Aji-Quick gói 50g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 20,
				   ProductName = "Nước mắm Phú Quốc Thanh Quốc 35 độ đạm",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước mắm Phú Quốc Thanh Quốc 35 độ đạm.",
				   ImageUrl = "Gia_Vi/Nước mắm Phú Quốc Thanh Quốc 35 độ đạm.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 21,
				   ProductName = "Bột ngọt (mì chính) Miwon gói 454g",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Bột ngọt (mì chính) Miwon gói 454g.",
				   ImageUrl = "Gia_Vi/Bột ngọt (mì chính) Miwon gói 454g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 22,
				   ProductName = "Tương ớt chua ngọt Cholimex chai 270g",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Tương ớt chua ngọt Cholimex chai 270g.",
				   ImageUrl = "Gia_Vi/Tương ớt chua ngọt Cholimex chai 270g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 23,
				   ProductName = "Tương ớt chua ngọt Cholimex PET 2.1kg",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Tương ớt chua ngọt Cholimex PET 2.1kg.",
				   ImageUrl = "Gia_Vi/Tương ớt chua ngọt Cholimex PET 2.1kg.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 24,
				   ProductName = "Cà phê hòa tan 3in1 G7 hộp 288g",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Cà phê hòa tan 3in1 G7 hộp 288g.",
				   ImageUrl = "Nuoc_Giai_Khat/Cà phê hòa tan 3in1 G7 hộp 288g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 25,
				   ProductName = "Cà phê sữa đá Highlands Coffee lon 235ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Cà phê sữa đá Highlands Coffee lon 235ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Cà phê sữa đá Highlands Coffee lon 235ml.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 26,
				   ProductName = "Nước giải khát Coca Cola chai 1.5lít",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước giải khát Coca Cola chai 1.5lít.",
				   ImageUrl = "Nuoc_Giai_Khat/Nước giải khát Coca Cola chai 1.5lít.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 27,
				   ProductName = "Nước khoáng thiên nhiên LaVie 1.5 lít",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước khoáng thiên nhiên LaVie 1.5 lít.",
				   ImageUrl = "Nuoc_Giai_Khat/Nước khoáng thiên nhiên LaVie 1.5 lít.png",
				   IsAlcoholic = false
			   },

			   new Product
			   {
				   ProductID = 28,
				   ProductName = "Nước uống sữa trái cây bổ dưỡng hương cam Nutri Boost chai 1L",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước uống sữa trái cây bổ dưỡng hương cam Nutri Boost chai 1L.",
				   ImageUrl = "Nuoc_Giai_Khat/Nước uống sữa trái cây bổ dưỡng hương cam Nutri Boost chai 1L.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 29,
				   ProductName = "Nước uống tăng lực Việt Redbull lon 250ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước uống tăng lực Việt Redbull lon 250ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Nước uống tăng lực Việt Redbull lon 250ml.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 30,
				   ProductName = "Nước uống tinh khiết Dasani chai 1.5 lít",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước uống tinh khiết Dasani chai 1.5 lít.",
				   ImageUrl = "Nuoc_Giai_Khat/Nước uống tinh khiết Dasani chai 1.5 lít.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 31,
				   ProductName = "Thùng 24 lon bia Hà Nội Habeco 330ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Thùng 24 lon bia Hà Nội Habeco 330ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Thùng 24 lon bia Hà Nội Habeco 330ml.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 32,
				   ProductName = "Thùng 24 lon bia Heineken 330ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Thùng 24 lon bia Heineken 330ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Thùng 24 lon bia Heineken 330ml.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 33,
				   ProductName = "Thùng 24 lon Bia Saigon lager 330ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Thùng 24 lon Bia Saigon lager 330ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Thùng 24 lon Bia Saigon lager 330ml.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 34,
				   ProductName = "Thùng 36 hộp sữa đậu nành Fami canxi ít đường 200ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Thùng 36 hộp sữa đậu nành Fami canxi ít đường 200ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Thùng 36 hộp sữa đậu nành Fami canxi ít đường 200ml.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 35,
				   ProductName = "Trà bí đao Wonderfarm lon 310ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Trà bí đao Wonderfarm lon 310ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Trà bí đao Wonderfarm lon 310ml.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 36,
				   ProductName = "Cháo thịt bằm Vifon gói 70g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Cháo thịt bằm Vifon gói 70g.",
				   ImageUrl = "Thuc_Pham_An_Lien/Cháo thịt bằm Vifon gói 70g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 37,
				   ProductName = "Mì gói ăn liền cay Shin Ramyun Nongshim 114g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Mì gói ăn liền cay Shin Ramyun Nongshim 114g.",
				   ImageUrl = "Thuc_Pham_An_Lien/Mì gói ăn liền cay Shin Ramyun Nongshim 114g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 38,
				   ProductName = "Phở gà Đệ Nhất gói 65g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Phở gà Đệ Nhất gói 65g.",
				   ImageUrl = "Thuc_Pham_An_Lien/Phở gà Đệ Nhất gói 65g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 39,
				   ProductName = "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.",
				   ImageUrl = "Thuc_Pham_An_Lien/Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 40,
				   ProductName = "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.",
				   ImageUrl = "Thuc_Pham_An_Lien/Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 41,
				   ProductName = "Thùng 30 gói mì tôm chua cay Hảo Hảo Vina Acecook 75g - Thùng",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Thùng 30 gói mì tôm chua cay Hảo Hảo Vina Acecook 75g - Thùng.",
				   ImageUrl = "Thuc_Pham_An_Lien/Thùng 30 gói mì tôm chua cay Hảo Hảo Vina Acecook 75g - Thùng.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 42,
				   ProductName = "Bánh snack Poca mực lăn muối ớt",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Bánh snack Poca mực lăn muối ớt.",
				   ImageUrl = "Do_An_Vat/Bánh snack Poca mực lăn muối ớt.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 43,
				   ProductName = "Bắp Rang Bơ Thơm-Ngon-Giòn ONENUTS",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Bắp Rang Bơ Thơm-Ngon-Giòn ONENUTS.",
				   ImageUrl = "Do_An_Vat/Bắp Rang Bơ Thơm-Ngon-Giòn ONENUTS.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 44,
				   ProductName = "Bim Bim Snack Bắp 4x Vị Cay Oishi",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Bim Bim Snack Bắp 4x Vị Cay Oishi.",
				   ImageUrl = "Do_An_Vat/Bim Bim Snack Bắp 4x Vị Cay Oishi.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 45,
				   ProductName = "Kẹo Dẻo Hương Trái Cây Chupa Chups 1m",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Kẹo Dẻo Hương Trái Cây Chupa Chups 1m.",
				   ImageUrl = "Do_An_Vat/Kẹo Dẻo Hương Trái Cây Chupa Chups 1m.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 46,
				   ProductName = "Snack Cà Chua Tomati",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Snack Cà Chua Tomati.",
				   ImageUrl = "Do_An_Vat/Snack Cà Chua Tomati.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 47,
				   ProductName = "Snack hành Oishi Onion Rings",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Snack hành Oishi Onion Rings.",
				   ImageUrl = "Do_An_Vat/Snack hành Oishi Onion Rings.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 48,
				   ProductName = "SNACK KHOAI TÂY LAY’S VỊ TẢO BIỂN 95G",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "SNACK KHOAI TÂY LAY’S VỊ TẢO BIỂN 95G.",
				   ImageUrl = "Do_An_Vat/SNACK KHOAI TÂY LAY’S VỊ TẢO BIỂN 95G.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 49,
				   ProductName = "Snack khoai tây phô mai Karamucho Koikeya",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Snack khoai tây phô mai Karamucho Koikeya.",
				   ImageUrl = "Do_An_Vat/Snack khoai tây phô mai Karamucho Koikeya.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 50,
				   ProductName = "Snack Lay's Wavy vị thăn bò nướng texas 95g",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Snack Lay's Wavy vị thăn bò nướng texas 95g.",
				   ImageUrl = "Do_An_Vat/Snack Lay's Wavy vị thăn bò nướng texas 95g.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 51,
				   ProductName = "Snack Phô Mai Miếng Oishi",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Snack Phô Mai Miếng Oishi.",
				   ImageUrl = "Do_An_Vat/Snack Phô Mai Miếng Oishi.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 52,
				   ProductName = "Snack vị tôm cay Oishi",
				   CategoryID = 1,
				   Price = 120000,
				   Stock = 30,
				   Description = "Snack vị tôm cay Oishi.",
				   ImageUrl = "Do_An_Vat/Snack vị tôm cay Oishi.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 53,
				   ProductName = "Bộ thau rổ cao cấp Yoko",
				   CategoryID = 6,
				   Price = 120000,
				   Stock = 30,
				   Description = "Bộ thau rổ cao cấp Yoko.",
				   ImageUrl = "Dung_Cu_Nha_Bep/Bộ thau rổ cao cấp Yoko.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 54,
				   ProductName = "Đĩa sứ cao cấp",
				   CategoryID = 6,
				   Price = 120000,
				   Stock = 30,
				   Description = "Đĩa sứ cao cấp.",
				   ImageUrl = "Dung_Cu_Nha_Bep/Đĩa sứ cao cấp.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 55,
				   ProductName = "Đũa tre dùng một lần Quang Hà",
				   CategoryID = 6,
				   Price = 120000,
				   Stock = 30,
				   Description = "Đũa tre dùng một lần Quang Hà.",
				   ImageUrl = "Dung_Cu_Nha_Bep/Đũa tre dùng một lần Quang Hà.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 56,
				   ProductName = "Kéo nhà bếp KJ01 21cm",
				   CategoryID = 6,
				   Price = 120000,
				   Stock = 30,
				   Description = "Kéo nhà bếp KJ01 21cm.",
				   ImageUrl = "Dung_Cu_Nha_Bep/Kéo nhà bếp KJ01 21cm.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 57,
				   ProductName = "Lô túi rác tiện dụng Soji",
				   CategoryID = 6,
				   Price = 120000,
				   Stock = 30,
				   Description = "Lô túi rác tiện dụng Soji.",
				   ImageUrl = "Dung_Cu_Nha_Bep/Lô túi rác tiện dụng Soji.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 58,
				   ProductName = "Ly Thủy Tinh Luminarc",
				   CategoryID = 6,
				   Price = 120000,
				   Stock = 30,
				   Description = "Ly Thủy Tinh Luminarc.",
				   ImageUrl = "Dung_Cu_Nha_Bep/Ly Thủy Tinh Luminarc.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 59,
				   ProductName = "Muôi múc canh Duxton",
				   CategoryID = 6,
				   Price = 120000,
				   Stock = 30,
				   Description = "Muôi múc canh Duxton.",
				   ImageUrl = "Dung_Cu_Nha_Bep/Muôi múc canh Duxton.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 60,
				   ProductName = "Muỗng gỗ xào nấu",
				   CategoryID = 6,
				   Price = 120000,
				   Stock = 30,
				   Description = "Muỗng gỗ xào nấu.",
				   ImageUrl = "Dung_Cu_Nha_Bep/Muỗng gỗ xào nấu.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 61,
				   ProductName = "Thìa inox Bếp Xinh",
				   CategoryID = 6,
				   Price = 120000,
				   Stock = 30,
				   Description = "Thìa inox Bếp Xinh.",
				   ImageUrl = "Dung_Cu_Nha_Bep/Thìa inox Bếp Xinh.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 62,
				   ProductName = "Thớt tre tự nhiên Sunhouse",
				   CategoryID = 6,
				   Price = 120000,
				   Stock = 30,
				   Description = "Thớt tre tự nhiên Sunhouse.",
				   ImageUrl = "Dung_Cu_Nha_Bep/Thớt tre tự nhiên Sunhouse.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 63,
				   ProductName = "Bột canh i-ốt Hải Châu",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Bột canh i-ốt Hải Châu.",
				   ImageUrl = "Gia_Vi/Bột canh i-ốt Hải Châu.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 64,
				   ProductName = "Tương ớt chua ngọt Cholimex chai 270g",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Tương ớt chua ngọt Cholimex chai 270g.",
				   ImageUrl = "Gia_Vi/Tương ớt chua ngọt Cholimex chai 270g.png",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 65,
				   ProductName = "Bột Ngọt Meizan",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Bột Ngọt Meizan.",
				   ImageUrl = "Gia_Vi/Bột Ngọt Meizan.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 66,
				   ProductName = "Cholimex Food - Tương ớt xí muội chai PET",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Cholimex Food - Tương ớt xí muội chai PET.",
				   ImageUrl = "Gia_Vi/Cholimex Food - Tương ớt xí muội chai PET.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 67,
				   ProductName = "Dầu đậu nành Simply chai 1 lít",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Dầu đậu nành Simply chai 1 lít.",
				   ImageUrl = "Gia_Vi/Dầu đậu nành Simply chai 1 lít.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 68,
				   ProductName = "Dầu hào chay Maggi nấm hương chai",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Dầu hào chay Maggi nấm hương chai.",
				   ImageUrl = "Gia_Vi/Dầu hào chay Maggi nấm hương chai.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 69,
				   ProductName = "Nước mắm Nam Ngư Cá Cơm Tươi",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước mắm Nam Ngư Cá Cơm Tươi.",
				   ImageUrl = "Gia_Vi/Nước mắm Nam Ngư Cá Cơm Tươi.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 70,
				   ProductName = "Sốt Mayonnaise Aji-Mayo Vị Chua Béo Chai 260g",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Sốt Mayonnaise Aji-Mayo Vị Chua Béo Chai 260g.",
				   ImageUrl = "Gia_Vi/Sốt Mayonnaise Aji-Mayo Vị Chua Béo Chai 260g.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 71,
				   ProductName = "7up lon 320ml vị chanh",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "7up lon 320ml vị chanh.",
				   ImageUrl = "Nuoc_Giai_Khat/7up lon 320ml vị chanh.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 72,
				   ProductName = "Chai nước tăng lực sting đỏ của pepsiCo 320ml",
				   CategoryID = 2,
				   Price = 120000,
				   Stock = 30,
				   Description = "Chai nước tăng lực sting đỏ của pepsiCo 320ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Chai nước tăng lực sting đỏ của pepsiCo 320ml.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 73,
				   ProductName = "Nước cam ép TH True Juice chai 350ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước cam ép TH True Juice chai 350ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Nước cam ép TH True Juice chai 350ml.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 74,
				   ProductName = "Nước ngọt Coca Cola lon 320ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước ngọt Coca Cola lon 320ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Nước ngọt Coca Cola lon 320ml.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 75,
				   ProductName = "Nước Sữa Trái Cây TH True Juice Milk Vị Cam Tự Nhiên Chai 300ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước Sữa Trái Cây TH True Juice Milk Vị Cam Tự Nhiên Chai 300ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Nước Sữa Trái Cây TH True Juice Milk Vị Cam Tự Nhiên Chai 300ml.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 76,
				   ProductName = "Nước tăng lực number1",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Nước tăng lực number1.",
				   ImageUrl = "Nuoc_Giai_Khat/Nước tăng lực number1.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 77,
				   ProductName = "Trà Đào TVT Chai 450Ml",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Trà Đào TVT Chai 450Ml.",
				   ImageUrl = "Nuoc_Giai_Khat/Trà Đào TVT Chai 450Ml.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 78,
				   ProductName = "Trà xanh hương chanh tuyết bạc hà C2 freeze",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "Trà xanh hương chanh tuyết bạc hà C2 freeze.",
				   ImageUrl = "Nuoc_Giai_Khat/Trà xanh hương chanh tuyết bạc hà C2 freeze.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 79,
				   ProductName = "TRÀ XANH KHÔNG ĐỘ chai 455ML",
				   CategoryID = 3,
				   Price = 120000,
				   Stock = 30,
				   Description = "TRÀ XANH KHÔNG ĐỘ chai 455ML.",
				   ImageUrl = "Nuoc_Giai_Khat/TRÀ XANH KHÔNG ĐỘ chai 455ML.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 80,
				   ProductName = "Mì 3 Miền Gold Tôm Chua Cay Đặc Biệt 75g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Mì 3 Miền Gold Tôm Chua Cay Đặc Biệt 75g.",
				   ImageUrl = "Thuc_Pham_An_Lien/Mì 3 Miền Gold Tôm Chua Cay Đặc Biệt 75g.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 81,
				   ProductName = "Mì Bò Hầm Ottogi 120G",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Mì Bò Hầm Ottogi 120G.",
				   ImageUrl = "Thuc_Pham_An_Lien/Mì Bò Hầm Ottogi 120G.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 82,
				   ProductName = "MÌ CUNG ĐÌNH VỊ LẨU TÔM CHUA CAY 80g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "MÌ CUNG ĐÌNH VỊ LẨU TÔM CHUA CAY 80g.",
				   ImageUrl = "Thuc_Pham_An_Lien/MÌ CUNG ĐÌNH VỊ LẨU TÔM CHUA CAY 80g.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 83,
				   ProductName = "Mì Hảo Hảo big 100g tôm chua cay 100g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Mì Hảo Hảo big 100g tôm chua cay 100g.",
				   ImageUrl = "Thuc_Pham_An_Lien/Mì Hảo Hảo big 100g tôm chua cay 100g.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 84,
				   ProductName = "Mì khoai tây Omachi sườn hầm ngũ quả gói 80g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Mì khoai tây Omachi sườn hầm ngũ quả gói 80g.",
				   ImageUrl = "Thuc_Pham_An_Lien/Mì khoai tây Omachi sườn hầm ngũ quả gói 80g.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 85,
				   ProductName = "Mì khoai tây Omachi xốt bò hầm gói 80g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Mì khoai tây Omachi xốt bò hầm gói 80g.",
				   ImageUrl = "Thuc_Pham_An_Lien/Mì khoai tây Omachi xốt bò hầm gói 80g.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 86,
				   ProductName = "Mì Koreno vị kim chi gói 100g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Mì Koreno vị kim chi gói 100g.",
				   ImageUrl = "Thuc_Pham_An_Lien/Mì Koreno vị kim chi gói 100g.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 87,
				   ProductName = "Mì trộn Omachi xốt Spaghetti gói 90g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Mì trộn Omachi xốt Spaghetti gói 90g.",
				   ImageUrl = "Thuc_Pham_An_Lien/Mì trộn Omachi xốt Spaghetti gói 90g.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 88,
				   ProductName = "MÌ TƯƠNG ĐEN BẮC KINH GÓI 83G",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "MÌ TƯƠNG ĐEN BẮC KINH GÓI 83G.",
				   ImageUrl = "Thuc_Pham_An_Lien/MÌ TƯƠNG ĐEN BẮC KINH GÓI 83G.jpg",
				   IsAlcoholic = false
			   },
			   new Product
			   {
				   ProductID = 89,
				   ProductName = "Phở trộn Đệ Nhất vị thập cẩm cay gói 82g",
				   CategoryID = 4,
				   Price = 120000,
				   Stock = 30,
				   Description = "Phở trộn Đệ Nhất vị thập cẩm cay gói 82g.",
				   ImageUrl = "Thuc_Pham_An_Lien/Phở trộn Đệ Nhất vị thập cẩm cay gói 82g.jpg",
				   IsAlcoholic = false
			   }
		   );
			modelBuilder.Entity<Combo>().HasData(
				new Combo
				{
					ComboID = 1,
					ComboName = "Combo Bò Nướng",
					Price = 290000,
					Description = "Combo Bò Nướng",
					ImageUrl = "Combo/Combo Bò Nướng.jpg"
				},
				new Combo
				{
					ComboID = 2,
					ComboName = "Combo Heo Nướng",
					Price = 290000,
					Description = "Combo Heo Nướng",
					ImageUrl = "Combo/Combo Heo Nướng.jpg"
				},
				new Combo
				{
					ComboID = 3,
					ComboName = "Combo Nướng Thập Cẩm Đặc Biệt",
					Price = 350000,
					Description = "Combo Nướng Thập Cẩm Đặc Biệt",
					ImageUrl = "Combo/Combo Nướng Thập Cẩm Đặc Biệt.jpg"
				},
				new Combo
				{
					ComboID = 4,
					ComboName = "Lẩu Kim Chi Bò Thập Cẩm",
					Price = 350000,
					Description = "Lẩu Kim Chi Bò Thập Cẩm",
					ImageUrl = "Combo/Lẩu Kim Chi Bò Thập Cẩm.jpg"
				},
				new Combo
				{
					ComboID = 5,
					ComboName = "Lẩu Kim Chi Hải Sản",
					Price = 290000,
					Description = "Lẩu Kim Chi Hải Sản",
					ImageUrl = "Combo/Lẩu Kim Chi Hải Sản.jpg"
				},
				new Combo
				{
					ComboID = 6,
					ComboName = "Lẩu Nấm Thập Cẩm Đặc Biệt",
					Price = 350000,
					Description = "Lẩu Nấm Thập Cẩm Đặc Biệt",
					ImageUrl = "Combo/Lẩu Nấm Thập Cẩm Đặc Biệt.jpg"
				},
				new Combo
				{
					ComboID = 7,
					ComboName = "Lẩu Riêu Cua Bắp Bò Sườn Sụn",
					Price = 290000,
					Description = "Lẩu Riêu Cua Bắp Bò Sườn Sụn",
					ImageUrl = "Combo/Lẩu Riêu Cua Bắp Bò Sườn Sụn.jpg"
				},
				new Combo
				{
					ComboID = 8,
					ComboName = "Lẩu Riêu Cua Bắp Bò",
					Price = 290000,
					Description = "Lẩu Riêu Cua Bắp Bò",
					ImageUrl = "Combo/Lẩu Riêu Cua Bắp Bò.jpg"
				},
				new Combo
				{
					ComboID = 9,
					ComboName = "Lẩu Riêu Cua Bò Mỹ Sườn Sụn",
					Price = 350000,
					Description = "Lẩu Riêu Cua Bò Mỹ Sườn Sụn",
					ImageUrl = "Combo/Lẩu Riêu Cua Bò Mỹ Sườn Sụn.jpg"
				},
				new Combo
				{
					ComboID = 10,
					ComboName = "Lẩu Riêu Cua Bò Thập Cẩm",
					Price = 290000,
					Description = "Lẩu Riêu Cua Bò Thập Cẩm",
					ImageUrl = "Combo/Lẩu Riêu Cua Bò Thập Cẩm.jpg"
				},
				new Combo
				{
					ComboID = 11,
					ComboName = "Lẩu Riêu Cua Thập Cẩm",
					Price = 290000,
					Description = "Lẩu Riêu Cua Thập Cẩm",
					ImageUrl = "Combo/Lẩu Riêu Cua Thập Cẩm.jpg"
				},
				new Combo
				{
					ComboID = 12,
					ComboName = "Lẩu Thái Bò Thập Cẩm",
					Price = 290000,
					Description = "Lẩu Thái Bò Thập Cẩm",
					ImageUrl = "Combo/Lẩu Thái Bò Thập Cẩm.jpg"
				},
				new Combo
				{
					ComboID = 13,
					ComboName = "Lẩu Thái Hải Sản",
					Price = 290000,
					Description = "Lẩu Thái Hải Sản",
					ImageUrl = "Combo/Lẩu Thái Hải Sản.jpg"
				},
				new Combo
				{
					ComboID = 14,
					ComboName = "Lẩu Thái Thập Cẩm 1",
					Price = 290000,
					Description = "Lẩu Thái Thập Cẩm 1",
					ImageUrl = "Combo/Lẩu Thái Thập Cẩm 1.jpg"
				}
				);
			modelBuilder.Entity<Order>().HasData(
				new Order
				{
					OrderID = 1,
					UserID = 7, // Tương ứng với user "TungUser"
					TotalAmount = 60000,
					FullName = "Nguyễn Việt Tùng",
					PhoneNumber = "0123456789",
					ShippingAddress = "123 Main Street, Hanoi",
					PaymentStatus = "Paid",
					PaymentGateway = "Credit Card",
					CreatedAt = DateTime.Now.AddDays(-5)
				},
				new Order
				{
					OrderID = 2,
					UserID = 8, // Tương ứng với user "ToanUser"
					FullName = "Nguyễn Văn Toàn",
					PhoneNumber = "0123456789",
					TotalAmount = 65000,
					ShippingAddress = "456 Secondary Street, HCM",
					PaymentStatus = "Pending",
					PaymentGateway = "COD",
					CreatedAt = DateTime.Now.AddDays(-3)
				},
				new Order
				{
					OrderID = 3,
					UserID = 9, // Tương ứng với user "CuongUser"
					FullName = "Phạm Xuân Cường",
					PhoneNumber = "0123456789",
					TotalAmount = 250000,
					ShippingAddress = "789 Tertiary Avenue, Da Nang",
					PaymentStatus = "Paid",
					PaymentGateway = "Bank Transfer",
					CreatedAt = DateTime.Now.AddDays(-1)
				}

			);

			// Seed data for OrderDetails
			modelBuilder.Entity<OrderDetail>().HasData(
				new OrderDetail
				{
					OrderDetailID = 1,
					OrderID = 1,
					ProductID = 1, // Bánh gạo Jinju cốm sữa
					Quantity = 2,
					Price = 20000
				},
				new OrderDetail
				{
					OrderDetailID = 2,
					OrderID = 1,
					ProductID = 2, // Bánh quế Oreo vị vani
					Quantity = 1,
					Price = 10000
				},
				new OrderDetail
				{
					OrderDetailID = 3,
					OrderID = 2,
					ProductID = 3, // Bánh quy bơ Cosy
					Quantity = 3,
					Price = 15000
				},
				new OrderDetail
				{
					OrderDetailID = 4,
					OrderID = 2,
					ProductID = 4, // Bánh quy bơ Danisa
					Quantity = 1,
					Price = 12000
				},
				new OrderDetail
				{
					OrderDetailID = 5,
					OrderID = 3,
					ProductID = 5, // Hộp bánh Pocky Glico
					Quantity = 1,
					Price = 120000
				},
				new OrderDetail
				{
					OrderDetailID = 6,
					OrderID = 3,
					ProductID = 6, // Hộp quà Tết Hamper
					Quantity = 1,
					Price = 120000
				}
			);
		}
	}
}
