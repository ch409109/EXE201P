using Microsoft.EntityFrameworkCore;

namespace ClickCart.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ClickCartDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ClickCartDbContext>>()))
            {
                if (context.Vouchers.Any())
                {
                    return; 
                }

                context.Vouchers.AddRange(
                    new Voucher
                    {
                        VoucherCode = "DISCOUNT10",
                        DiscountPercentage = 10,
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(20),
                        IsActive = true
                    },
                    new Voucher
                    {
                        VoucherCode = "DISCOUNT20",
                        DiscountPercentage = 20,
                        StartDate = DateTime.Now.AddDays(-5),
                        EndDate = DateTime.Now.AddDays(15),
                        IsActive = true
                    },
                    new Voucher
                    {
                        VoucherCode = "DISCOUNT30",
                        DiscountPercentage = 30,
                        StartDate = DateTime.Now.AddDays(-15),
                        EndDate = DateTime.Now.AddDays(10),
                        IsActive = true
                    },
                    new Voucher
                    {
                        VoucherCode = "FREESHIP",
                        DiscountPercentage = 0,
                        StartDate = DateTime.Now.AddDays(-20),
                        EndDate = DateTime.Now.AddDays(30),
                        IsActive = true
                    },
                    new Voucher
                    {
                        VoucherCode = "WELCOME",
                        DiscountPercentage = 15,
                        StartDate = DateTime.Now.AddDays(-1),
                        EndDate = DateTime.Now.AddDays(25),
                        IsActive = true
                    },
                    new Voucher
                    {
                        VoucherCode = "SUMMER2023",
                        DiscountPercentage = 25,
                        StartDate = DateTime.Now.AddDays(-30),
                        EndDate = DateTime.Now.AddDays(60),
                        IsActive = true
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
