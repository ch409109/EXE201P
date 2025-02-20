using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class ModifyPremiumTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Premiums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 3, 17, 22, 695, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 18, 3, 17, 22, 695, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 3, 17, 22, 695, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 17, 21, 439, DateTimeKind.Local).AddTicks(4210), "$2a$11$v9eCJIFw/6k0w1Zn9GylOuka3AJrt5QDPh3zFT7H0d3n09ayMLU0C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 17, 21, 592, DateTimeKind.Local).AddTicks(5878), "$2a$11$zfppEidi6/ydz4EBrWlXj.vlAu9pfnzR7tX5GwYygIrx7.9xPG6IS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 17, 21, 737, DateTimeKind.Local).AddTicks(3745), "$2a$11$UmSBO2Joa9KXJg2JmIpPeuVQZQM.JbwKyoKfs.IZf6ZUnn/xT/rDS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 17, 21, 883, DateTimeKind.Local).AddTicks(1230), "$2a$11$WS48zZYbp6SsSt8h9IEJBeW9FGvB1ig6BAilewrXYx88EiPzD/EDa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 17, 22, 19, DateTimeKind.Local).AddTicks(1701), "$2a$11$lO6F1FjLzKqEaWez7J9fDu6q5nQB8kQAnyioT0SEuYvcoQ/i0JRry" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 17, 22, 152, DateTimeKind.Local).AddTicks(9107), "$2a$11$fF8hZnoeRXvQOqjxhYuLs.tuhfDy0xKOsRBa6A2SN2hhOWaStAJ1y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 17, 22, 287, DateTimeKind.Local).AddTicks(5868), "$2a$11$KZYS9bjZtVCNQg6.kYMkkexc2yZ8aGRoBwj.ncOCvjExYc4wCmide" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 17, 22, 422, DateTimeKind.Local).AddTicks(8551), "$2a$11$e5074yeCAexN4eKi0H7oKOz75swLutdZmPdvInygeJlu3YAvxbvIm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 17, 22, 561, DateTimeKind.Local).AddTicks(5091), "$2a$11$TUglAx4bes3ekwFn6wLnuenR6OdI4sh2nZNbdv2jjndRBNt74DSvO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 17, 22, 695, DateTimeKind.Local).AddTicks(6412), "$2a$11$vZojU0kB3ObiHWrzNz774ODqQYT7Hz5c76TJxSqzLB65RQtf5IEqS" });

            migrationBuilder.CreateIndex(
                name: "IX_Premiums_UserId",
                table: "Premiums",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Premiums_Users_UserId",
                table: "Premiums",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Premiums_Users_UserId",
                table: "Premiums");

            migrationBuilder.DropIndex(
                name: "IX_Premiums_UserId",
                table: "Premiums");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Premiums");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 1, 58, 15, 743, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 18, 1, 58, 15, 743, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 1, 58, 15, 743, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 58, 14, 147, DateTimeKind.Local).AddTicks(8000), "$2a$11$CV8VAepMOIkHBuFA7ilEGulOJ1GcZuJDW7WgC4zAd5TrzqOms/Kga" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 58, 14, 330, DateTimeKind.Local).AddTicks(4774), "$2a$11$wGQJR6bMMXx6NcmAbnmVfOH.xkW/wvqx8C1x1KoTluxATJNS1vwZG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 58, 14, 525, DateTimeKind.Local).AddTicks(6129), "$2a$11$ZEETZFJE.9oZ7aJ6nwTYXOmxxsz65Gz7JKqWmP2FZPpRWa4g0uL4." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 58, 14, 713, DateTimeKind.Local).AddTicks(6681), "$2a$11$5GWz7tLxEZyhAwwcmKZdsuOp62y.SunKtEotmeqPfhTvrzd4ISFOC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 58, 14, 887, DateTimeKind.Local).AddTicks(7189), "$2a$11$qYg9uUIAUI.wibY8mPvore7OrhyFRldNXahkzsWVcgWDhWg752bue" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 58, 15, 54, DateTimeKind.Local).AddTicks(2305), "$2a$11$TUF99QP5S.w5dLnhrGMiu.i57OQDJbal/v6IRoBSUv0yK2npFOaF." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 58, 15, 233, DateTimeKind.Local).AddTicks(9700), "$2a$11$KMb/IdSq.VIkO8I198XJs.ZxkWZGYNBPBXpjfgLAj90vofcMNzIp2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 58, 15, 411, DateTimeKind.Local).AddTicks(2135), "$2a$11$djVp9vq/nu0L/t8JUNCy5.DNt71BC5VyeQYeem9E9OdwgYu37iQr2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 58, 15, 578, DateTimeKind.Local).AddTicks(2889), "$2a$11$iQXEjzIdUfL12JYaWizLjuL3a0yCrqdN.ztR3N/ZzLM/nXBszXgBe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 58, 15, 743, DateTimeKind.Local).AddTicks(2469), "$2a$11$R7Cw0jhNUob.4TUZAc5.YuaJUCpcIMlulQGe6qj3RLm7PLi4oAowi" });
        }
    }
}
