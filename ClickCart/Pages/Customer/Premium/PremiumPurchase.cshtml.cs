using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ClickCart.Pages.Customer.Premium
{
    public class PremiumPurchaseModel : PageModel
    {
        private readonly ClickCartDbContext _context;

        public PremiumPurchaseModel(ClickCartDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPostPurchase(string packageType)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Login");
            }

            var userId = int.Parse(User.FindFirstValue("UserId"));

            var premium = new Models.Premium
            {
                UserId = userId,
                PremiumName = GetPremiumName(packageType),
                Price = GetPremiumPrice(packageType),
                PaymentStatus = "Pending",
            };

            _context.Premiums.Add(premium);
            _context.SaveChanges();

            return RedirectToPage("/Payment/Payment", new { premiumId = premium.Id });
        }

        private string GetPremiumName(string packageType)
        {
            return packageType switch
            {
                "Basic" => "Gói Premium Cơ Bản",
                "Pro" => "Gói Premium Pro",
                _ => "Unknown"
            };
        }

        private int GetPremiumPrice(string packageType)
        {
            return packageType switch
            {
                "Basic" => 49000,
                "Pro" => 99000,
                _ => 0
            };
        }
    }
}
