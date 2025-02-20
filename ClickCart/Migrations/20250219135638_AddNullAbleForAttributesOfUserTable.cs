using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class AddNullAbleForAttributesOfUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PremiumStartDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PremiumEndDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 20, 56, 38, 194, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 20, 56, 38, 194, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 18, 20, 56, 38, 194, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 36, 965, DateTimeKind.Local).AddTicks(5916), "$2a$11$W7qE05pb5LqKM66z1N2XCeG4dBgY2YZ7k/PQKklAaLr72Ll6Kk26m", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 114, DateTimeKind.Local).AddTicks(3758), "$2a$11$ajh0smFMT/cukbIfjAnmcuWCVemcYMXL7rcSxofsKYbSmMBIGGpme", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 258, DateTimeKind.Local).AddTicks(3936), "$2a$11$6w0jBi/L3R2C05QObzPTqeCRh0mQqFX3MSnAVH2UktZnOT5PQzmaa", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 392, DateTimeKind.Local).AddTicks(4552), "$2a$11$h7QXnpzXDZAVTwS6WgcN/uWYRMDefTD2uUvTXja8Aez2UaFunPa5G", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 529, DateTimeKind.Local).AddTicks(927), "$2a$11$4CcLibnJT0iLNIvM8sZhguFwsRyHiSDsJeJ6c/Bg1cF6mUI9myQbG", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 665, DateTimeKind.Local).AddTicks(257), "$2a$11$usds.Y3FtfptmovqiNhfM.ogmJPfCmAnntX.F9KM0H25mq3KLRMAS", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 798, DateTimeKind.Local).AddTicks(9812), "$2a$11$qyGlCtt..fzE.Cd5dkkha.xlOu10US.cFUKT7zPmRdFQbwCq.FfLK", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 929, DateTimeKind.Local).AddTicks(9703), "$2a$11$3b0p.VDIs9OHYENTP9388.NN2buKOZ7hOgumSalrwZTQMSOVApoxm", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 38, 61, DateTimeKind.Local).AddTicks(7588), "$2a$11$60tBwXrUZdS99NaKS5P4xu8oS9reXk.BV3IIs4sIa13qfYbcc/Zde", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 38, 194, DateTimeKind.Local).AddTicks(2720), "$2a$11$a3EH5hnLsQHm12aABIeN6Ofy1OISjVQ3rZJTZTX4aTyD9qS8u3yHy", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductID",
                table: "OrderDetails",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PremiumStartDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PremiumEndDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 2, 371, DateTimeKind.Local).AddTicks(9326), "$2a$11$fsntts5MRsrCj1NkMVNG5uiiCPfDpDgAlpyQL7I.VymGtqwyAhsAG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 2, 512, DateTimeKind.Local).AddTicks(8913), "$2a$11$lL5ZkQb5vo7OnJMFg283mOHqHMJ.n8HEIoxYZkWJlACXlEAS1Gj2a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 2, 658, DateTimeKind.Local).AddTicks(2112), "$2a$11$XXaFRgu88uLTYtlcraK1GumJ5AOCL9GVcacoav1lHcIq5fxAxFHO2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 2, 801, DateTimeKind.Local).AddTicks(7719), "$2a$11$Wx4OPMwdxI/laotly0.JfuYB5cyGNxQJTcahmlVKUEYoO2OvVRc0O", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 2, 941, DateTimeKind.Local).AddTicks(4536), "$2a$11$zUYzEUiK.0foTaXlZpWj3esP2cLbGlbRFdzEfeOvmcv5KobSMfv4a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 3, 79, DateTimeKind.Local).AddTicks(3195), "$2a$11$HHAyBoCE36oBmmaF9PCN4OzyuaOVeB5b0FJed0jdVusQnB2Kn9AVq", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 3, 216, DateTimeKind.Local).AddTicks(4796), "$2a$11$ZU0sjCxPDhkCWWROheW8/.QbLkwwnOulWXfY5ZkaikNhZKWAW6E4W", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 3, 353, DateTimeKind.Local).AddTicks(5578), "$2a$11$ls61QnpAO0TqrZuscw5ql.LbbdV8oGEfLW6H.aQht2RLdLzHW5x/S", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 3, 493, DateTimeKind.Local).AddTicks(3144), "$2a$11$tGki5.0.PgrbQ0YLqHx8PuwUZu14nMyzP3GczfkHwOS2miGzMn2x6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 36, 3, 630, DateTimeKind.Local).AddTicks(3929), "$2a$11$lCpLXgfb33LxUZUpbn3Kv.DARZWy2AbbfsguHTS2eO6HgZ6sfHeB.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
