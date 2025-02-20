using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class AddPremiumTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Premiums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PremiumName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premiums", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Premiums");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 1, 6, 11, 194, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 18, 1, 6, 11, 194, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 1, 6, 11, 194, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 6, 9, 786, DateTimeKind.Local).AddTicks(2435), "$2a$11$zqMuV3Uji.fxz4CTFBAELOhF3.FP3gtPu7qK/IkWbAtzcr/Bphojm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 6, 9, 942, DateTimeKind.Local).AddTicks(9964), "$2a$11$mlwn.MxnPKbIHAKRiHk30.jhlgSZVtUZkEqJgMp4kdkXXhIs7uV7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 6, 10, 110, DateTimeKind.Local).AddTicks(9660), "$2a$11$MFCq69GwSpR9ZxhIoLa06uDCzFiTNTJXLjGHSc3lbkiLk69BypdtS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 6, 10, 305, DateTimeKind.Local).AddTicks(9485), "$2a$11$5fSB3FO0eNMCxnGTLnszm.r84/mQprCmKr690RxI4kFwqLu/UZ6pK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 6, 10, 464, DateTimeKind.Local).AddTicks(9804), "$2a$11$GsbDw8YSFqqoAiKXPg7b3ewtUs4MwFuQ7/fwAra/ZyQrvFOEoegqC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 6, 10, 611, DateTimeKind.Local).AddTicks(1136), "$2a$11$C80WdjtCHKE/3xwc50gQjeL2./sd3vswIRAmZcdbcmltAOHV6I8Hm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 6, 10, 771, DateTimeKind.Local).AddTicks(171), "$2a$11$8pwBSL0k4fqtiTdSzgsmsOERKGIYJd6nyICNs8PiluUGXr/bn2jlq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 6, 10, 933, DateTimeKind.Local).AddTicks(7102), "$2a$11$6WSpBbv0IFZo9FqeZOJ31.Rc8ZVOG5MzWE6MwRfMRC3fV175RBS6e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 6, 11, 63, DateTimeKind.Local).AddTicks(9409), "$2a$11$fKwqi2iXwpGNOZZ5Txr7FeHs.coESkAJLSpXbHF.oh/fDKTl/SFjS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 6, 11, 194, DateTimeKind.Local).AddTicks(2), "$2a$11$WoVVFNBC9/FHeBWhnhde2e.9Gx642u6T96OJ7h8Qp/DWfKp1qY2Oe" });
        }
    }
}
