using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class UpdateODvsCI : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 0, 5, 22, 3, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 18, 0, 5, 22, 3, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 0, 5, 22, 3, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 5, 20, 291, DateTimeKind.Local).AddTicks(2426), "$2a$11$9pjuVBdurkERC6RPnQ4YyOJd6cHG.nVDotwCKb2nZxDCc1DuDAIye", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 5, 20, 496, DateTimeKind.Local).AddTicks(7694), "$2a$11$jt72renVbPFdbRg1rymE1el32rIkxfTZYcUTrLwIDABdznUk87f2.", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 5, 20, 672, DateTimeKind.Local).AddTicks(373), "$2a$11$EhTyW5v3pPhHi.L7FUhyMOpUgXklZjXorIPUsimQCe8YUWHaUD7jW", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 5, 20, 843, DateTimeKind.Local).AddTicks(6957), "$2a$11$VHxSfE3PR/IXB5Jxvmd4bOd/V59PcweT.53doJutGjQ1h6gBdFVNi", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 5, 21, 44, DateTimeKind.Local).AddTicks(9239), "$2a$11$qgnlr67AsOIDXqkSW/sNSeA.L6M1KcETRzRTIIxD76C1wWDX8Fih.", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 5, 21, 211, DateTimeKind.Local).AddTicks(3264), "$2a$11$8MlnYeC.cbvs4r/NkUtykuq6Mep6Y6zN5FNTt3HGL6ZPQXT.W0Cvi", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 5, 21, 409, DateTimeKind.Local).AddTicks(3172), "$2a$11$vQOkm0uGSugJAm0aISSNie057.acI7wIOoH/mbIPKmtFQPhAkzOYK", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 5, 21, 612, DateTimeKind.Local).AddTicks(921), "$2a$11$nBQFLqiKv7KnkOOnIgKPu.ni2TMzunk/USD0kn3cMNfiAV4o2ufGu", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 5, 21, 823, DateTimeKind.Local).AddTicks(7047), "$2a$11$PGjojWiptAajTc.kiLSUy.e7KXf46.oHUZ0NcQDKPGjtoWysQUaue", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash", "PremiumEndDate", "PremiumStartDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 5, 22, 3, DateTimeKind.Local).AddTicks(769), "$2a$11$oYQqw0ApelypcZXL6/zWRO14G5vJzH2mSYKLGi1B5gAffXGmokCZa", null, null });

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

            migrationBuilder.DropColumn(
                name: "Note",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "CartItems");

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
