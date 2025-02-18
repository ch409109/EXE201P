using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class ModifyUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Combos");

            migrationBuilder.AddColumn<DateTime>(
                name: "PremiumEndDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PremiumStartDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 13, 22, 36, 3, 630, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 15, 22, 36, 3, 630, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 17, 22, 36, 3, 630, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 2, 371, DateTimeKind.Local).AddTicks(9326), "$2a$11$fsntts5MRsrCj1NkMVNG5uiiCPfDpDgAlpyQL7I.VymGtqwyAhsAG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 2, 512, DateTimeKind.Local).AddTicks(8913), "$2a$11$lL5ZkQb5vo7OnJMFg283mOHqHMJ.n8HEIoxYZkWJlACXlEAS1Gj2a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 2, 658, DateTimeKind.Local).AddTicks(2112), "$2a$11$XXaFRgu88uLTYtlcraK1GumJ5AOCL9GVcacoav1lHcIq5fxAxFHO2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 2, 801, DateTimeKind.Local).AddTicks(7719), "$2a$11$Wx4OPMwdxI/laotly0.JfuYB5cyGNxQJTcahmlVKUEYoO2OvVRc0O" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 2, 941, DateTimeKind.Local).AddTicks(4536), "$2a$11$zUYzEUiK.0foTaXlZpWj3esP2cLbGlbRFdzEfeOvmcv5KobSMfv4a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 3, 79, DateTimeKind.Local).AddTicks(3195), "$2a$11$HHAyBoCE36oBmmaF9PCN4OzyuaOVeB5b0FJed0jdVusQnB2Kn9AVq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 3, 216, DateTimeKind.Local).AddTicks(4796), "$2a$11$ZU0sjCxPDhkCWWROheW8/.QbLkwwnOulWXfY5ZkaikNhZKWAW6E4W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 3, 353, DateTimeKind.Local).AddTicks(5578), "$2a$11$ls61QnpAO0TqrZuscw5ql.LbbdV8oGEfLW6H.aQht2RLdLzHW5x/S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 3, 493, DateTimeKind.Local).AddTicks(3144), "$2a$11$tGki5.0.PgrbQ0YLqHx8PuwUZu14nMyzP3GczfkHwOS2miGzMn2x6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 3, 630, DateTimeKind.Local).AddTicks(3929), "$2a$11$lCpLXgfb33LxUZUpbn3Kv.DARZWy2AbbfsguHTS2eO6HgZ6sfHeB." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PremiumEndDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PremiumStartDate",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Combos",
                columns: table => new
                {
                    ComboID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComboName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combos", x => x.ComboID);
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
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 13, 11, 6, 34, 122, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 15, 11, 6, 34, 122, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 17, 11, 6, 34, 122, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 6, 32, 900, DateTimeKind.Local).AddTicks(8863), "$2a$11$Ta4VCR7JSBP0F4hWaCOdb.owv/XsttWjhL/wQ280nZq7K7pF8ocPK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 6, 33, 44, DateTimeKind.Local).AddTicks(2984), "$2a$11$VQBbNo9OUpC4H5Z.pkoVie6HNpjNbqrtLPhGbfgi7timT60y22BX2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 6, 33, 188, DateTimeKind.Local).AddTicks(317), "$2a$11$r1tOUCLYTqVC5ulIrvgvteGyirMtY29M8vTbni.jw9vQuxPndCTGK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 6, 33, 331, DateTimeKind.Local).AddTicks(2027), "$2a$11$q5w6c81xEvXPbPFiYwo/0.D9u.pLLP3y8xXcWGPXwAyJdDc0O6WEu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 6, 33, 474, DateTimeKind.Local).AddTicks(8024), "$2a$11$1u8tHxiZDdfKWhoL3ck6Cew47hSjmikyrMncsidwbZtT6k.jNOoSW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 6, 33, 618, DateTimeKind.Local).AddTicks(2250), "$2a$11$5qhMuQ8MKlDClfVQJgPfXufmDa2nz3951/s/lbLV.YH5mAElQ1p6W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 6, 33, 750, DateTimeKind.Local).AddTicks(1971), "$2a$11$eJyOe6w6KwTgo3TLi8RKM.xTzgDV64hEGkdiSNG/VUVuGlv8Vvl3m" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 6, 33, 873, DateTimeKind.Local).AddTicks(8215), "$2a$11$IMjet6iByzzIdOdaMs1/au5uXxZwJ7QlPaTfnxyqenQHXGG9BS2Ne" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 6, 33, 998, DateTimeKind.Local).AddTicks(1933), "$2a$11$6B/VtGYtLMZ72VW8YdYhauZ4ossyyAaOmZIfymtR30sjjxrRIshDu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 6, 34, 122, DateTimeKind.Local).AddTicks(7882), "$2a$11$2Gmr32UEp1FX2SaVVQijDekAr0BH9tfK6oCSucqWog3qTecPKQ5Yu" });
        }
    }
}
