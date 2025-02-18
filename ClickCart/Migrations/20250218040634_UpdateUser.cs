using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class UpdateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FreeShipEndDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FreeShipStartDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsFreeShip",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "FreeShipCount",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FullName", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 2, 13, 11, 6, 34, 122, DateTimeKind.Local).AddTicks(8846), "Nguyễn Việt Tùng", "0123456789" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FullName", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 2, 15, 11, 6, 34, 122, DateTimeKind.Local).AddTicks(8855), "Nguyễn Văn Toàn", "0123456789" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FullName", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 2, 17, 11, 6, 34, 122, DateTimeKind.Local).AddTicks(8857), "Phạm Xuân Cường", "0123456789" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FreeShipCount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Orders");

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
    }
}
