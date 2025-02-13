using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComboProducts");

            migrationBuilder.AddColumn<DateTime>(
                name: "FreeShipEndDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FreeShipStartDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFreeShip",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 8, 23, 34, 15, 514, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 10, 23, 34, 15, 514, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 12, 23, 34, 15, 514, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 34, 14, 202, DateTimeKind.Local).AddTicks(9135), "$2a$11$j8zN5h5padIIQcPu3Dyqc.2g497eHhacNQTdK0owet18FbK2UmjGS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 34, 14, 353, DateTimeKind.Local).AddTicks(9542), "$2a$11$1ev6fA7mcX245GjmrWyNF.bZ6Rw.kvavI7pXW./r41b1LBzwE4jOi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 34, 14, 499, DateTimeKind.Local).AddTicks(2000), "$2a$11$F7x57q5KHYhGsWIT0kjgC.keUQnwcBK0TfZWJ3YxR4op3ukHVgpoy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 34, 14, 642, DateTimeKind.Local).AddTicks(772), "$2a$11$98OYMCSuLCytKASjEM8xr.gz8NcP4NNHlVRRBzAS/QEE37sjva2AW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 34, 14, 778, DateTimeKind.Local).AddTicks(7863), "$2a$11$qu7PHCHaUr.HBZE0oEgmL.O7Z04uCtR.tVkmdbextNmi/4LoQAVFG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 34, 14, 923, DateTimeKind.Local).AddTicks(8545), "$2a$11$KBRdZlmYzrdzH7u8HSjVDOH7cbRc.YDbY.Qv91bl1CupGZDN9Fmwa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 34, 15, 72, DateTimeKind.Local).AddTicks(3260), "$2a$11$28n.TOHOUk1r0.71PSyLAe85EBpsHzYAGA4vx95EQ3HuLkeIH8.Km" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 34, 15, 214, DateTimeKind.Local).AddTicks(4172), "$2a$11$mNsBFCt8zBmelE9RLuQhFu7gU43ajYtWqwCnJNPZwYMPOI4251gM2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 34, 15, 367, DateTimeKind.Local).AddTicks(1290), "$2a$11$OJbayYC5G/X27iOtEk4sMOxTvei4fSHHSudNRLgkyDYeY9H.ygZzO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 34, 15, 514, DateTimeKind.Local).AddTicks(7197), "$2a$11$5Lw9I5JORgY5f2tZI5DdDOLQR3ExNSvb6rxIYWG8novbdIXswoseG" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropColumn(
                name: "FreeShipEndDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FreeShipStartDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsFreeShip",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "ComboProducts",
                columns: table => new
                {
                    ComboID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboProducts", x => new { x.ComboID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_ComboProducts_Combos_ComboID",
                        column: x => x.ComboID,
                        principalTable: "Combos",
                        principalColumn: "ComboID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComboProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 3, 10, 48, 711, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 25, 3, 10, 48, 711, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 3, 10, 48, 711, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 10, 47, 458, DateTimeKind.Local).AddTicks(3980), "$2a$11$8YUr3aP85oFM60usq2mxH.c5Lg8xN9X.s2JxmOGcgv9NL0y6JHVRO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 10, 47, 601, DateTimeKind.Local).AddTicks(8334), "$2a$11$ei3m0TGXDwg2jnd6qtUkoeuNkwVXxOWyrdnbmtMUObpQCk9n.MpF." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 10, 47, 743, DateTimeKind.Local).AddTicks(5506), "$2a$11$Usz20FHiQbBLxaOn3eQrneD9qUjj2ugqYkQ4JREnG/icishWX/5km" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 10, 47, 886, DateTimeKind.Local).AddTicks(2443), "$2a$11$m2HiyMJLL3YRfJD4i0qzoOWzpRsEfqiHukhO9TncSHuQfor0jficO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 10, 48, 25, DateTimeKind.Local).AddTicks(1195), "$2a$11$Ne0BFE/GkLzSgzO.mma0duFlJ.8TuNBe/oppxbRtV.owizGR3aVu6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 10, 48, 169, DateTimeKind.Local).AddTicks(6178), "$2a$11$0vVtqRHRl9rzLTgPBFnIcurtfsarMfGPKobczuG1/CVNTYOfEtzuW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 10, 48, 305, DateTimeKind.Local).AddTicks(1820), "$2a$11$cc2J9R6WSCodFjHr7Zuv9O3FOq3VZPow0lraGQMsRXA.WSIMhKRWG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 10, 48, 433, DateTimeKind.Local).AddTicks(9143), "$2a$11$qZkc5qMcf/BP3ZhkgOr0tuAERXy87GgPd9enr.gSLoY1pSpsk98Me" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 10, 48, 567, DateTimeKind.Local).AddTicks(4283), "$2a$11$kgob2gQQSUGv89JHUbNTIO0/4W9ymb9gcJG1W4b2AvuoLqVPfWqEm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 10, 48, 711, DateTimeKind.Local).AddTicks(3538), "$2a$11$roXLE2CSzwV51tG/v6RIou6wrr3TJxLcgmyZCnqgSBtX/TORw98Ka" });

            migrationBuilder.CreateIndex(
                name: "IX_ComboProducts_ProductID",
                table: "ComboProducts",
                column: "ProductID");
        }
    }
}
