using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Đồ ăn vặt", "Đồ ăn vặt" },
                    { 2, "Gia vị", "Gia vị" },
                    { 3, "Nước giải khát", "Nước giải khát" },
                    { 4, "Thực phẩm ăn liền", "Thực phẩm ăn liền" },
                    { 5, "Thực phẩm tươi sống", "Thực phẩm tươi sống" },
                    { 6, "Dụng cụ nhà bếp", "Dụng cụ nhà bếp" }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "ComboID", "ComboName", "Description", "ImageUrl", "Price" },
                values: new object[,]
                {
                    { 1, "Combo Bò Nướng", "Combo Bò Nướng", "Combo/Combo Bò Nướng.jpg", 290000 },
                    { 2, "Combo Heo Nướng", "Combo Heo Nướng", "Combo/Combo Heo Nướng.jpg", 290000 },
                    { 3, "Combo Nướng Thập Cẩm Đặc Biệt", "Combo Nướng Thập Cẩm Đặc Biệt", "Combo/Combo Nướng Thập Cẩm Đặc Biệt.jpg", 350000 },
                    { 4, "Lẩu Kim Chi Bò Thập Cẩm", "Lẩu Kim Chi Bò Thập Cẩm", "Combo/Lẩu Kim Chi Bò Thập Cẩm.jpg", 350000 },
                    { 5, "Lẩu Kim Chi Hải Sản", "Lẩu Kim Chi Hải Sản", "Combo/Lẩu Kim Chi Hải Sản.jpg", 290000 },
                    { 6, "Lẩu Nấm Thập Cẩm Đặc Biệt", "Lẩu Nấm Thập Cẩm Đặc Biệt", "Combo/Lẩu Nấm Thập Cẩm Đặc Biệt.jpg", 350000 },
                    { 7, "Lẩu Riêu Cua Bắp Bò Sườn Sụn", "Lẩu Riêu Cua Bắp Bò Sườn Sụn", "Combo/Lẩu Riêu Cua Bắp Bò Sườn Sụn.jpg", 290000 },
                    { 8, "Lẩu Riêu Cua Bắp Bò", "Lẩu Riêu Cua Bắp Bò", "Combo/Lẩu Riêu Cua Bắp Bò.jpg", 290000 },
                    { 9, "Lẩu Riêu Cua Bò Mỹ Sườn Sụn", "Lẩu Riêu Cua Bò Mỹ Sườn Sụn", "Combo/Lẩu Riêu Cua Bò Mỹ Sườn Sụn.jpg", 350000 },
                    { 10, "Lẩu Riêu Cua Bò Thập Cẩm", "Lẩu Riêu Cua Bò Thập Cẩm", "Combo/Lẩu Riêu Cua Bò Thập Cẩm.jpg", 290000 },
                    { 11, "Lẩu Riêu Cua Thập Cẩm", "Lẩu Riêu Cua Thập Cẩm", "Combo/Lẩu Riêu Cua Thập Cẩm.jpg", 290000 },
                    { 12, "Lẩu Thái Bò Thập Cẩm", "Lẩu Thái Bò Thập Cẩm", "Combo/Lẩu Thái Bò Thập Cẩm.jpg", 290000 },
                    { 13, "Lẩu Thái Hải Sản", "Lẩu Thái Hải Sản", "Combo/Lẩu Thái Hải Sản.jpg", 290000 },
                    { 14, "Lẩu Thái Thập Cẩm 1", "Lẩu Thái Thập Cẩm 1", "Combo/Lẩu Thái Thập Cẩm 1.jpg", 290000 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 53, 433, DateTimeKind.Local).AddTicks(3892), "$2a$11$5s6.QViXtGMGtXHC4n5/Ie5OOlhNqYkMYxjeMsMMfV0xoOoNbFL3G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 53, 567, DateTimeKind.Local).AddTicks(3487), "$2a$11$KCJK8/REzUQek/ym6nS7wOimV7hc7ZhpkKxHImyegqwbM3omCmc1i" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 53, 707, DateTimeKind.Local).AddTicks(5255), "$2a$11$UXU8dAUFSsebPicb.h1rS.DAz.Tm4eWwCKAtU1s5FxOnnJs5Y3/9G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 53, 834, DateTimeKind.Local).AddTicks(4565), "$2a$11$vppbdPrIWmhgBenzd5eWn.s2kEjcQKTI2LUgwp4butIolv59wFdkS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 53, 961, DateTimeKind.Local).AddTicks(2207), "$2a$11$Yxs0imhXyHbp1xbI00HWXeL4fSasfSBoqgcauyLXM4szfgZ8ZOFjy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 54, 87, DateTimeKind.Local).AddTicks(85), "$2a$11$I3caSwCh6i15Art4weBBUuzzSGJt47THhtByDi6pov7I2lV5Q6.IC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash", "Role" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 54, 216, DateTimeKind.Local).AddTicks(6913), "$2a$11$wJBvNcHjxKNfUzG97feiuuEYYTCZ8HNC0KSWaBlwcWGLmcgtskvwW", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash", "Role" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 54, 350, DateTimeKind.Local).AddTicks(3230), "$2a$11$6h5V/80R4opZ8LTfB6DH8uQjRLrvCS12suuvcPcVz8IcZMDvRYnr.", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash", "Role" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 54, 478, DateTimeKind.Local).AddTicks(5160), "$2a$11$ozOD2DLfiSG01UTmvp1PheX0xTxse/zsdM8cn/igjFqT12FEU50j.", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash", "Role" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 54, 605, DateTimeKind.Local).AddTicks(5844), "$2a$11$0Q6bYliuSHOmans1m9tARO4u8w4igjVrw30hPqw01Iq4caXHTBIN2", "Customer" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImageUrl", "IsAlcoholic", "Price", "ProductName", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "Snack khoai tây giòn rụm, vị phô mai thơm ngon.", "Do_An_Vat/Bánh gạo Jinju cốm sữa.png", false, 20000, "Bánh gạo Jinju cốm sữa", 50 },
                    { 2, 1, "Bánh quế Oreo vị vani hộp 54g.", "Do_An_Vat/Bánh quế Oreo vị vani hộp 54g.png", false, 10000, "Bánh quế Oreo vị vani hộp 54g", 100 },
                    { 3, 1, "Bánh quy bơ Cosy thập cẩm rắc hạt hộp 336g.", "Do_An_Vat/Bánh quy bơ Cosy thập cẩm rắc hạt hộp 336g.png", false, 15000, "Bánh quy bơ Cosy thập cẩm rắc hạt hộp 336g", 200 },
                    { 4, 1, "Bánh quy bơ Danisa hộp 908g.", "Do_An_Vat/Bánh quy bơ Danisa hộp 908g.png", false, 12000, "Bánh quy bơ Danisa hộp 908g", 150 },
                    { 5, 1, "Hộp Bánh Pocky Glico 118g.", "Do_An_Vat/Hộp Bánh Pocky Glico 118g.png", false, 120000, "Hộp Bánh Pocky Glico 118g", 30 },
                    { 6, 1, "Hộp quà Tết Hamper 1 x 6H 727.2g", "Do_An_Vat/Hộp quà Tết Hamper 1 x 6H 727.2g.png", false, 120000, "Hộp quà Tết Hamper 1 x 6H 727.2g", 30 },
                    { 7, 1, "Kẹo sing gum hương bạc hà và khuynh diệp CooL Air Wrigley's hộp 58,4g.", "Do_An_Vat/Kẹo sing gum hương bạc hà và khuynh diệp CooL Air Wrigley's hộp 58,4g.png", false, 120000, "Kẹo sing gum hương bạc hà và khuynh diệp CooL Air Wrigley's hộp 58,4g", 30 },
                    { 8, 1, "Kẹo Socola Snickers Túi 3 thanh 51g", "Do_An_Vat/Kẹo Socola Snickers Túi 3 thanh 51g.png", false, 120000, "Kẹo Socola Snickers Túi 3 thanh 51g", 30 },
                    { 9, 1, "Kẹo Socola Sữa Popit Tết 90.1g.", "Do_An_Vat/Kẹo Socola Sữa Popit Tết 90.1g.png", false, 120000, "Kẹo Socola Sữa Popit Tết 90.1g", 30 },
                    { 10, 1, "Khoai tây LAY'S vị tự nhiên classic 150g.", "Do_An_Vat/Khoai tây LAY'S vị tự nhiên classic 150g.png", false, 120000, "Khoai tây LAY'S vị tự nhiên classic 150g", 30 },
                    { 11, 1, "Mít sấy Vinamit gói 100g.", "Do_An_Vat/Mít sấy Vinamit gói 100g.png", false, 120000, "Mít sấy Vinamit gói 100g", 30 },
                    { 12, 1, "Snach khoai tây Lay's tôm hùm cay lon 105 g.", "Do_An_Vat/Snach khoai tây Lay's tôm hùm cay lon 105 g.png", false, 120000, "Snach khoai tây Lay's tôm hùm cay lon 105 g", 30 },
                    { 13, 1, "Snack Lay Stax khoai tây vị tự nhiên 160g.", "Do_An_Vat/Snack Lay Stax khoai tây vị tự nhiên 160g.png", false, 120000, "Snack Lay Stax khoai tây vị tự nhiên 160g", 30 },
                    { 14, 2, "Bột canh i-ốt Hải Châu gói 190g.", "Gia_Vi/Bột canh i-ốt Hải Châu gói 190g.png", false, 120000, "Bột canh i-ốt Hải Châu gói 190g", 30 },
                    { 15, 2, "Bột ngọt (mì chính) Ajinomoto 2kg.", "Gia_Vi/Bột ngọt (mì chính) Ajinomoto 2kg.png", false, 120000, "Bột ngọt (mì chính) Ajinomoto 2kg", 30 },
                    { 16, 2, "Bột ngọt (mì chính) Ajinomoto 400g.", "Gia_Vi/Bột ngọt (mì chính) Ajinomoto 400g.png", false, 120000, "Bột ngọt (mì chính) Ajinomoto 400g", 30 },
                    { 17, 2, "Dầu hào Lee Kum Kee Kum Chun chai 255g.", "Gia_Vi/Dầu hào Lee Kum Kee Kum Chun chai 255g.png", false, 120000, "Dầu hào Lee Kum Kee Kum Chun chai 255g", 30 },
                    { 18, 2, "Dầu hào Maggi chai 350g.", "Gia_Vi/Dầu hào Maggi chai 350g.png", false, 120000, "Dầu hào Maggi chai 350g", 30 },
                    { 19, 2, "Gia vị nêm sẵn lẩu Thái Aji-Quick gói 50g.", "Gia_Vi/Gia vị nêm sẵn lẩu Thái Aji-Quick gói 50g.png", false, 120000, "Gia vị nêm sẵn lẩu Thái Aji-Quick gói 50g", 30 },
                    { 20, 2, "Nước mắm Phú Quốc Thanh Quốc 35 độ đạm.", "Gia_Vi/Nước mắm Phú Quốc Thanh Quốc 35 độ đạm.png", false, 120000, "Nước mắm Phú Quốc Thanh Quốc 35 độ đạm", 30 },
                    { 21, 2, "Bột ngọt (mì chính) Miwon gói 454g.", "Gia_Vi/Bột ngọt (mì chính) Miwon gói 454g.png", false, 120000, "Bột ngọt (mì chính) Miwon gói 454g", 30 },
                    { 22, 2, "Tương ớt chua ngọt Cholimex chai 270g.", "Gia_Vi/Tương ớt chua ngọt Cholimex chai 270g.png", false, 120000, "Tương ớt chua ngọt Cholimex chai 270g", 30 },
                    { 23, 2, "Tương ớt chua ngọt Cholimex PET 2.1kg.", "Gia_Vi/Tương ớt chua ngọt Cholimex PET 2.1kg.png", false, 120000, "Tương ớt chua ngọt Cholimex PET 2.1kg", 30 },
                    { 24, 3, "Cà phê hòa tan 3in1 G7 hộp 288g.", "Nuoc_Giai_Khat/Cà phê hòa tan 3in1 G7 hộp 288g.png", false, 120000, "Cà phê hòa tan 3in1 G7 hộp 288g", 30 },
                    { 25, 3, "Cà phê sữa đá Highlands Coffee lon 235ml.", "Nuoc_Giai_Khat/Cà phê sữa đá Highlands Coffee lon 235ml.png", false, 120000, "Cà phê sữa đá Highlands Coffee lon 235ml", 30 },
                    { 26, 3, "Nước giải khát Coca Cola chai 1.5lít.", "Nuoc_Giai_Khat/Nước giải khát Coca Cola chai 1.5lít.png", false, 120000, "Nước giải khát Coca Cola chai 1.5lít", 30 },
                    { 27, 3, "Nước khoáng thiên nhiên LaVie 1.5 lít.", "Nuoc_Giai_Khat/Nước khoáng thiên nhiên LaVie 1.5 lít.png", false, 120000, "Nước khoáng thiên nhiên LaVie 1.5 lít", 30 },
                    { 28, 3, "Nước uống sữa trái cây bổ dưỡng hương cam Nutri Boost chai 1L.", "Nuoc_Giai_Khat/Nước uống sữa trái cây bổ dưỡng hương cam Nutri Boost chai 1L.jpg", false, 120000, "Nước uống sữa trái cây bổ dưỡng hương cam Nutri Boost chai 1L", 30 },
                    { 29, 3, "Nước uống tăng lực Việt Redbull lon 250ml.", "Nuoc_Giai_Khat/Nước uống tăng lực Việt Redbull lon 250ml.jpg", false, 120000, "Nước uống tăng lực Việt Redbull lon 250ml", 30 },
                    { 30, 3, "Nước uống tinh khiết Dasani chai 1.5 lít.", "Nuoc_Giai_Khat/Nước uống tinh khiết Dasani chai 1.5 lít.png", false, 120000, "Nước uống tinh khiết Dasani chai 1.5 lít", 30 },
                    { 31, 3, "Thùng 24 lon bia Hà Nội Habeco 330ml.", "Nuoc_Giai_Khat/Thùng 24 lon bia Hà Nội Habeco 330ml.png", false, 120000, "Thùng 24 lon bia Hà Nội Habeco 330ml", 30 },
                    { 32, 3, "Thùng 24 lon bia Heineken 330ml.", "Nuoc_Giai_Khat/Thùng 24 lon bia Heineken 330ml.png", false, 120000, "Thùng 24 lon bia Heineken 330ml", 30 },
                    { 33, 3, "Thùng 24 lon Bia Saigon lager 330ml.", "Nuoc_Giai_Khat/Thùng 24 lon Bia Saigon lager 330ml.png", false, 120000, "Thùng 24 lon Bia Saigon lager 330ml", 30 },
                    { 34, 3, "Thùng 36 hộp sữa đậu nành Fami canxi ít đường 200ml.", "Nuoc_Giai_Khat/Thùng 36 hộp sữa đậu nành Fami canxi ít đường 200ml.jpg", false, 120000, "Thùng 36 hộp sữa đậu nành Fami canxi ít đường 200ml", 30 },
                    { 35, 3, "Trà bí đao Wonderfarm lon 310ml.", "Nuoc_Giai_Khat/Trà bí đao Wonderfarm lon 310ml.png", false, 120000, "Trà bí đao Wonderfarm lon 310ml", 30 },
                    { 36, 4, "Cháo thịt bằm Vifon gói 70g.", "Thuc_Pham_An_Lien/Cháo thịt bằm Vifon gói 70g.png", false, 120000, "Cháo thịt bằm Vifon gói 70g", 30 },
                    { 37, 4, "Mì gói ăn liền cay Shin Ramyun Nongshim 114g.", "Thuc_Pham_An_Lien/Mì gói ăn liền cay Shin Ramyun Nongshim 114g.png", false, 120000, "Mì gói ăn liền cay Shin Ramyun Nongshim 114g", 30 },
                    { 38, 4, "Phở gà Đệ Nhất gói 65g.", "Thuc_Pham_An_Lien/Phở gà Đệ Nhất gói 65g.png", false, 120000, "Phở gà Đệ Nhất gói 65g", 30 },
                    { 39, 4, "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.", "Thuc_Pham_An_Lien/Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.png", false, 120000, "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly", 30 },
                    { 40, 4, "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.", "Thuc_Pham_An_Lien/Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.png", false, 120000, "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly", 30 },
                    { 41, 4, "Thùng 30 gói mì tôm chua cay Hảo Hảo Vina Acecook 75g - Thùng.", "Thuc_Pham_An_Lien/Thùng 30 gói mì tôm chua cay Hảo Hảo Vina Acecook 75g - Thùng.png", false, 120000, "Thùng 30 gói mì tôm chua cay Hảo Hảo Vina Acecook 75g - Thùng", 30 },
                    { 42, 1, "Bánh snack Poca mực lăn muối ớt.", "Do_An_Vat/Bánh snack Poca mực lăn muối ớt.jpg", false, 120000, "Bánh snack Poca mực lăn muối ớt", 30 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImageUrl", "IsAlcoholic", "Price", "ProductName", "Stock" },
                values: new object[,]
                {
                    { 43, 1, "Bắp Rang Bơ Thơm-Ngon-Giòn ONENUTS.", "Do_An_Vat/Bắp Rang Bơ Thơm-Ngon-Giòn ONENUTS.jpg", false, 120000, "Bắp Rang Bơ Thơm-Ngon-Giòn ONENUTS", 30 },
                    { 44, 1, "Bim Bim Snack Bắp 4x Vị Cay Oishi.", "Do_An_Vat/Bim Bim Snack Bắp 4x Vị Cay Oishi.jpg", false, 120000, "Bim Bim Snack Bắp 4x Vị Cay Oishi", 30 },
                    { 45, 1, "Kẹo Dẻo Hương Trái Cây Chupa Chups 1m.", "Do_An_Vat/Kẹo Dẻo Hương Trái Cây Chupa Chups 1m.jpg", false, 120000, "Kẹo Dẻo Hương Trái Cây Chupa Chups 1m", 30 },
                    { 46, 1, "Snack Cà Chua Tomati.", "Do_An_Vat/Snack Cà Chua Tomati.jpg", false, 120000, "Snack Cà Chua Tomati", 30 },
                    { 47, 1, "Snack hành Oishi Onion Rings.", "Do_An_Vat/Snack hành Oishi Onion Rings.jpg", false, 120000, "Snack hành Oishi Onion Rings", 30 },
                    { 48, 1, "SNACK KHOAI TÂY LAY’S VỊ TẢO BIỂN 95G.", "Do_An_Vat/SNACK KHOAI TÂY LAY’S VỊ TẢO BIỂN 95G.jpg", false, 120000, "SNACK KHOAI TÂY LAY’S VỊ TẢO BIỂN 95G", 30 },
                    { 49, 1, "Snack khoai tây phô mai Karamucho Koikeya.", "Do_An_Vat/Snack khoai tây phô mai Karamucho Koikeya.jpg", false, 120000, "Snack khoai tây phô mai Karamucho Koikeya", 30 },
                    { 50, 1, "Snack Lay's Wavy vị thăn bò nướng texas 95g.", "Do_An_Vat/Snack Lay's Wavy vị thăn bò nướng texas 95g.jpg", false, 120000, "Snack Lay's Wavy vị thăn bò nướng texas 95g", 30 },
                    { 51, 1, "Snack Phô Mai Miếng Oishi.", "Do_An_Vat/Snack Phô Mai Miếng Oishi.jpg", false, 120000, "Snack Phô Mai Miếng Oishi", 30 },
                    { 52, 1, "Snack vị tôm cay Oishi.", "Do_An_Vat/Snack vị tôm cay Oishi.jpg", false, 120000, "Snack vị tôm cay Oishi", 30 },
                    { 53, 6, "Bộ thau rổ cao cấp Yoko.", "Dung_Cu_Nha_Bep/Bộ thau rổ cao cấp Yoko.jpg", false, 120000, "Bộ thau rổ cao cấp Yoko", 30 },
                    { 54, 6, "Đĩa sứ cao cấp.", "Dung_Cu_Nha_Bep/Đĩa sứ cao cấp.jpg", false, 120000, "Đĩa sứ cao cấp", 30 },
                    { 55, 6, "Đũa tre dùng một lần Quang Hà.", "Dung_Cu_Nha_Bep/Đũa tre dùng một lần Quang Hà.jpg", false, 120000, "Đũa tre dùng một lần Quang Hà", 30 },
                    { 56, 6, "Kéo nhà bếp KJ01 21cm.", "Dung_Cu_Nha_Bep/Kéo nhà bếp KJ01 21cm.jpg", false, 120000, "Kéo nhà bếp KJ01 21cm", 30 },
                    { 57, 6, "Lô túi rác tiện dụng Soji.", "Dung_Cu_Nha_Bep/Lô túi rác tiện dụng Soji.jpg", false, 120000, "Lô túi rác tiện dụng Soji", 30 },
                    { 58, 6, "Ly Thủy Tinh Luminarc.", "Dung_Cu_Nha_Bep/Ly Thủy Tinh Luminarc.jpg", false, 120000, "Ly Thủy Tinh Luminarc", 30 },
                    { 59, 6, "Muôi múc canh Duxton.", "Dung_Cu_Nha_Bep/Muôi múc canh Duxton.jpg", false, 120000, "Muôi múc canh Duxton", 30 },
                    { 60, 6, "Muỗng gỗ xào nấu.", "Dung_Cu_Nha_Bep/Muỗng gỗ xào nấu.jpg", false, 120000, "Muỗng gỗ xào nấu", 30 },
                    { 61, 6, "Thìa inox Bếp Xinh.", "Dung_Cu_Nha_Bep/Thìa inox Bếp Xinh.jpg", false, 120000, "Thìa inox Bếp Xinh", 30 },
                    { 62, 6, "Thớt tre tự nhiên Sunhouse.", "Dung_Cu_Nha_Bep/Thớt tre tự nhiên Sunhouse.jpg", false, 120000, "Thớt tre tự nhiên Sunhouse", 30 },
                    { 63, 2, "Bột canh i-ốt Hải Châu.", "Gia_Vi/Bột canh i-ốt Hải Châu.jpg", false, 120000, "Bột canh i-ốt Hải Châu", 30 },
                    { 64, 2, "Tương ớt chua ngọt Cholimex chai 270g.", "Gia_Vi/Tương ớt chua ngọt Cholimex chai 270g.png", false, 120000, "Tương ớt chua ngọt Cholimex chai 270g", 30 },
                    { 65, 2, "Bột Ngọt Meizan.", "Gia_Vi/Bột Ngọt Meizan.jpg", false, 120000, "Bột Ngọt Meizan", 30 },
                    { 66, 2, "Cholimex Food - Tương ớt xí muội chai PET.", "Gia_Vi/Cholimex Food - Tương ớt xí muội chai PET.jpg", false, 120000, "Cholimex Food - Tương ớt xí muội chai PET", 30 },
                    { 67, 2, "Dầu đậu nành Simply chai 1 lít.", "Gia_Vi/Dầu đậu nành Simply chai 1 lít.jpg", false, 120000, "Dầu đậu nành Simply chai 1 lít", 30 },
                    { 68, 2, "Dầu hào chay Maggi nấm hương chai.", "Gia_Vi/Dầu hào chay Maggi nấm hương chai.jpg", false, 120000, "Dầu hào chay Maggi nấm hương chai", 30 },
                    { 69, 2, "Nước mắm Nam Ngư Cá Cơm Tươi.", "Gia_Vi/Nước mắm Nam Ngư Cá Cơm Tươi.jpg", false, 120000, "Nước mắm Nam Ngư Cá Cơm Tươi", 30 },
                    { 70, 2, "Sốt Mayonnaise Aji-Mayo Vị Chua Béo Chai 260g.", "Gia_Vi/Sốt Mayonnaise Aji-Mayo Vị Chua Béo Chai 260g.jpg", false, 120000, "Sốt Mayonnaise Aji-Mayo Vị Chua Béo Chai 260g", 30 },
                    { 71, 3, "7up lon 320ml vị chanh.", "Nuoc_Giai_Khat/7up lon 320ml vị chanh.jpg", false, 120000, "7up lon 320ml vị chanh", 30 },
                    { 72, 2, "Chai nước tăng lực sting đỏ của pepsiCo 320ml.", "Nuoc_Giai_Khat/Chai nước tăng lực sting đỏ của pepsiCo 320ml.jpg", false, 120000, "Chai nước tăng lực sting đỏ của pepsiCo 320ml", 30 },
                    { 73, 3, "Nước cam ép TH True Juice chai 350ml.", "Nuoc_Giai_Khat/Nước cam ép TH True Juice chai 350ml.jpg", false, 120000, "Nước cam ép TH True Juice chai 350ml", 30 },
                    { 74, 3, "Nước ngọt Coca Cola lon 320ml.", "Nuoc_Giai_Khat/Nước ngọt Coca Cola lon 320ml.jpg", false, 120000, "Nước ngọt Coca Cola lon 320ml", 30 },
                    { 75, 3, "Nước Sữa Trái Cây TH True Juice Milk Vị Cam Tự Nhiên Chai 300ml.", "Nuoc_Giai_Khat/Nước Sữa Trái Cây TH True Juice Milk Vị Cam Tự Nhiên Chai 300ml.jpg", false, 120000, "Nước Sữa Trái Cây TH True Juice Milk Vị Cam Tự Nhiên Chai 300ml", 30 },
                    { 76, 3, "Nước tăng lực number1.", "Nuoc_Giai_Khat/Nước tăng lực number1.jpg", false, 120000, "Nước tăng lực number1", 30 },
                    { 77, 3, "Trà Đào TVT Chai 450Ml.", "Nuoc_Giai_Khat/Trà Đào TVT Chai 450Ml.jpg", false, 120000, "Trà Đào TVT Chai 450Ml", 30 },
                    { 78, 3, "Trà xanh hương chanh tuyết bạc hà C2 freeze.", "Nuoc_Giai_Khat/Trà xanh hương chanh tuyết bạc hà C2 freeze.jpg", false, 120000, "Trà xanh hương chanh tuyết bạc hà C2 freeze", 30 },
                    { 79, 3, "TRÀ XANH KHÔNG ĐỘ chai 455ML.", "Nuoc_Giai_Khat/TRÀ XANH KHÔNG ĐỘ chai 455ML.jpg", false, 120000, "TRÀ XANH KHÔNG ĐỘ chai 455ML", 30 },
                    { 80, 4, "Mì 3 Miền Gold Tôm Chua Cay Đặc Biệt 75g.", "Thuc_Pham_An_Lien/Mì 3 Miền Gold Tôm Chua Cay Đặc Biệt 75g.jpg", false, 120000, "Mì 3 Miền Gold Tôm Chua Cay Đặc Biệt 75g", 30 },
                    { 81, 4, "Mì Bò Hầm Ottogi 120G.", "Thuc_Pham_An_Lien/Mì Bò Hầm Ottogi 120G.jpg", false, 120000, "Mì Bò Hầm Ottogi 120G", 30 },
                    { 82, 4, "MÌ CUNG ĐÌNH VỊ LẨU TÔM CHUA CAY 80g.", "Thuc_Pham_An_Lien/MÌ CUNG ĐÌNH VỊ LẨU TÔM CHUA CAY 80g.jpg", false, 120000, "MÌ CUNG ĐÌNH VỊ LẨU TÔM CHUA CAY 80g", 30 },
                    { 83, 4, "Mì Hảo Hảo big 100g tôm chua cay 100g.", "Thuc_Pham_An_Lien/Mì Hảo Hảo big 100g tôm chua cay 100g.jpg", false, 120000, "Mì Hảo Hảo big 100g tôm chua cay 100g", 30 },
                    { 84, 4, "Mì khoai tây Omachi sườn hầm ngũ quả gói 80g.", "Thuc_Pham_An_Lien/Mì khoai tây Omachi sườn hầm ngũ quả gói 80g.jpg", false, 120000, "Mì khoai tây Omachi sườn hầm ngũ quả gói 80g", 30 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImageUrl", "IsAlcoholic", "Price", "ProductName", "Stock" },
                values: new object[,]
                {
                    { 85, 4, "Mì khoai tây Omachi xốt bò hầm gói 80g.", "Thuc_Pham_An_Lien/Mì khoai tây Omachi xốt bò hầm gói 80g.jpg", false, 120000, "Mì khoai tây Omachi xốt bò hầm gói 80g", 30 },
                    { 86, 4, "Mì Koreno vị kim chi gói 100g.", "Thuc_Pham_An_Lien/Mì Koreno vị kim chi gói 100g.jpg", false, 120000, "Mì Koreno vị kim chi gói 100g", 30 },
                    { 87, 4, "Mì trộn Omachi xốt Spaghetti gói 90g.", "Thuc_Pham_An_Lien/Mì trộn Omachi xốt Spaghetti gói 90g.jpg", false, 120000, "Mì trộn Omachi xốt Spaghetti gói 90g", 30 },
                    { 88, 4, "MÌ TƯƠNG ĐEN BẮC KINH GÓI 83G.", "Thuc_Pham_An_Lien/MÌ TƯƠNG ĐEN BẮC KINH GÓI 83G.jpg", false, 120000, "MÌ TƯƠNG ĐEN BẮC KINH GÓI 83G", 30 },
                    { 89, 4, "Phở trộn Đệ Nhất vị thập cẩm cay gói 82g.", "Thuc_Pham_An_Lien/Phở trộn Đệ Nhất vị thập cẩm cay gói 82g.jpg", false, 120000, "Phở trộn Đệ Nhất vị thập cẩm cay gói 82g", 30 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "ShippingAddress",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 22, 22, 31, 16, 626, DateTimeKind.Local).AddTicks(1180), "$2a$11$LyatlCJrCHM/0pGzx.FxOeUu3/6q1KDCAVyc36OX8oPZbXXkFBfKG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 22, 22, 31, 16, 779, DateTimeKind.Local).AddTicks(359), "$2a$11$YDFKDJnE3Dqxtwi0/8CJbOxxxnStzisU/NOCEDDeu4kBQz/vfqySO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 22, 22, 31, 16, 930, DateTimeKind.Local).AddTicks(7067), "$2a$11$xBycT7OUUuRj1hl989eWoOHh0i6eGgYh0a0abmPot5Z740nUhTbmq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 22, 22, 31, 17, 102, DateTimeKind.Local).AddTicks(867), "$2a$11$SryPYI66g.6/tANYt1qsLeQUiW.je7puASwTZw6DXaA6ywVk95EDO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 22, 22, 31, 17, 298, DateTimeKind.Local).AddTicks(9357), "$2a$11$sZGjvmzDhgKHilIbNtt85uOMc1niqmJGYwk20wXlRpWxQAyn5aJ32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 22, 22, 31, 17, 486, DateTimeKind.Local).AddTicks(5809), "$2a$11$rNBB1PynWTH2br/AmaHcr.Jf9Nm8LCCs4nJfR8G4D58QeX7QfpVBq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash", "Role" },
                values: new object[] { new DateTime(2025, 1, 22, 22, 31, 17, 650, DateTimeKind.Local).AddTicks(8210), "$2a$11$dFFTMKTb7vyh5dirACJVf.9mSVxsDITBO2Ml31MmY1UE3K2xt85xO", "User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash", "Role" },
                values: new object[] { new DateTime(2025, 1, 22, 22, 31, 17, 816, DateTimeKind.Local).AddTicks(9528), "$2a$11$mrB64xKJXD7B8fD.ejAmEuvoSQKnWO566Dz3YxMkE3UyYbNqiKcFW", "User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash", "Role" },
                values: new object[] { new DateTime(2025, 1, 22, 22, 31, 17, 982, DateTimeKind.Local).AddTicks(1829), "$2a$11$EPV8uVU3mwpKNj2gwYN7Qu95abDSrighPdkoebotqgNaigydn.zrK", "User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash", "Role" },
                values: new object[] { new DateTime(2025, 1, 22, 22, 31, 18, 150, DateTimeKind.Local).AddTicks(3765), "$2a$11$mBJHjjxt1Oc5kXkxK7m5cuZ3TZbJ1OkHQn.n93v49NkJT.6qaVs42", "User" });
        }
    }
}
