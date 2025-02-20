using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class InitialDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 16, 1, 2, 25, 364, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 18, 1, 2, 25, 364, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 1, 2, 25, 364, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 2, 23, 921, DateTimeKind.Local).AddTicks(2674), "$2a$11$x2KD3lDbLNH1xNtmp8kmL.F8aF66RaP0ouroJSEtc/2KhM4Pf.75m" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 2, 24, 85, DateTimeKind.Local).AddTicks(7476), "$2a$11$P6ihT.453HZUks4oupS0bem86L3dke/voRwLMUMFk137ZCYDe4vN6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 2, 24, 247, DateTimeKind.Local).AddTicks(8351), "$2a$11$T2o0VDBs3GPQFuchpGDyou0hz1mR3fnKVC5scLw.tJXdy87xuAj9q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 2, 24, 399, DateTimeKind.Local).AddTicks(6869), "$2a$11$uRNS8Q1zCP82F6uJG6LEyOuM7hwHS1s4R8Q8/ER4U5fg2x2kibWUu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 2, 24, 571, DateTimeKind.Local).AddTicks(3189), "$2a$11$uBeAKA4AjkEZfd/6HqGok.t002CnKg0bgrWhFor3FPL3k/WKQUXSi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 2, 24, 719, DateTimeKind.Local).AddTicks(2347), "$2a$11$gRxR3ulDcOUbKzKwO5u4T.Cz7aMQ3xH5wxsCZ62CuWeqKWouAknz6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 2, 24, 876, DateTimeKind.Local).AddTicks(5517), "$2a$11$d3KfeR89Qj/3Mfy0UoWN1uwGw5g6W5svzV0UOlWkukj4cREdHKm.2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 2, 25, 43, DateTimeKind.Local).AddTicks(5538), "$2a$11$t8t4w6655fiYEjdndug1ZukqBEmYdAA1z7oRnULzdTdv4iQCndWK2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 2, 25, 190, DateTimeKind.Local).AddTicks(5719), "$2a$11$KPrKhqo7eTCPpqLxfd7y7.itZDRN9N/2J6ZU5Izd9/ftWDUIqR6y." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 21, 1, 2, 25, 363, DateTimeKind.Local).AddTicks(8220), "$2a$11$Y2wdyRRQ1xU/846hJkY/peyD7XmFjiCR81e5RsCkdhyzHtG.cte2u" });
        }
    }
}
