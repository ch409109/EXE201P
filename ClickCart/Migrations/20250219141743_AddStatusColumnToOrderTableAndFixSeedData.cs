using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class AddStatusColumnToOrderTableAndFixSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 2, 14, 21, 17, 42, 858, DateTimeKind.Local).AddTicks(9709), "Delivered" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 2, 16, 21, 17, 42, 858, DateTimeKind.Local).AddTicks(9719), "Delivered" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 2, 18, 21, 17, 42, 858, DateTimeKind.Local).AddTicks(9720), "Delivered" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 21, 17, 41, 610, DateTimeKind.Local).AddTicks(3041), "$2a$11$wcbN1GmoRRrtpCGTkVwOfePffexVAFZdxb8eu9fBmWpySI7G.gStS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 21, 17, 41, 748, DateTimeKind.Local).AddTicks(386), "$2a$11$kjqmxdPTQAiCgO9DMhWRtOxw19Syf9drwe/CDxoZ77BdLLw/aUDbW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 21, 17, 41, 905, DateTimeKind.Local).AddTicks(3363), "$2a$11$vamzWcKH6vkSiEJTBC51PulWnMR4.528037pRmfqhwupM9Cg5.lwC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 21, 17, 42, 56, DateTimeKind.Local).AddTicks(3458), "$2a$11$5mt5N8LhjF3paVm8x8319.Q6DViForLLSZS1/I0l8GykSCAwbbKEC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 21, 17, 42, 189, DateTimeKind.Local).AddTicks(6551), "$2a$11$XW8v9hqAaTHLQ6AXz8CxbesiihgA/nq2lkQgo0YjfqtvbFANTB1l2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 21, 17, 42, 323, DateTimeKind.Local).AddTicks(77), "$2a$11$sGXhWQIFiU1cStYFtGXfnenn3yZumk7pep9Ehg2FZUfvMlfZq7Sxi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 21, 17, 42, 455, DateTimeKind.Local).AddTicks(7766), "$2a$11$cVYmdkeFn6uNnoIJItIqbOdCZF92XtTLa6QjV4NPU49Drzpylp9a." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 21, 17, 42, 590, DateTimeKind.Local).AddTicks(1663), "$2a$11$UwScLQSyzpOSD6fy69zK9uFJdVMuJ3RHCFbfQOvwb5m1WVFK3sRzq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 21, 17, 42, 726, DateTimeKind.Local).AddTicks(1062), "$2a$11$.kclQvCvsWY4VMOC0kA5GOJRLg3d7vWjWq4flNqkXZ5kMc5/N.sH6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 21, 17, 42, 858, DateTimeKind.Local).AddTicks(8930), "$2a$11$dqE0O8LkcykcvqIjq5TXPuGDA.f5FxVFQFJBJNoK9pHbkLjOZVYVu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

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
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 36, 965, DateTimeKind.Local).AddTicks(5916), "$2a$11$W7qE05pb5LqKM66z1N2XCeG4dBgY2YZ7k/PQKklAaLr72Ll6Kk26m" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 114, DateTimeKind.Local).AddTicks(3758), "$2a$11$ajh0smFMT/cukbIfjAnmcuWCVemcYMXL7rcSxofsKYbSmMBIGGpme" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 258, DateTimeKind.Local).AddTicks(3936), "$2a$11$6w0jBi/L3R2C05QObzPTqeCRh0mQqFX3MSnAVH2UktZnOT5PQzmaa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 392, DateTimeKind.Local).AddTicks(4552), "$2a$11$h7QXnpzXDZAVTwS6WgcN/uWYRMDefTD2uUvTXja8Aez2UaFunPa5G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 529, DateTimeKind.Local).AddTicks(927), "$2a$11$4CcLibnJT0iLNIvM8sZhguFwsRyHiSDsJeJ6c/Bg1cF6mUI9myQbG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 665, DateTimeKind.Local).AddTicks(257), "$2a$11$usds.Y3FtfptmovqiNhfM.ogmJPfCmAnntX.F9KM0H25mq3KLRMAS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 798, DateTimeKind.Local).AddTicks(9812), "$2a$11$qyGlCtt..fzE.Cd5dkkha.xlOu10US.cFUKT7zPmRdFQbwCq.FfLK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 37, 929, DateTimeKind.Local).AddTicks(9703), "$2a$11$3b0p.VDIs9OHYENTP9388.NN2buKOZ7hOgumSalrwZTQMSOVApoxm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 38, 61, DateTimeKind.Local).AddTicks(7588), "$2a$11$60tBwXrUZdS99NaKS5P4xu8oS9reXk.BV3IIs4sIa13qfYbcc/Zde" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 2, 19, 20, 56, 38, 194, DateTimeKind.Local).AddTicks(2720), "$2a$11$a3EH5hnLsQHm12aABIeN6Ofy1OISjVQ3rZJTZTX4aTyD9qS8u3yHy" });
        }
    }
}
