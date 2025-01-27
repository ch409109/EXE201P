using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class SeedDataforOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "CreatedAt", "PaymentGateway", "PaymentStatus", "ShippingAddress", "TotalAmount", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 23, 3, 10, 48, 711, DateTimeKind.Local).AddTicks(4641), "Credit Card", "Paid", "123 Main Street, Hanoi", 60000, 7 },
                    { 2, new DateTime(2025, 1, 25, 3, 10, 48, 711, DateTimeKind.Local).AddTicks(4651), "COD", "Pending", "456 Secondary Street, HCM", 65000, 8 },
                    { 3, new DateTime(2025, 1, 27, 3, 10, 48, 711, DateTimeKind.Local).AddTicks(4652), "Bank Transfer", "Paid", "789 Tertiary Avenue, Da Nang", 250000, 9 }
                });

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

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailID", "OrderID", "Price", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 20000, 1, 2 },
                    { 2, 1, 10000, 2, 1 },
                    { 3, 2, 15000, 3, 3 },
                    { 4, 2, 12000, 4, 1 },
                    { 5, 3, 120000, 5, 1 },
                    { 6, 3, 120000, 6, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3);

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
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 54, 216, DateTimeKind.Local).AddTicks(6913), "$2a$11$wJBvNcHjxKNfUzG97feiuuEYYTCZ8HNC0KSWaBlwcWGLmcgtskvwW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 54, 350, DateTimeKind.Local).AddTicks(3230), "$2a$11$6h5V/80R4opZ8LTfB6DH8uQjRLrvCS12suuvcPcVz8IcZMDvRYnr." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 54, 478, DateTimeKind.Local).AddTicks(5160), "$2a$11$ozOD2DLfiSG01UTmvp1PheX0xTxse/zsdM8cn/igjFqT12FEU50j." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 9, 54, 605, DateTimeKind.Local).AddTicks(5844), "$2a$11$0Q6bYliuSHOmans1m9tARO4u8w4igjVrw30hPqw01Iq4caXHTBIN2" });
        }
    }
}
