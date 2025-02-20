using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FreeShipCount = table.Column<int>(type: "int", nullable: false),
                    PremiumStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PremiumEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    VoucherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.VoucherID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAlcoholic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentGateway = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemID);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartID",
                        column: x => x.CartID,
                        principalTable: "Carts",
                        principalColumn: "CartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Users",
                columns: new[] { "UserID", "CreatedAt", "Email", "FreeShipCount", "FullName", "PasswordHash", "PhoneNumber", "PremiumEndDate", "PremiumStartDate", "Role", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 21, 1, 2, 23, 921, DateTimeKind.Local).AddTicks(2674), "HaiLTHE172555@fpt.edu.vn", 0, "Lại Tuấn Hai", "$2a$11$x2KD3lDbLNH1xNtmp8kmL.F8aF66RaP0ouroJSEtc/2KhM4Pf.75m", "0123456789", null, null, "Admin", "HaiAdmin" },
                    { 2, new DateTime(2025, 2, 21, 1, 2, 24, 85, DateTimeKind.Local).AddTicks(7476), "HungPVHE161180@fpt.edu.vn", 0, "Phạm Việt Hưng", "$2a$11$P6ihT.453HZUks4oupS0bem86L3dke/voRwLMUMFk137ZCYDe4vN6", "0123456789", null, null, "Admin", "HungAdmin" },
                    { 3, new DateTime(2025, 2, 21, 1, 2, 24, 247, DateTimeKind.Local).AddTicks(8351), "CongHTHE172673@fpt.edu.vn", 0, "Hoàng Thành Công", "$2a$11$T2o0VDBs3GPQFuchpGDyou0hz1mR3fnKVC5scLw.tJXdy87xuAj9q", "0123456789", null, null, "Admin", "CongAdmin" },
                    { 4, new DateTime(2025, 2, 21, 1, 2, 24, 399, DateTimeKind.Local).AddTicks(6869), "NhatLVHE176909@fpt.edu.vn", 0, "Lê Việt Nhật", "$2a$11$uRNS8Q1zCP82F6uJG6LEyOuM7hwHS1s4R8Q8/ER4U5fg2x2kibWUu", "0123456789", null, null, "Admin", "NhatAdmin" },
                    { 5, new DateTime(2025, 2, 21, 1, 2, 24, 571, DateTimeKind.Local).AddTicks(3189), "TrongLCPHS176090@fpt.edu.vn", 0, "Lê Công Phú Trọng", "$2a$11$uBeAKA4AjkEZfd/6HqGok.t002CnKg0bgrWhFor3FPL3k/WKQUXSi", "0123456789", null, null, "Admin", "TrongAdmin" },
                    { 6, new DateTime(2025, 2, 21, 1, 2, 24, 719, DateTimeKind.Local).AddTicks(2347), "DatVTHS176109@fpt.edu.vn", 0, "Vũ Tiến Đạt", "$2a$11$gRxR3ulDcOUbKzKwO5u4T.Cz7aMQ3xH5wxsCZ62CuWeqKWouAknz6", "0123456789", null, null, "Admin", "DatAdmin" },
                    { 7, new DateTime(2025, 2, 21, 1, 2, 24, 876, DateTimeKind.Local).AddTicks(5517), "TungNVHE170677@fpt.edu.vn", 0, "Nguyễn Việt Tùng", "$2a$11$d3KfeR89Qj/3Mfy0UoWN1uwGw5g6W5svzV0UOlWkukj4cREdHKm.2", "0987654321", null, null, "Customer", "TungUser" },
                    { 8, new DateTime(2025, 2, 21, 1, 2, 25, 43, DateTimeKind.Local).AddTicks(5538), "ToanPMHE171369@fpt.edu.vn", 0, "Phan Mạnh Toàn", "$2a$11$t8t4w6655fiYEjdndug1ZukqBEmYdAA1z7oRnULzdTdv4iQCndWK2", "0987654321", null, null, "Customer", "ToanUser" },
                    { 9, new DateTime(2025, 2, 21, 1, 2, 25, 190, DateTimeKind.Local).AddTicks(5719), "CuongPXHE172287@fpt.edu.vn", 0, "Phạm Xuân Cường", "$2a$11$KPrKhqo7eTCPpqLxfd7y7.itZDRN9N/2J6ZU5Izd9/ftWDUIqR6y.", "0987654321", null, null, "Customer", "CuongUser" },
                    { 10, new DateTime(2025, 2, 21, 1, 2, 25, 363, DateTimeKind.Local).AddTicks(8220), "AnhVNHE151076@fpt.edu.vn", 0, "Vũ Nam Anh", "$2a$11$Y2wdyRRQ1xU/846hJkY/peyD7XmFjiCR81e5RsCkdhyzHtG.cte2u", "0123456789", null, null, "Customer", "AnhUser" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "CreatedAt", "FullName", "PaymentGateway", "PaymentStatus", "PhoneNumber", "ShippingAddress", "Status", "TotalAmount", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 16, 1, 2, 25, 364, DateTimeKind.Local).AddTicks(797), "Nguyễn Việt Tùng", "Credit Card", "Paid", "0123456789", "123 Main Street, Hanoi", "Delivered", 60000, 7 },
                    { 2, new DateTime(2025, 2, 18, 1, 2, 25, 364, DateTimeKind.Local).AddTicks(807), "Nguyễn Văn Toàn", "COD", "Pending", "0123456789", "456 Secondary Street, HCM", "Delivered", 65000, 8 },
                    { 3, new DateTime(2025, 2, 20, 1, 2, 25, 364, DateTimeKind.Local).AddTicks(809), "Phạm Xuân Cường", "Bank Transfer", "Paid", "0123456789", "789 Tertiary Avenue, Da Nang", "Delivered", 250000, 9 }
                });

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
                    { 39, 4, "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.", "Thuc_Pham_An_Lien/Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.png", false, 120000, "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly", 30 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImageUrl", "IsAlcoholic", "Price", "ProductName", "Stock" },
                values: new object[,]
                {
                    { 40, 4, "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.", "Thuc_Pham_An_Lien/Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly.png", false, 120000, "Thùng 24 ly mì Hảo Hảo vị tôm chua cay Acecook 67g - Ly", 30 },
                    { 41, 4, "Thùng 30 gói mì tôm chua cay Hảo Hảo Vina Acecook 75g - Thùng.", "Thuc_Pham_An_Lien/Thùng 30 gói mì tôm chua cay Hảo Hảo Vina Acecook 75g - Thùng.png", false, 120000, "Thùng 30 gói mì tôm chua cay Hảo Hảo Vina Acecook 75g - Thùng", 30 },
                    { 42, 1, "Bánh snack Poca mực lăn muối ớt.", "Do_An_Vat/Bánh snack Poca mực lăn muối ớt.jpg", false, 120000, "Bánh snack Poca mực lăn muối ớt", 30 },
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
                    { 81, 4, "Mì Bò Hầm Ottogi 120G.", "Thuc_Pham_An_Lien/Mì Bò Hầm Ottogi 120G.jpg", false, 120000, "Mì Bò Hầm Ottogi 120G", 30 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImageUrl", "IsAlcoholic", "Price", "ProductName", "Stock" },
                values: new object[,]
                {
                    { 82, 4, "MÌ CUNG ĐÌNH VỊ LẨU TÔM CHUA CAY 80g.", "Thuc_Pham_An_Lien/MÌ CUNG ĐÌNH VỊ LẨU TÔM CHUA CAY 80g.jpg", false, 120000, "MÌ CUNG ĐÌNH VỊ LẨU TÔM CHUA CAY 80g", 30 },
                    { 83, 4, "Mì Hảo Hảo big 100g tôm chua cay 100g.", "Thuc_Pham_An_Lien/Mì Hảo Hảo big 100g tôm chua cay 100g.jpg", false, 120000, "Mì Hảo Hảo big 100g tôm chua cay 100g", 30 },
                    { 84, 4, "Mì khoai tây Omachi sườn hầm ngũ quả gói 80g.", "Thuc_Pham_An_Lien/Mì khoai tây Omachi sườn hầm ngũ quả gói 80g.jpg", false, 120000, "Mì khoai tây Omachi sườn hầm ngũ quả gói 80g", 30 },
                    { 85, 4, "Mì khoai tây Omachi xốt bò hầm gói 80g.", "Thuc_Pham_An_Lien/Mì khoai tây Omachi xốt bò hầm gói 80g.jpg", false, 120000, "Mì khoai tây Omachi xốt bò hầm gói 80g", 30 },
                    { 86, 4, "Mì Koreno vị kim chi gói 100g.", "Thuc_Pham_An_Lien/Mì Koreno vị kim chi gói 100g.jpg", false, 120000, "Mì Koreno vị kim chi gói 100g", 30 },
                    { 87, 4, "Mì trộn Omachi xốt Spaghetti gói 90g.", "Thuc_Pham_An_Lien/Mì trộn Omachi xốt Spaghetti gói 90g.jpg", false, 120000, "Mì trộn Omachi xốt Spaghetti gói 90g", 30 },
                    { 88, 4, "MÌ TƯƠNG ĐEN BẮC KINH GÓI 83G.", "Thuc_Pham_An_Lien/MÌ TƯƠNG ĐEN BẮC KINH GÓI 83G.jpg", false, 120000, "MÌ TƯƠNG ĐEN BẮC KINH GÓI 83G", 30 },
                    { 89, 4, "Phở trộn Đệ Nhất vị thập cẩm cay gói 82g.", "Thuc_Pham_An_Lien/Phở trộn Đệ Nhất vị thập cẩm cay gói 82g.jpg", false, 120000, "Phở trộn Đệ Nhất vị thập cẩm cay gói 82g", 30 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailID", "Note", "OrderID", "Price", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 1, null, 1, 20000, 1, 2 },
                    { 2, null, 1, 10000, 2, 1 },
                    { 3, null, 2, 15000, 3, 3 },
                    { 4, null, 2, 12000, 4, 1 },
                    { 5, null, 3, 120000, 5, 1 },
                    { 6, null, 3, 120000, 6, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartID",
                table: "CartItems",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductID",
                table: "CartItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserID",
                table: "Carts",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
