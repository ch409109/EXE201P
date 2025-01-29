using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Pages.Admin.Dashboard
{
    public class IndexModel : PageModel
    {
        private readonly ClickCartDbContext _context;

        public IndexModel(ClickCartDbContext context)
        {
            _context = context;
        }

        public class MonthlyRevenue
        {
            public int Month { get; set; }
            public decimal TotalRevenue { get; set; }
        }

        public IList<Order> Orders { get; set; } = default!;
        public SelectList YearList { get; set; } = default!;
        public SelectList MonthList { get; set; } = default!;
        public List<MonthlyRevenue> MonthlyRevenueData { get; set; } = new List<MonthlyRevenue>();
        [BindProperty(SupportsGet = true)]
        public int? SelectedYear { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? SelectedMonth { get; set; }

        public async Task OnGetAsync()
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            YearList = new SelectList(await _context.Orders
                .Select(o => o.CreatedAt.Year)
                .Distinct()
                .ToListAsync());
            MonthList = new SelectList(Enumerable.Range(1, 12).Select(i => new { Value = i, Text = $"Tháng {i}" }), "Value", "Text");

            MonthlyRevenueData = Enumerable.Range(1, 12).Select(month => new MonthlyRevenue
            {
                Month = month,
                TotalRevenue = 0
            }).ToList();

            var revenueData = await _context.Orders
                .Where(o => o.CreatedAt.Year == SelectedYear && o.PaymentStatus == "Paid")
                .GroupBy(o => o.CreatedAt.Month)
                .Select(g => new MonthlyRevenue
                {
                    Month = g.Key,
                    TotalRevenue = g.Sum(b => b.TotalAmount)
                }).ToListAsync();

            foreach (var data in revenueData)
            {
                MonthlyRevenueData.First(m => m.Month == data.Month).TotalRevenue = data.TotalRevenue;
            }
        }
    }
}
