﻿// <auto-generated />
using System;
using ClickCart.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClickCart.Migrations
{
    [DbContext(typeof(ClickCartDbContext))]
    partial class ClickCartDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClickCart.Models.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("UserID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ClickCart.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemID"), 1L, 1);

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ClickCart.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ClickCart.Models.Combo", b =>
                {
                    b.Property<int>("ComboID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComboID"), 1L, 1);

                    b.Property<string>("ComboName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ComboID");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("ClickCart.Models.ComboProduct", b =>
                {
                    b.Property<int>("ComboID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ComboID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("ComboProducts");
                });

            modelBuilder.Entity("ClickCart.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentGateway")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ClickCart.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailID"), 1L, 1);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ClickCart.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAlcoholic")
                        .HasColumnType("bit");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ClickCart.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            CreatedAt = new DateTime(2025, 1, 22, 22, 31, 16, 626, DateTimeKind.Local).AddTicks(1180),
                            Email = "HaiLTHE172555@fpt.edu.vn",
                            FullName = "Lại Tuấn Hai",
                            PasswordHash = "$2a$11$LyatlCJrCHM/0pGzx.FxOeUu3/6q1KDCAVyc36OX8oPZbXXkFBfKG",
                            PhoneNumber = "0123456789",
                            Role = "Admin",
                            Username = "HaiAdmin"
                        },
                        new
                        {
                            UserID = 2,
                            CreatedAt = new DateTime(2025, 1, 22, 22, 31, 16, 779, DateTimeKind.Local).AddTicks(359),
                            Email = "HungPVHE161180@fpt.edu.vn",
                            FullName = "Phạm Việt Hưng",
                            PasswordHash = "$2a$11$YDFKDJnE3Dqxtwi0/8CJbOxxxnStzisU/NOCEDDeu4kBQz/vfqySO",
                            PhoneNumber = "0123456789",
                            Role = "Admin",
                            Username = "HungAdmin"
                        },
                        new
                        {
                            UserID = 3,
                            CreatedAt = new DateTime(2025, 1, 22, 22, 31, 16, 930, DateTimeKind.Local).AddTicks(7067),
                            Email = "CongHTHE172673@fpt.edu.vn",
                            FullName = "Hoàng Thành Công",
                            PasswordHash = "$2a$11$xBycT7OUUuRj1hl989eWoOHh0i6eGgYh0a0abmPot5Z740nUhTbmq",
                            PhoneNumber = "0123456789",
                            Role = "Admin",
                            Username = "CongAdmin"
                        },
                        new
                        {
                            UserID = 4,
                            CreatedAt = new DateTime(2025, 1, 22, 22, 31, 17, 102, DateTimeKind.Local).AddTicks(867),
                            Email = "NhatLVHE176909@fpt.edu.vn",
                            FullName = "Lê Việt Nhật",
                            PasswordHash = "$2a$11$SryPYI66g.6/tANYt1qsLeQUiW.je7puASwTZw6DXaA6ywVk95EDO",
                            PhoneNumber = "0123456789",
                            Role = "Admin",
                            Username = "NhatAdmin"
                        },
                        new
                        {
                            UserID = 5,
                            CreatedAt = new DateTime(2025, 1, 22, 22, 31, 17, 298, DateTimeKind.Local).AddTicks(9357),
                            Email = "TrongLCPHS176090@fpt.edu.vn",
                            FullName = "Lê Công Phú Trọng",
                            PasswordHash = "$2a$11$sZGjvmzDhgKHilIbNtt85uOMc1niqmJGYwk20wXlRpWxQAyn5aJ32",
                            PhoneNumber = "0123456789",
                            Role = "Admin",
                            Username = "TrongAdmin"
                        },
                        new
                        {
                            UserID = 6,
                            CreatedAt = new DateTime(2025, 1, 22, 22, 31, 17, 486, DateTimeKind.Local).AddTicks(5809),
                            Email = "DatVTHS176109@fpt.edu.vn",
                            FullName = "Vũ Tiến Đạt",
                            PasswordHash = "$2a$11$rNBB1PynWTH2br/AmaHcr.Jf9Nm8LCCs4nJfR8G4D58QeX7QfpVBq",
                            PhoneNumber = "0123456789",
                            Role = "Admin",
                            Username = "DatAdmin"
                        },
                        new
                        {
                            UserID = 7,
                            CreatedAt = new DateTime(2025, 1, 22, 22, 31, 17, 650, DateTimeKind.Local).AddTicks(8210),
                            Email = "TungNVHE170677@fpt.edu.vn",
                            FullName = "Nguyễn Việt Tùng",
                            PasswordHash = "$2a$11$dFFTMKTb7vyh5dirACJVf.9mSVxsDITBO2Ml31MmY1UE3K2xt85xO",
                            PhoneNumber = "0987654321",
                            Role = "User",
                            Username = "TungUser"
                        },
                        new
                        {
                            UserID = 8,
                            CreatedAt = new DateTime(2025, 1, 22, 22, 31, 17, 816, DateTimeKind.Local).AddTicks(9528),
                            Email = "ToanPMHE171369@fpt.edu.vn",
                            FullName = "Phan Mạnh Toàn",
                            PasswordHash = "$2a$11$mrB64xKJXD7B8fD.ejAmEuvoSQKnWO566Dz3YxMkE3UyYbNqiKcFW",
                            PhoneNumber = "0987654321",
                            Role = "User",
                            Username = "ToanUser"
                        },
                        new
                        {
                            UserID = 9,
                            CreatedAt = new DateTime(2025, 1, 22, 22, 31, 17, 982, DateTimeKind.Local).AddTicks(1829),
                            Email = "CuongPXHE172287@fpt.edu.vn",
                            FullName = "Phạm Xuân Cường",
                            PasswordHash = "$2a$11$EPV8uVU3mwpKNj2gwYN7Qu95abDSrighPdkoebotqgNaigydn.zrK",
                            PhoneNumber = "0987654321",
                            Role = "User",
                            Username = "CuongUser"
                        },
                        new
                        {
                            UserID = 10,
                            CreatedAt = new DateTime(2025, 1, 22, 22, 31, 18, 150, DateTimeKind.Local).AddTicks(3765),
                            Email = "AnhVNHE151076@fpt.edu.vn",
                            FullName = "Vũ Nam Anh",
                            PasswordHash = "$2a$11$mBJHjjxt1Oc5kXkxK7m5cuZ3TZbJ1OkHQn.n93v49NkJT.6qaVs42",
                            PhoneNumber = "0123456789",
                            Role = "User",
                            Username = "AnhUser"
                        });
                });

            modelBuilder.Entity("ClickCart.Models.Voucher", b =>
                {
                    b.Property<int>("VoucherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoucherID"), 1L, 1);

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VoucherCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("VoucherID");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("ClickCart.Models.Cart", b =>
                {
                    b.HasOne("ClickCart.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClickCart.Models.CartItem", b =>
                {
                    b.HasOne("ClickCart.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClickCart.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ClickCart.Models.ComboProduct", b =>
                {
                    b.HasOne("ClickCart.Models.Combo", "Combo")
                        .WithMany("ComboProducts")
                        .HasForeignKey("ComboID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClickCart.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Combo");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ClickCart.Models.Order", b =>
                {
                    b.HasOne("ClickCart.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClickCart.Models.OrderDetail", b =>
                {
                    b.HasOne("ClickCart.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ClickCart.Models.Product", b =>
                {
                    b.HasOne("ClickCart.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ClickCart.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("ClickCart.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ClickCart.Models.Combo", b =>
                {
                    b.Navigation("ComboProducts");
                });

            modelBuilder.Entity("ClickCart.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
