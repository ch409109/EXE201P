using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickCart.Migrations
{
    public partial class InitialDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "CreatedAt", "Email", "FullName", "PasswordHash", "PhoneNumber", "Role", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 22, 22, 31, 16, 626, DateTimeKind.Local).AddTicks(1180), "HaiLTHE172555@fpt.edu.vn", "Lại Tuấn Hai", "$2a$11$LyatlCJrCHM/0pGzx.FxOeUu3/6q1KDCAVyc36OX8oPZbXXkFBfKG", "0123456789", "Admin", "HaiAdmin" },
                    { 2, new DateTime(2025, 1, 22, 22, 31, 16, 779, DateTimeKind.Local).AddTicks(359), "HungPVHE161180@fpt.edu.vn", "Phạm Việt Hưng", "$2a$11$YDFKDJnE3Dqxtwi0/8CJbOxxxnStzisU/NOCEDDeu4kBQz/vfqySO", "0123456789", "Admin", "HungAdmin" },
                    { 3, new DateTime(2025, 1, 22, 22, 31, 16, 930, DateTimeKind.Local).AddTicks(7067), "CongHTHE172673@fpt.edu.vn", "Hoàng Thành Công", "$2a$11$xBycT7OUUuRj1hl989eWoOHh0i6eGgYh0a0abmPot5Z740nUhTbmq", "0123456789", "Admin", "CongAdmin" },
                    { 4, new DateTime(2025, 1, 22, 22, 31, 17, 102, DateTimeKind.Local).AddTicks(867), "NhatLVHE176909@fpt.edu.vn", "Lê Việt Nhật", "$2a$11$SryPYI66g.6/tANYt1qsLeQUiW.je7puASwTZw6DXaA6ywVk95EDO", "0123456789", "Admin", "NhatAdmin" },
                    { 5, new DateTime(2025, 1, 22, 22, 31, 17, 298, DateTimeKind.Local).AddTicks(9357), "TrongLCPHS176090@fpt.edu.vn", "Lê Công Phú Trọng", "$2a$11$sZGjvmzDhgKHilIbNtt85uOMc1niqmJGYwk20wXlRpWxQAyn5aJ32", "0123456789", "Admin", "TrongAdmin" },
                    { 6, new DateTime(2025, 1, 22, 22, 31, 17, 486, DateTimeKind.Local).AddTicks(5809), "DatVTHS176109@fpt.edu.vn", "Vũ Tiến Đạt", "$2a$11$rNBB1PynWTH2br/AmaHcr.Jf9Nm8LCCs4nJfR8G4D58QeX7QfpVBq", "0123456789", "Admin", "DatAdmin" },
                    { 7, new DateTime(2025, 1, 22, 22, 31, 17, 650, DateTimeKind.Local).AddTicks(8210), "TungNVHE170677@fpt.edu.vn", "Nguyễn Việt Tùng", "$2a$11$dFFTMKTb7vyh5dirACJVf.9mSVxsDITBO2Ml31MmY1UE3K2xt85xO", "0987654321", "User", "TungUser" },
                    { 8, new DateTime(2025, 1, 22, 22, 31, 17, 816, DateTimeKind.Local).AddTicks(9528), "ToanPMHE171369@fpt.edu.vn", "Phan Mạnh Toàn", "$2a$11$mrB64xKJXD7B8fD.ejAmEuvoSQKnWO566Dz3YxMkE3UyYbNqiKcFW", "0987654321", "User", "ToanUser" },
                    { 9, new DateTime(2025, 1, 22, 22, 31, 17, 982, DateTimeKind.Local).AddTicks(1829), "CuongPXHE172287@fpt.edu.vn", "Phạm Xuân Cường", "$2a$11$EPV8uVU3mwpKNj2gwYN7Qu95abDSrighPdkoebotqgNaigydn.zrK", "0987654321", "User", "CuongUser" },
                    { 10, new DateTime(2025, 1, 22, 22, 31, 18, 150, DateTimeKind.Local).AddTicks(3765), "AnhVNHE151076@fpt.edu.vn", "Vũ Nam Anh", "$2a$11$mBJHjjxt1Oc5kXkxK7m5cuZ3TZbJ1OkHQn.n93v49NkJT.6qaVs42", "0123456789", "User", "AnhUser" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10);
        }
    }
}
